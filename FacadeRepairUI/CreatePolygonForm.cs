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
    public partial class CreatePolygonForm : Form
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

                mainPolygon.points.Add(p);

                WireUpList();

                xValue.Text = "";
                yValue.Text = "";
            }
        }

        private void editPointButton_Click(object sender, EventArgs e)
        {
            if ((PointModel)pointsListBox.SelectedItem != null)
            {
                foreach (var point in mainPolygon.points)
                {
                    if(pointsListBox.SelectedItem.Equals(point))
                    {
                        point.x = double.Parse(xValue.Text);
                        point.y = double.Parse(yValue.Text);
                    }
                }

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

                callingForm.PolygonComplete(mainPolygon);
                this.Close();
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
                output = false;
                incorrectXValue.ForeColor = Color.Red;
            }
            else if (x < 0)
            {
                output = false;
                incorrectXValue.ForeColor = Color.Red;
            }
            else
            {
                incorrectXValue.ForeColor = Color.White;
            }

            if (!(double.TryParse(yValue.Text, out double y)))
            {
                output = false;
                incorrectYValue.ForeColor = Color.Red;
            }
            else if (y < 0)
            {
                output = false;
                incorrectYValue.ForeColor = Color.Red;
            }
            else
            {
                incorrectYValue.ForeColor = Color.White;
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

            if (mainPolygon.points.Count() < 3 || mainPolygon.points.Count() > 250)
            {
                output = false;
                MessageBox.Show("Error. You need at least 3 points, but less than 250 points, to make polygon!");
            }
            //float delta = A1 * B2 - A2 * B1;

            //if (delta == 0)
            //    throw new ArgumentException("Lines are parallel");

            //float x = (B2 * C1 - B1 * C2) / delta;
            //float y = (A1 * C2 - A2 * C1) / delta;

            // TODO - Is polygon possible to constract

            return output;
        }

        private void pointsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateSelectedValues();
        }

        private void CreatePolygonForm_Load(object sender, EventArgs e)
        {
            incorrectXValue.ForeColor = Color.White;
            incorrectYValue.ForeColor = Color.White;
        }
    }
}