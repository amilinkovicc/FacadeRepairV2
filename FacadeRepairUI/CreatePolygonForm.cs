using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacadeRepairLibrary;
using FacadeRepairLibrary.DataAccess;
using FacadeRepairLibrary.Model;

namespace FacadeRepairUI
{
    public partial class CreatePolygonForm : Form, IPolygonViewRequester
    {
        private readonly IPolygonRequester callingForm;
        private readonly PolygonModel mainPolygon = new PolygonModel();

        public CreatePolygonForm(IPolygonRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            WireUpList();
        }

        public CreatePolygonForm(IPolygonRequester caller, PolygonModel p)
        {
            InitializeComponent();

            callingForm = caller;

            mainPolygon = p;

            WireUpList();
        }

        private void addPointButton_Click(object sender, EventArgs e)
        {
            if (ValidatePoint())
            {
                PointModel p = new PointModel(xValue.Text, yValue.Text);

                // TODO - DELETE?
                //p = GlobalConfig.Connection.CreatePoint(p);

                mainPolygon.points.Add(p);

                WireUpList();

                xValue.Text = "";
                yValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private void editPointButton_Click(object sender, EventArgs e)
        {
            PointModel p = (PointModel)pointsListBox.SelectedItem;

            if (p != null)
            {
                p.x = double.Parse(xValue.Text);
                p.y = double.Parse(yValue.Text);


                WireUpList();
            }
        }

        private void deletePointButton_Click(object sender, EventArgs e)
        {
            PointModel p = (PointModel)pointsListBox.SelectedItem;

            if (p != null)
            {
                mainPolygon.points.Remove(p);

                WireUpList();
            }
        }

        private void createPolygonButton_Click(object sender, EventArgs e)
        {
            if (ValidatePolygon())
            {
                GlobalConfig.Connection.CreatePolygonId(mainPolygon);
                GlobalConfig.Connection.SavePolygon(mainPolygon);

                if (callingForm.PolygonName() == "CreateFacadeForm")
                {
                    // Connect with FacadeViewerForm
                    PolygonViewerForm frm = new PolygonViewerForm(this, mainPolygon);
                    frm.Show();
                    this.Close();
                }
                else if (callingForm.PolygonName() == "FacadeViewerForm")
                {
                    callingForm.PolygonComplete(mainPolygon);
                    this.Close();
                }

                // TODO - If we aren't closing this form after creation, reset the form.
                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }
               
        private void WireUpList()
        {
            pointsListBox.DataSource = null;
            pointsListBox.DataSource = mainPolygon.points;
            pointsListBox.DisplayMember = "Coordinates";
        }

        /// <summary>
        /// Writes selected point values(from pointsListBox) to textBox (xValue and yValue).
        /// </summary>
        private void UpdateSelectedValues()
        {
            PointModel p = (PointModel)pointsListBox.SelectedItem;
            if (p != null)
            {
                xValue.Text = Convert.ToString(p.x);
                yValue.Text = Convert.ToString(p.y);
            }

        }


        /// <summary>
        /// Checks if the coordinates of the point are valid.
        /// </summary>
        /// <returns></returns>
        private bool ValidatePoint()
        {
            bool output = true;

            if (!(double.TryParse(xValue.Text, out double x)))
            {
                // You can just return false in every if and at the end return true.
                // This way if you add messages that explain what is wrong with the input, user will get all messages at once instead one by one.
                output = false;
            }

            if (!(double.TryParse(yValue.Text, out double y)))
            {
                output = false;
            }

            if (x < 0 || y < 0)
            {
                output = false;
            }

            if (mainPolygon.points.Count() < 3)
            {
                output = false;
            }
            // TODO - It shouldn't be possible to add point out of facade.
            //if (x > width || y > height)
            //{
            //    output = false;
            //}

            return output;
        }

        private bool ValidatePolygon() 
        {
            bool output = true;

            // TODO - Is polygon possible to constract

            return output;
        }

        private void pointsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateSelectedValues();
        }

        public void PolygonViewComplete(PolygonModel polygonModel)
        {
            throw new NotImplementedException();
        }
    }
}
