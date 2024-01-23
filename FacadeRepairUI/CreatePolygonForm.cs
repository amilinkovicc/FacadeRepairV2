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
        private List<PointModel> pointsOfPolygon = GlobalConfig.Connection.GetPointsAll();

        public CreatePolygonForm()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpList();
        }

        private void CreateSampleData()
        {
            pointsOfPolygon.Add(new PointModel { x = 5, y = 10 });
            pointsOfPolygon.Add(new PointModel { x = 20, y = 40 });
            pointsOfPolygon.Add(new PointModel { x = 75, y = 30 });
        }

        private void WireUpList()
        {
            pointsListBox.DataSource = null;
            pointsListBox.DataSource = pointsOfPolygon;
            pointsListBox.DisplayMember = "Cordinates";
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

        private void createPolygonButton_Click(object sender, EventArgs e)
        {
            if (ValidatePolygon())
            {
                PolygonModel polygon = new PolygonModel();

                polygon.points = pointsOfPolygon;

                polygon = GlobalConfig.Connection.CreatePolygon(polygon);
            }

            // TODO - If we aren't closing this form after creation, reset the form.
        }

        private void addPointButton_Click(object sender, EventArgs e)
        {
            if (ValidatePoint())
            {
                PointModel p = new PointModel(xValue.Text, yValue.Text);

                p = GlobalConfig.Connection.CreatePoint(p);

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

        /// <summary>
        /// Checks if the coordinates of the point are valid.
        /// </summary>
        /// <returns></returns>
        private bool ValidatePoint()
        {
            bool output = true;
            int x = 0, y = 0;

            if (!(int.TryParse(xValue.Text, out x)))
            {
                // You can just return false in every if and at the end return true.
                // This way if you add messages that explain what is wrong with the input, user will get all messages at once instead one by one.
                output = false;
            }

            if (!(int.TryParse(yValue.Text, out y)))
            {
                output = false;
            }

            if (x < 0 || y < 0)
            {
                output = false;
            }

            // TODO - It shouldn't be possible to add point out of facade.

            return output;
        }

        private bool ValidatePolygon() 
        {
            bool output = true;

            // TODO - Is polygon possible to constract

            return output;
        }

        private void deletePointButton_Click(object sender, EventArgs e)
        {
            PointModel p = (PointModel)pointsListBox.SelectedItem;

            if ( p != null )
            {
                pointsOfPolygon = GlobalConfig.Connection.DeletePoint(p);
                WireUpList();
            }
        }

        private void pointsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateSelectedValues();
        }

        private void editPointButton_Click(object sender, EventArgs e)
        {
            PointModel p = (PointModel)pointsListBox.SelectedItem;

            if (p != null)
            {
                List<PointModel> editedPoints = new List<PointModel>();
                editedPoints = GlobalConfig.Connection.EditPoint(p, xValue.Text, yValue.Text);

                pointsOfPolygon = editedPoints;

                WireUpList();
            }
        }
    }
}
