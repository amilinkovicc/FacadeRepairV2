using FacadeRepairLibrary;
using FacadeRepairLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadeRepairUI
{
    public partial class PolygonViewerForm : Form, IPolygonRequester
    {
        private const int Height = 850;
        private const int Width = 630;
        private List<Point> points = new List<Point>();
        private bool drawPicture = false;

        private PolygonModel polygonModel;
        IPolygonRequester callingForm;


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
                polygonNameValue.Text = polygonModel.NameOfPolygon;
                polygonPerimeterValue.Text = Convert.ToString(Math.Round(polygonModel.perimeter, 4));
                polygonSurfaceAreaValue.Text = Convert.ToString(Math.Round(polygonModel.surfaceArea, 4));
                polygonDiametreValue.Text = Convert.ToString(Math.Round(polygonModel.diameter, 4));
                pointsListBox.DataSource = polygonModel.points;
                pointsListBox.DisplayMember = "Coordinates";

                AddPolygonPoints(polygonModel.points);
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
            drawPicture = !drawPicture;
            polygonRepresentationPictureBox.Invalidate();
            WireUpList();
        }

        public void AddPolygonPoints(List<PointModel> polygonPoints)
        {
            // Calculate relation between image size and PictureBox size and scale coordinates according to it
            double scaleX = (Width - 30) / polygonPoints.Max(p => p.x);
            double scaleY = (Height - 50) / polygonPoints.Max(p => p.y);

            // Load polygon points
            foreach (PointModel p in polygonPoints)
            {
                points.Add(new Point((int)(scaleX * p.x), (int)(scaleY * p.y)));
            }
        }

        private void polygonRepresentationPictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Create a Graphics object from the PictureBox
            Graphics graphic = e.Graphics;
            graphic.Clear(Color.White);

            // Draw the polygon using the Graphics object
            if (drawPicture) // True if user came back from CreatePolygonForm
            {
                graphic.DrawPolygon(Pens.Black, points.ToArray());
                graphic.FillPolygon(Brushes.Blue, points.ToArray());
            }
        }
    }
}
