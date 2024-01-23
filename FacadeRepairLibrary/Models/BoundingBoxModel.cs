using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRepairLibrary.Model
{
    /// <summary>
    /// Defines the BoundingBox for a specific polygon.
    /// </summary>
    public class BoundingBoxModel
    {
        /// <summary>
        /// List of points that are defining the BoundingBox.
        /// </summary>
        public List<PointModel> points { get; set; }
    }
}
