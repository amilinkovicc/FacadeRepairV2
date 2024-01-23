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
    public partial class CreateFacadeForm : Form
    {
        public CreateFacadeForm()
        {
            InitializeComponent();
        }

        // TODO - Wire up typeOfDamageDropDown and enum DamageType
        // TODO - Get info for polygonListBox from SavedData

        private void createFacadeButton_Click(object sender, EventArgs e)
        {
            if (ValidateFacade())
            {
                FacadeModel model = new FacadeModel();

                model.objectName = objectNameValue.Text;
                model.objectAddress = objectAddressValue.Text;
                model.objectOwner = objectOwnerValue.Text;
                model.objectWidth = double.Parse(objectWidthValue.Text);
                model.objectHeight = double.Parse(objectHeightValue.Text);
                model.damageType = (DamageType)Enum.Parse(typeof(DamageType), typeOfDamageDropDown.Text, true);


                GlobalConfig.Connection.CreateFacade(model);

                objectNameValue.Text = "";          // "" == string.Empty
                objectAddressValue.Text = "";
                objectOwnerValue.Text = "";
                objectWidthValue.Text = "";
                objectHeightValue.Text = "";
                typeOfDamageDropDown.Text = "";
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
    }
}
