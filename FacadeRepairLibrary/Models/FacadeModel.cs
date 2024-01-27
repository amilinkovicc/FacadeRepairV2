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
        /// The price of fixing the object.
        /// </summary>
        public double price
        {
            get { return Price(damageType, polygons); }
            set { }
        }

        /// <summary>
        /// List of the polygons of the object that you're working on.
        /// </summary>
        public List<PolygonModel> polygons { get; set; } = new List<PolygonModel>();

        public string NameOfFacade
        {
            get { return $"{objectName}, Facade {Id}"; } // TODO - Come up with better names for polygons
        }

        private double Price(DamageType damageType, List<PolygonModel> polygons)
        {
            double price = 0;

            if (damageType == DamageType.Full)
            {
                price += objectWidth * objectHeight * 399.9;
            }
            else
            {
                for (int i = 0, m = polygons.Count; i < m; i++)
                {
                    if (polygons[i].surfaceArea < 3.33)
                    {
                        price += polygons[i].surfaceArea * 399.9 + polygons[i].perimeter * 129.99;
                    }
                    else
                    {
                        price += polygons[i].surfaceArea * 399.9 + polygons[i].perimeter * 550;
                    }
                }
            }

            return price;
        }
    }
}
