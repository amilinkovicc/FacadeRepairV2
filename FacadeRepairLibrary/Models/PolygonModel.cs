﻿using System;
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
        public double perimeter 
        {
            get { return Perimeter(points); }
            set { }
        }

        /// <summary>
        /// The surface area of the polygon.
        /// </summary>
        public double surfaceArea 
        {
            get { return SurfaceArea(points); }
            set { }
        }

        /// <summary>
        /// The diameter of the polygon.
        /// </summary>
        public double diameter 
        {
            get { return Diameter(points); }
            set { }
        }

        //public PolygonModel() { }

        //public PolygonModel(string[] props)
        //{
        //    PolygonModel p = new PolygonModel();
        //    p.Id = int.Parse(props[0]);
        //    p.perimeter = double.Parse(props[1]);
        //    p.surfaceArea = double.Parse(props[2]);
        //    p.diameter = double.Parse(props[3]);
        //    string temp = props[4]; // TODO - Finish conversion. List of points seperated with '|'

        //    //temp = "|(8,9)|(2,9)|(2,3)|(8,3)"
        //    string[] polygonPoints = temp.Split('|');
        //    for (int i = 1, n = polygonPoints.Count(); i < n; i++) //* i starts from 1 because polygonPoints[0] = ""
        //    {
        //        //(8 9)
        //        p.points.Add(new PointModel(Convert.ToString(polygonPoints[i][1]), Convert.ToString(polygonPoints[i][3])));
        //    }
        //}

        public string NameOfPolygon
        {
            get { return $"Polygon {Id}"; } // TODO - Come up with better names for polygons
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
    }
}
