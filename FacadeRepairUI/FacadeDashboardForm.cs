using FacadeRepairLibrary;
using FacadeRepairLibrary.Model;
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
    public partial class FacadeDashboardForm : Form, IFacadeRequester, IFacadeViewRequester
    {
        private readonly List<FacadeModel> facades = new List<FacadeModel>();
        FacadeModel facade = new FacadeModel();

        public FacadeDashboardForm()
        {
            InitializeComponent();

            WireUpDropDown();
        }

        private void createFacadeButton_Click(object sender, EventArgs e)
        {
            // Connect with CreateFacadeForm
            CreateFacadeForm frm = new CreateFacadeForm(this);
            frm.Show();
        }

        private void addPointButton_Click(object sender, EventArgs e)
        {
            facade = (FacadeModel)loadExistingFacadeDropDown.SelectedItem;

            if (facade != null)
            {
                // Connect with FacadeViewerForm
                FacadeViewerForm frm = new FacadeViewerForm(this, facade);
                frm.Show();
            }
        }

        private void WireUpDropDown()
        {
            loadExistingFacadeDropDown.DataSource = null;
            List<FacadeModel> facadeModels = GlobalConfig.Connection.GetAllFacades();

            if (facadeModels.Count > 0)
            {
                loadExistingFacadeDropDown.DataSource = facadeModels;
                loadExistingFacadeDropDown.DisplayMember = "NameOfFacade";
            }
        }

        public void FacadeComplete(FacadeModel facadeModel)
        {
            // Get back from a form a FacadeModel
            // Take the FacadeModel and put it into DropDown
            facades.Add(facadeModel);
            WireUpDropDown();
        }

        public void FacadeViewComplete(FacadeModel facadeModel)
        {
            // Get back from a form a edited FacadeModel
            // Take that FacadeModel, substitute previous one with it and update DropDown
            for (int i = 0, n = facades.Count; i < n; i++)
            {
                if (facades[i].Id == facadeModel.Id)
                {
                    facades[i] = facadeModel;
                }
            }

            WireUpDropDown();
        }

        public string FacadeName()
        {
            return this.Name;
        }
    }
}
