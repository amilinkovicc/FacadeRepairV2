using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRepairLibrary.Model
{
    /// <summary>
    /// Defines the point via Descartes coordinates.
    /// </summary>
    public class PointModel
    {
        // TODO - DELETE?
        /// <summary>
        /// The unique identifier for the point.
        /// </summary>
        //public int Id { get; set; }

        /// <summary>
        /// The x-coordinate of the point.
        /// </summary>
        public double x { get; set; }

        /// <summary>
        /// The y-coordinate of the point.
        /// </summary>
        public double y { get; set; }

        public PointModel(){ }

        public PointModel(string xValue, string yValue)
        {
            double xValueNumber = 0;
            double.TryParse(xValue, out xValueNumber);
            x = xValueNumber;

            double yValueNumber = 0;
            double.TryParse(yValue, out yValueNumber);
            y = yValueNumber;
        }

        public string Coordinates
        {
            get { return $"({x} {y})"; }
        }
    }
}
