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
        /// The unique identifier for the polygin.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// List of points defining the polygon.
        /// </summary>
        public List<PointModel> polygonPoints { get; set; } = new List<PointModel>();

        /// <summary>
        /// List of points defining the polygon.
        /// </summary>
        public List<PointModel> bbPoints
        {
            get { return BoundingBox(polygonPoints); }
            set { }
        }

        /// <summary>
        /// The perimeter of the polygon.
        /// </summary>
        public double perimeter
        {
            get { return Perimeter(bbPoints); }
            set { }
        }

        /// <summary>
        /// The surface area of the polygon.
        /// </summary>
        public double surfaceArea
        {
            get { return SurfaceArea(bbPoints); }
            set { }
        }

        /// <summary>
        /// The diameter of the polygon.
        /// </summary>
        public double diameter
        {
            get { return Diameter(bbPoints); }
            set { }
        }

        // TODO - Add summary

        private double Perimeter(List<PointModel> points)
        {
            double p = 0;
            int n = points.Count;
            for (int i = 0; i < n - 1; i++)
            {
                p += Math.Sqrt((points[i].x - points[i + 1].x) * (points[i].x - points[i + 1].x) + (points[i].y - points[i + 1].y) * (points[i].y - points[i + 1].y));
            }
            p += Math.Sqrt((points[n - 1].x - points[0].x) * (points[n - 1].x - points[0].x) + (points[n - 1].y - points[0].y) * (points[n - 1].y - points[0].y));
            return p;
        }

        private double SurfaceArea(List<PointModel> points)
        {
            double area = 0;
            int n = points.Count;
            for (int i = 0; i < n - 1; i++)
            {
                area += points[i].x * points[i + 1].y - points[i + 1].x * points[i].y;
            }
            area += points[n - 1].x * points[0].y - points[0].x * points[n - 1].y;
            area /= 2;
            return area;
        }

        private double Diameter(List<PointModel> points)
        {
            double diam = 0;
            for (int i = 0, n = points.Count(); i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double trenutno = Math.Sqrt((points[i].x - points[j].x) * (points[i].x - points[j].x) + (points[i].x - points[j].x) * (points[i].x - points[j].x));
                    if (trenutno > diam)
                    {
                        diam = trenutno;
                    }
                }
            }

            return diam;
        }

        private List<PointModel> BoundingBox (List<PointModel> points)
        {
            List<PointModel> rectangle = new List<PointModel>();

            double minX, minY, maxX, maxY;
            minX = points[0].x;
            maxX = points[0].x;
            minY = points[0].y;
            maxY = points[0].y;

            for (int i = 1, n = points.Count(); i < n; i++)
            {
                if (minX > points[i].x)
                {
                    minX = points[i].x;
                }
                if (maxX < points[i].x)
                {
                    maxX = points[i].x;
                }
                if (minY > points[i].y)
                {
                    minY = points[i].y;
                }
                if (maxY < points[i].y)
                {
                    maxY = points[i].y;
                }
            }

            rectangle.Add(new PointModel(Convert.ToString(minX), Convert.ToString(minY)));
            rectangle.Add(new PointModel(Convert.ToString(maxX), Convert.ToString(minY)));
            rectangle.Add(new PointModel(Convert.ToString(maxX), Convert.ToString(maxY)));
            rectangle.Add(new PointModel(Convert.ToString(minX), Convert.ToString(maxY)));

            return rectangle;
        }
    }
}
