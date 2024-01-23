using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRepairLibrary.Model
{
    /// <summary>
    /// Defines the damaged area.
    /// </summary>
    public class PolygonModel
    {
        /// <summary>
        /// The unique identifier for the polygin.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// List of points defining the polygon.
        /// </summary>
        public List<PointModel> points { get; set; } = new List<PointModel>();

        /// <summary>
        /// The perimeter of the polygon.
        /// </summary>
        public double perimeter { get; set; }

        /// <summary>
        /// The surface area of the polygon.
        /// </summary>
        public double surfaceArea { get; set; }

        /// <summary>
        /// The diameter of the polygon.
        /// </summary>
        public double diameter { get; set; }

    }
}
