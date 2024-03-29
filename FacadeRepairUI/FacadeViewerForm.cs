﻿using FacadeRepairLibrary;
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
using static System.Net.Mime.MediaTypeNames;

namespace FacadeRepairUI
{
    public partial class FacadeViewerForm : Form, IFacadeRequester
    {
        private const int facadeHeight = 872;
        private const int facadeWidth = 630;
        private readonly List<List<Point>> facadePolygons = new List<List<Point>>();// List in list because we need list of points from list of polygons
        private readonly List<Point> polygonPoints = new List<Point>();
        private bool drawPicture = false;

        FacadeModel mainFacade;
        private readonly IFacadeViewRequester callingForm;

        public FacadeViewerForm(IFacadeViewRequester caller, FacadeModel f)
        {
            InitializeComponent();

            callingForm = caller;

            mainFacade = f;

            WireUpList();
        }

        private void WireUpList()
        {
            polygonsListBox.DataSource = null;
            if (mainFacade != null)
            {
                facadeNameValue.Text = mainFacade.NameOfFacade;
                objectNameValue.Text = mainFacade.objectName;
                objectAddressValue.Text = mainFacade.objectAddress;
                objectOwnerValue.Text = mainFacade.objectOwner;
                damageTypeValue.Text = Convert.ToString(mainFacade.damageType);

                polygonsListBox.DataSource = mainFacade.polygons;
                polygonsListBox.DisplayMember = "NameOfPolygon";

                AddPolygons(mainFacade.polygons);

                if (callingForm != null)
                {
                    drawPicture = true;
                    facadeRepresentationPicturebox.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //Calculate Price
        {
            MessageBox.Show($"Repair price is {mainFacade.price}.");
        }

        private void editFacadeButton_Click(object sender, EventArgs e)
        {
            // Connect with CreateFacadeForm
            CreateFacadeForm frm = new CreateFacadeForm(this, mainFacade);
            frm.Show();
            this.Close();
        }

        public void AddPolygons(List<PolygonModel> polygonsOfFacade)
        {
            // Calculate relation between image size and PictureBox size and scale coordinates according to it
            double scaleX = facadeWidth / mainFacade.objectWidth;
            double scaleY = facadeHeight / mainFacade.objectHeight;

            // Load polygon points
            foreach (PolygonModel polygon in polygonsOfFacade)
            {
                foreach (PointModel p in polygon.points)
                {
                    polygonPoints.Add(new Point((int)(scaleX * p.x), (int)(scaleY * p.y)));
                }

                facadePolygons.Add(polygonPoints);
            }
        }

        private void facadeRepresentationPicturebox_Paint(object sender, PaintEventArgs e)
        {
            // Create a Graphics object from the PictureBox
            Graphics graphic = e.Graphics;
            graphic.Clear(Color.White);

            // Draw the polygon using the Graphics object
            if (drawPicture && polygonPoints.Count > 0)
            {
                foreach (var polygons in facadePolygons)
                {
                    graphic.DrawPolygon(Pens.Black, polygons.ToArray());
                    graphic.FillPolygon(Brushes.Blue, polygons.ToArray());
                }
            }
        }

        public void FacadeComplete(FacadeModel model)
        {
            //Get back from a form a FacadeModel
            // Take the FacadeModel and put it into facadesListBox
            mainFacade = model;
            //drawPicture = true;
            //facadeRepresentationPicturebox.Invalidate();
            WireUpList();
        }

        public string FacadeName()
        {
            return this.Name;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            callingForm.FacadeViewComplete(mainFacade);
            this.Close();
        }

        private void FacadeViewerForm_Load(object sender, EventArgs e)
        {
            //WireUpList();
        }
    }
}
