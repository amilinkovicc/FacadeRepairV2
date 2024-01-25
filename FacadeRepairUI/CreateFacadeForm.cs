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
using System.Reflection;

namespace FacadeRepairUI
{
    public partial class CreateFacadeForm : Form, IPolygonViewRequester, IPolygonRequester
    {
        private List<PolygonModel> polygonsOfFacade = new List<PolygonModel>();
        IPolygonViewRequester callingPolygonViewerForm;
        IPolygonRequester callingCreatePolygonForm;

        IFacadeRequester callingCreateFacadeForm;

        public CreateFacadeForm(IFacadeRequester caller)
        {
            InitializeComponent();

            callingCreateFacadeForm = caller;

            WireUpList();
        }

        // TODO - Wire up typeOfDamageDropDown and enum DamageType
        // TODO - Get info for polygonListBox from SavedData

        private void addPolygonButton_Click(object sender, EventArgs e)
        {
            DamageType.TryParse(typeOfDamageDropDown.Text, out DamageType damage);

            if (damage == DamageType.Partially)
            {
                // Connect with CreatePolygonForm
                CreatePolygonForm frm = new CreatePolygonForm(this);
                frm.Show();
            }
        }

        private void loadPolygonButton_Click(object sender, EventArgs e)
        {
            PolygonModel p = (PolygonModel)polygonsListBox.SelectedItem;

            if (p != null)
            {
                // Connect with PolygonViewerForm
                PolygonViewerForm frm = new PolygonViewerForm(this, p);
                frm.Show();
            }
        }

        private void deletePolygonButton_Click(object sender, EventArgs e)
        {
            PolygonModel p = (PolygonModel)polygonsListBox.SelectedItem;

            if (p != null)
            {
                polygonsOfFacade.Remove(p);

                WireUpList();
            }
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

                DamageType.TryParse(typeOfDamageDropDown.Text, out DamageType damage);
                
                if (damage == DamageType.Partially)
                {
                    facade.polygons = polygonsOfFacade; 
                }

                GlobalConfig.Connection.CreateFacadeId(facade);
                GlobalConfig.Connection.SaveFacede(facade);

                // TODO - Connect this form with FacadeViewerForm
                //callingForm.PolygonComplete(polygon);

                // TODO - If we aren't closing this form after creation, reset the form.
                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private void WireUpList()
        {
            polygonsListBox.DataSource = null;
            polygonsListBox.DataSource = polygonsOfFacade;
            polygonsListBox.DisplayMember = "NameOfPolygon";
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

        public void PolygonComplete(PolygonModel polygonModel)
        {
            // Get back from a form a PoligonModel
            // Take the PolygonModel and put it into polygonsListBox
            polygonsOfFacade.Add(polygonModel);
            WireUpList();
        }

        public void PolygonViewComplete(PolygonModel polygonModel)
        {
            // Get back from a form a PoligonModel
            // Take the PolygonModel and put it into polygonsListBox
            polygonsOfFacade.Add(polygonModel);
            WireUpList();
        }

    }
}
