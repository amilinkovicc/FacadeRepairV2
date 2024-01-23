using FacadeRepairLibrary.Model;
using FacadeRepairLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadeRepairUI
{
    public partial class CreateFacadeForm : Form, IPolygonRequester
    {
        private List<PolygonModel> polygonsOfFacade = new List<PolygonModel>();

        public CreateFacadeForm()
        {
            InitializeComponent();

            WireUpList();
        }

        // TODO - Wire up typeOfDamageDropDown and enum DamageType
        // TODO - Get info for polygonListBox from SavedData

        private void WireUpList()
        {
            polygonsListBox.DataSource = null;
            polygonsListBox.DataSource = polygonsOfFacade;
            polygonsListBox.DisplayMember = "NameOfPolygon";
        }

        private void createFacadeButton_Click(object sender, EventArgs e)
        {
            if (ValidateFacade())
            {
                FacadeModel facade = new FacadeModel();

                facade.objectName = objectNameValue.Text;
                facade.objectAddress = objectAddressValue.Text;
                facade.objectOwner = objectOwnerValue.Text;
                facade.objectWidth = double.Parse(objectWidthValue.Text);
                facade.objectHeight = double.Parse(objectHeightValue.Text);
                facade.damageType = (DamageType)Enum.Parse(typeof(DamageType), typeOfDamageDropDown.Text, true);

                facade.polygons = polygonsOfFacade;

                facade = GlobalConfig.Connection.CreateFacade(facade);


                this.Close();

                /*objectNameValue.Text = "";          // "" == string.Empty
                objectAddressValue.Text = "";
                objectOwnerValue.Text = "";
                objectWidthValue.Text = "";
                objectHeightValue.Text = "";
                typeOfDamageDropDown.Text = "";
                polygonsListBox.Text = "";*/
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateFacade ()
        {
            bool output = true;

            if (objectNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (objectAddressValue.Text.Length == 0)
            {
                output = false;
            }

            if (objectOwnerValue.Text.Length == 0)
            {
                output = false;
            }

            int height = 0, width = 0;

            if (!(int.TryParse(objectHeightValue.Text, out height)))
            {
                output = false;
            }

            if (!(int.TryParse(objectWidthValue.Text, out width)))
            {
                output = false;
            }

            if (height <= 0 || width <= 0)
            {
                output = false;
            }

            DamageType damageType;

            if(!(Enum.TryParse(typeOfDamageDropDown.Text, true, out damageType)))
            {
                output = false;
            }

            return output;
        }

        private void addPolygonButton_Click(object sender, EventArgs e)
        {
            // Connect with CreatePolygonForm
            CreatePolygonForm frm = new CreatePolygonForm(this);
            frm.Show();
        }

        public void PolygonComplete(PolygonModel polygonModel)
        {
            // Get back from a form a PoligonModel
            // Take the PolygonModel and put it into polygonsListBox
            polygonsOfFacade.Add(polygonModel);
            WireUpList();
        }
    }
}
