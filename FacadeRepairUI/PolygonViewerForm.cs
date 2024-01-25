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
    public partial class PolygonViewerForm : Form, IPolygonViewRequester
    {
        private PolygonModel polygonModel;
        IPolygonViewRequester callingForm;

        public PolygonViewerForm()
        {
            InitializeComponent();

            WireUpList();
        }

        private void WireUpList()
        {
            pointsListBox.DataSource = null;
            if (polygonModel != null)
            {
                polygonPerimeterValue.Text = Convert.ToString(polygonModel.perimeter);
                polygonSurfaceAreaValue.Text = Convert.ToString(polygonModel.surfaceArea);
                polygonDiametreValue.Text = Convert.ToString(polygonModel.diameter);
                pointsListBox.DataSource = polygonModel.points;
                pointsListBox.DisplayMember = "Coordinates";
            }
        }

        private void editPolygonButton_Click(object sender, EventArgs e)
        {
            // Connect with CreatePolygonForm
            CreatePolygonForm frm = new CreatePolygonForm(this);
            frm.Show();
        }

        public void PolygonComplete(PolygonModel model)
        {
            //Get back from a form a PoligonModel
            // Take the PolygonModel and put it into polygonsListBox
            polygonModel = model;
            WireUpList();
        }
    }
}
