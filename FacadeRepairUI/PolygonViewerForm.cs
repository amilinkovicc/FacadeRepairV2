using FacadeRepairLibrary;
using FacadeRepairLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadeRepairUI
{
    public partial class PolygonViewerForm : Form, IPolygonRequester, IBoundingBoxRequester
    {
        private const int pbHeight = 850;
        private const int pbWidth = 630;
        private readonly List<Point> points = new List<Point>();
        private bool drawPicture = false;

        PolygonModel mainPolygon;
        private readonly IPolygonViewRequester callingForm;

        public PolygonViewerForm(IPolygonViewRequester caller, PolygonModel p)
        {
            InitializeComponent();

            callingForm = caller;

            mainPolygon = p;

            WireUpList();
        }

        private void WireUpList()
        {
            pointsListBox.DataSource = null;
            if (mainPolygon != null)
            {
                polygonNameValue.Text = mainPolygon.NameOfPolygon;
                polygonPerimeterValue.Text = Convert.ToString(Math.Round(mainPolygon.perimeter, 4));
                polygonSurfaceAreaValue.Text = Convert.ToString(Math.Round(mainPolygon.surfaceArea, 4));
                polygonDiametreValue.Text = Convert.ToString(Math.Round(mainPolygon.diameter, 4));
                pointsListBox.DataSource = mainPolygon.points;
                pointsListBox.DisplayMember = "Coordinates";

                AddPolygonPoints(mainPolygon.points);

                if (callingForm != null)
                {
                    drawPicture = true;
                    polygonRepresentationPictureBox.Invalidate();
                }
            }
        }

        private void editPolygonButton_Click(object sender, EventArgs e)
        {
            // Connect with CreatePolygonForm
            CreatePolygonForm frm = new CreatePolygonForm(this, mainPolygon);
            frm.Show();
            this.Close();
        }

        public void AddPolygonPoints(List<PointModel> polygonPoints)
        {
            // Calculate relation between image size and PictureBox size and scale coordinates according to it
            double scaleX = (pbWidth - 30) / polygonPoints.Max(p => p.x);
            double scaleY = (pbHeight - 50) / polygonPoints.Max(p => p.y);

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

        public void PolygonComplete(PolygonModel model)
        {
            //Get back from a form a PoligonModel
            // Take the PolygonModel and put it into polygonsListBox
            mainPolygon = model;
            drawPicture = true;
            polygonRepresentationPictureBox.Invalidate();
            WireUpList();
        }

        public string PolygonName()
        {
            //TODO - Treba nesto da iradisi ili izbrisi
            //throw new NotImplementedException();
            return "";
        }

        public void BoundingBoxComplete(PolygonModel model)
        {
            //Get back from a form a PoligonModel
            // Take the PolygonModel and put it into polygonsListBox
            mainPolygon = model;
            drawPicture = true;
            polygonRepresentationPictureBox.Invalidate();
            WireUpList();
        }

        private void boundingBoxButton_Click(object sender, EventArgs e)
        {
            // Connect with BoundingBoxForm
            BoundingBoxForm frm = new BoundingBoxForm(this, mainPolygon);
            frm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            callingForm.PolygonViewComplete(mainPolygon);
            this.Close();
        }
    }
}
