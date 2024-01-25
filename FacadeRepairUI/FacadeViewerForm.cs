using FacadeRepairLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadeRepairUI
{
    public partial class FacadeViewerForm : Form, IFacadeRequester
    {
        private const int Height = 872;
        private const int Width = 630;
        private List<List<Point>> pointsOfPolygons = new List<List<Point>>();// List in list because we need list of points from list of polygons
        private bool drawPicture = false;

        private FacadeModel facadeModel;
        IFacadeViewRequester callingForm;

        public FacadeViewerForm(IFacadeViewRequester caller, FacadeModel f)
        {
            InitializeComponent();

            callingForm = caller;

            facadeModel = f;

            WireUpList();
        }

        private void WireUpList()
        {
            polygonsListBox.DataSource = null;
            if (facadeModel != null)
            {
                facadeNameValue.Text = facadeModel.NameOfFacade;
                objectNameValue.Text = facadeModel.objectName;
                objectAddressValue.Text = facadeModel.objectAddress;
                objectOwnerValue.Text = facadeModel.objectOwner;
                damageTypeValue.Text = Convert.ToString(facadeModel.damageType);

                polygonsListBox.DataSource = facadeModel.polygons;
                polygonsListBox.DisplayMember = "NameOfPolygon";

                //AddPolygonPoints(polygonModel.points);

                //if (callingForm != null)
                //{
                //    drawPicture = true;
                //    polygonRepresentationPictureBox.Invalidate();
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e) //Calculate Price
        {

        }

        private void editFacadeButton_Click(object sender, EventArgs e)
        {
            // Connect with CreateFacadeForm
            CreateFacadeForm frm = new CreateFacadeForm(this);
            frm.Show();
        }

        public void FacadeComplete(FacadeModel model)
        {
            //Get back from a form a FacadeModel
            // Take the FacadeModel and put it into facadesListBox
            facadeModel = model;
            drawPicture = true;
            facadeRepresentationPicturebox.Invalidate();
            WireUpList();
        }

        // TODO - Finish code
        //public void AddPolygonPoints(List<PointModel> polygonPoints)
        //{
        //    // Calculate relation between image size and PictureBox size and scale coordinates according to it
        //    double scaleX = (Width - 30) / polygonPoints.Max(p => p.x);
        //    double scaleY = (Height - 50) / polygonPoints.Max(p => p.y);

        //    // Load polygon points
        //    foreach (PointModel p in polygonPoints)
        //    {
        //        points.Add(new Point((int)(scaleX * p.x), (int)(scaleY * p.y)));
        //    }
        //}

        //private void polygonRepresentationPictureBox_Paint(object sender, PaintEventArgs e)
        //{
        //    // Create a Graphics object from the PictureBox
        //    Graphics graphic = e.Graphics;
        //    graphic.Clear(Color.White);

        //    // Draw the polygon using the Graphics object
        //    if (drawPicture) // True if user came back from CreatePolygonForm
        //    {
        //        graphic.DrawPolygon(Pens.Black, points.ToArray());
        //        graphic.FillPolygon(Brushes.Blue, points.ToArray());
        //    }
        //}
    }
}
