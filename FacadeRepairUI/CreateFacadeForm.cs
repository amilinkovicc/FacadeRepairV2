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
    public partial class CreateFacadeForm : Form, IPolygonRequester, IPolygonViewRequester
    {
        private readonly IFacadeRequester callingForm;
        private readonly FacadeModel mainFacade = new FacadeModel();

        public CreateFacadeForm(IFacadeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            WireUpList();
        }

        public CreateFacadeForm(IFacadeRequester caller, FacadeModel f)
        {
            InitializeComponent();

            callingForm = caller;

            mainFacade = f;
            UpdateValues(mainFacade);

            WireUpList();
        }

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
                mainFacade.polygons.Remove(p);

                WireUpList();
            }
        }

        private void createFacadeButton_Click(object sender, EventArgs e)
        {
            if (ValidateFacade())
            {
                mainFacade.objectName = objectNameValue.Text;
                mainFacade.objectAddress = objectAddressValue.Text;
                mainFacade.objectOwner = objectOwnerValue.Text;
                mainFacade.objectWidth = double.Parse(objectWidthValue.Text);
                mainFacade.objectHeight = double.Parse(objectHeightValue.Text);
                mainFacade.damageType = (DamageType)Enum.Parse(typeof(DamageType), typeOfDamageDropDown.Text, true);

                GlobalConfig.Connection.CreateFacadeId(mainFacade);
                GlobalConfig.Connection.SaveFacede(mainFacade);

                callingForm.FacadeComplete(mainFacade);
                this.Close();
            }
        }

        private void WireUpList()
        {
            polygonsListBox.DataSource = null;
            polygonsListBox.DataSource = mainFacade.polygons;
            polygonsListBox.DisplayMember = "NameOfPolygon";
        }

        private void UpdateValues(FacadeModel facadeModel)
        {
            if (facadeModel != null)
            {
                objectNameValue.Text = facadeModel.objectName;
                objectAddressValue.Text = facadeModel.objectAddress;
                objectOwnerValue.Text = facadeModel.objectOwner;
                objectWidthValue.Text = Convert.ToString(facadeModel.objectWidth);
                objectHeightValue.Text = Convert.ToString(facadeModel.objectHeight);
                typeOfDamageDropDown.Text = Convert.ToString(facadeModel.damageType);
            }
        }

        private bool ValidateFacade ()
        {
            bool output = true;

            if (objectNameValue.Text.Length == 0)
            {
                output = false;
                incorrectObjectNameValue.ForeColor = Color.Red;
            }
            else
            {
                incorrectObjectNameValue.ForeColor = Color.White;
            }

            if (objectAddressValue.Text.Length == 0)
            {
                output = false;
                incorrectObjectAddressValue.ForeColor = Color.Red;
            }
            else
            {
                incorrectObjectAddressValue.ForeColor = Color.White;
            }

            if (objectOwnerValue.Text.Length == 0)
            {
                output = false;
                incorrectObjectOwnerValue.ForeColor = Color.Red;
            }
            else
            {
                incorrectObjectOwnerValue.ForeColor= Color.White;
            }


            if (!(int.TryParse(objectHeightValue.Text, out int height)))
            {
                output = false;
                incorrectHeightValue.ForeColor = Color.Red;
            }
            else if (height < 0)
            {
                output = false;
                incorrectHeightValue.ForeColor = Color.Red;
            }
            else
            {
                incorrectHeightValue.ForeColor = Color.White;
            }

            if (!(int.TryParse(objectWidthValue.Text, out int width)))
            {
                output = false;
                incorrectWidthValue.ForeColor = Color.Red;
            }
            else if (width < 0)
            {
                output = false;
                incorrectWidthValue.ForeColor = Color.Red;
            }
            else
            {
                incorrectWidthValue.ForeColor = Color.White;
            }

            DamageType damageType;
            if (!Enum.TryParse(typeOfDamageDropDown.Text, true, out damageType))
            {
                output = false;
                MessageBox.Show("Error! Incorrect Type of Damage value!");
            }

            if(Convert.ToInt16(damageType) == 1 && polygonsListBox.Items.Count < 1)
            {
                output = false;
                MessageBox.Show("Error! You need at least one polygon to construct facade that is partially damaged!");
            }

            return output;
        }

        public void PolygonComplete(PolygonModel polygonModel)
        {
            // Get back from a form a PolygonModel
            // Take the PolygonModel, add it to FacadeModel.polygons and update polygonsListBox
            mainFacade.polygons.Add(polygonModel);
            WireUpList();
        }

        public void PolygonViewComplete(PolygonModel polygonModel)
        {
            // Get back from a form a PolygonModel
            // Take that PolygonModel, substitute previous one with it and update polygonsListBox
            for (int i = 0, n = mainFacade.polygons.Count; i < n; i++)
            {
                if (mainFacade.polygons[i].Id == polygonModel.Id)
                {
                    mainFacade.polygons[i] = polygonModel;
                }
            }

            WireUpList();
        }

        public string PolygonName()
        {
            return this.Name;
        }

        public double[] FacadeDimension()
        {
            double[] dimen = { double.Parse(objectWidthValue.Text), double.Parse(objectHeightValue.Text) };

            return dimen;
        }

        private void CreateFacadeForm_Load(object sender, EventArgs e)
        {
            incorrectObjectNameValue.ForeColor = Color.White;
            incorrectObjectAddressValue.ForeColor = Color.White;
            incorrectObjectOwnerValue.ForeColor = Color.White;
            incorrectHeightValue.ForeColor = Color.White;
            incorrectWidthValue.ForeColor = Color.White;

            foreach (var item in Enum.GetValues(typeof(DamageType)))
            {
                typeOfDamageDropDown.Items.Add(item);
            }
        }
    }
}
