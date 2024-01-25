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
using FacadeRepairLibrary;
using FacadeRepairLibrary.DataAccess;
using FacadeRepairLibrary.Model;

namespace FacadeRepairUI
{
    public partial class CreatePolygonForm : Form
    {
        private List<PointModel> pointsOfPolygon = new List<PointModel>();

        IPolygonRequester callingForm;

        public CreatePolygonForm(IPolygonRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            WireUpList();
        }

        private void addPointButton_Click(object sender, EventArgs e)
        {
            if (ValidatePoint())
            {
                PointModel p = new PointModel(xValue.Text, yValue.Text);

                // TODO - DELETE?
                //p = GlobalConfig.Connection.CreatePoint(p);

                pointsOfPolygon.Add(p);

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
                pointsOfPolygon.Remove(p);

                WireUpList();
            }
        }

        private void createPolygonButton_Click(object sender, EventArgs e)
        {
            if (ValidatePolygon())
            {
                PolygonModel polygon = new PolygonModel();

                polygon.points = pointsOfPolygon;

                GlobalConfig.Connection.CreatePolygonId(polygon);

                GlobalConfig.Connection.SavePolygon(polygon);

                callingForm.PolygonComplete(polygon);

                // TODO - If we aren't closing this form after creation, reset the form.
                this.Close();
            }
        }
               
        private void WireUpList()
        {
            pointsListBox.DataSource = null;
            pointsListBox.DataSource = pointsOfPolygon;
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
            double x = 0, y = 0;

            if (!(double.TryParse(xValue.Text, out x)))
            {
                // You can just return false in every if and at the end return true.
                // This way if you add messages that explain what is wrong with the input, user will get all messages at once instead one by one.
                output = false;
            }

            if (!(double.TryParse(yValue.Text, out y)))
            {
                output = false;
            }

            if (x < 0 || y < 0)
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

        public void PolygonComplete(PolygonModel polygonModel)
        {
            // Get back from a form a PoligonModel
            // Take the PolygonModel and put it into polygonsListBox
            //polygonsOfFacade.Add(polygonModel);
            //WireUpList();
        }
    }
}
