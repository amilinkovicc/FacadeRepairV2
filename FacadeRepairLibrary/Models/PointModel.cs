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
        /// <summary>
        /// The unique identifier for the point.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The x-coordinate of the point.
        /// </summary>
        public double x { get; set; }

        /// <summary>
        /// The y-coordinate of the point.
        /// </summary>
        public double y { get; set; }

        /// <summary>
        /// The foreign key. Connects point to the specific polygon.
        /// </summary>
        public int polygonId { get; set; }

        public PointModel(){ }

        public PointModel(string xValue, string yValue)
        {
            int xValueNumber = 0;
            int.TryParse(xValue, out xValueNumber);
            x = xValueNumber;

            int yValueNumber = 0;
            int.TryParse(yValue, out yValueNumber);
            y = yValueNumber;
        }

        public string Cordinates
        {
            get { return $"({x}, {y})"; }
        }
    }
}
