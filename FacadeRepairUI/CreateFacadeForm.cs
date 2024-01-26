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
    public partial class CreateFacadeForm : Form, IFacadeViewRequester, IPolygonRequester, IPolygonViewRequester
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

                //DamageType.TryParse(typeOfDamageDropDown.Text, out DamageType damage);
                
                //if (damage == DamageType.Partially)
                //{
                //    facade.polygons = mainFacade.polygons; 
                //}

                GlobalConfig.Connection.CreateFacadeId(mainFacade);
                GlobalConfig.Connection.SaveFacede(mainFacade);

                if (callingForm.FacadeName() == "FacadeDashboardForm")
                {
                    // Connect with FacadeViewerForm
                    FacadeViewerForm frm = new FacadeViewerForm(this, mainFacade);
                    frm.Show();
                    this.Close();
                }
                else if (callingForm.FacadeName() == "FacadeViewerForm")
                {
                    callingForm.FacadeComplete(mainFacade);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private void WireUpList()
        {
            polygonsListBox.DataSource = null;
            polygonsListBox.DataSource = mainFacade.polygons;
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

            if (!(int.TryParse(objectHeightValue.Text, out int height)))
            {
                output = false;
            }

            if (!(int.TryParse(objectWidthValue.Text, out int width)))
            {
                output = false;
            }

            if (height <= 0 || width <= 0)
            {
                output = false;
            }

            if (!Enum.TryParse(typeOfDamageDropDown.Text, true, out DamageType _))
            {
                output = false;
            }

            return output;
        }

        public void FacadeViewComplete(FacadeModel facadeModel)
        {
            //Nothing to do here.
            // TODO - Maybe invent some better algorithm?
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
    }
}
