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
    public partial class BoundingBoxForm : Form
    {
        private const int pbHeight = 850;
        private const int pbWidth = 630;
        private readonly List<Point> points = new List<Point>();

        private readonly IBoundingBoxRequester callingForm;
        BoundingBoxModel bbPolygon = new BoundingBoxModel();
        PolygonModel polygon;

        public BoundingBoxForm(IBoundingBoxRequester caller, PolygonModel p)
        {
            InitializeComponent();
            callingForm = caller;
            polygon = p;

            bbPolygon.Id = p.Id;
            bbPolygon.polygonPoints = p.points;

            WireUp();
        }
        private void WireUp()
        {
            bbPointsListBox.DataSource = null;
            if (bbPolygon != null)
            {
                bbPerimeterValue.Text = Convert.ToString(Math.Round(bbPolygon.perimeter, 4));
                bbSurfaceAreaValue.Text = Convert.ToString(Math.Round(bbPolygon.surfaceArea, 4));
                bbDiametreValue.Text = Convert.ToString(Math.Round(bbPolygon.diameter, 4));
                bbPointsListBox.DataSource = bbPolygon.bbPoints;
                bbPointsListBox.DisplayMember = "Coordinates";

                AddBBPoints(bbPolygon.bbPoints);
                bbRepresentationPictureBox.Invalidate();
            }
        }

        public void AddBBPoints(List<PointModel> polygonPoints)
        {
            // Calculate relation between image size and PictureBox size and scale coordinates according to it
            double scaleX = (pbWidth - 130) / polygonPoints.Max(p => p.x);
            double scaleY = (pbHeight - 150) / polygonPoints.Max(p => p.y);

            // Load polygon points
            foreach (PointModel p in polygonPoints)
            {
                points.Add(new Point((int)(scaleX * p.x), (int)(scaleY * p.y)));
            }
        }

        private void bbRepresentationPictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Create a Graphics object from the PictureBox
            Graphics graphic = e.Graphics;
            graphic.Clear(Color.White);

            // Draw the polygon using the Graphics object
            graphic.DrawPolygon(Pens.Black, points.ToArray());
            graphic.FillPolygon(Brushes.Green, points.ToArray());
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Get back to PolygonViewerForm 
            callingForm.BoundingBoxComplete(polygon);
            this.Close();
        }
    }
}