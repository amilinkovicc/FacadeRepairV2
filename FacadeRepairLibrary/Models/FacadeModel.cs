using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRepairLibrary.Model
{
    /// <summary>
    /// Defines the facade that you're working on.
    /// </summary>
    public class FacadeModel
    {
        /// <summary>
        /// The unique identifier for the facade.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the object that you're working on.
        /// </summary>
        public string objectName { get; set; }

        /// <summary>
        /// Address of the object that you're working on.
        /// </summary>
        public string objectAddress { get; set; }

        /// <summary>
        /// Owner of the object that you're working on.
        /// </summary>
        public string objectOwner { get; set; }

        /// <summary>
        /// The height of the object.
        /// </summary>
        public double objectHeight { get; set; }

        /// <summary>
        /// The width of the object.
        /// </summary>
        public double objectWidth { get; set; }

        /// <summary>
        /// Type of damage of the object that you're working on.
        /// </summary>
        public DamageType damageType { get; set; }

        /// <summary>
        /// List of the polygons of the object that you're working on.
        /// </summary>
        public List<PolygonModel> polygons { get; set; } = new List<PolygonModel>();
    }
}
