using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRepairLibrary.Model;
using FacadeRepairLibrary.DataAccess;

// * Load the text file
// * Convert the text to List<PointModel>
// * Find the max ID
// * Add the new record with the new ID (max + 1)
// * Convert the prizes to List<string>
// * Save the List<string> to the text file

namespace FacadeRepairLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        // TODO - summary

        public static string FullFilePath (this string fileName) //PointModel.csv
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PolygonModel> ConvertToPolygonModels(this List<string> lines)
        {
            List<PolygonModel> output = new List<PolygonModel> ();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PolygonModel p = new PolygonModel
                {
                    Id = int.Parse(cols[0]),
                    perimeter = double.Parse(cols[1]),
                    surfaceArea = double.Parse(cols[2]),
                    diameter = double.Parse(cols[3])
                };
                string temp = cols[4];

                //temp = "|(8 9)|(2 9)|(2 3)|(8 3)"
                string[] polygonPoints = temp.Split('|');
                for (int i = 1, n = polygonPoints.Count(); i < n; i++) //* i starts from 1 because polygonPoints[0] = ""
                {
                    //(8 9)
                    string t = polygonPoints[i];
                    string[] q = t.Split(' '); // (8 and 9)

                    p.points.Add(new PointModel(q[0].Remove(0, 1), q[1].Remove(q[1].Length - 1, 1)));
                }

                output.Add(p);
            }

            return output;
        }

        public static List<FacadeModel> ConvertToFacadeModels(this List<string> lines,string facadeFileName,  string polygonFileName)
        {
            List<FacadeModel> output = new List<FacadeModel>();
            List<PolygonModel> polygons = polygonFileName.FullFilePath().LoadFile().ConvertToPolygonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                FacadeModel f = new FacadeModel
                {
                    Id = int.Parse(cols[0]),
                    objectName = cols[1],
                    objectAddress = cols[2],
                    objectOwner = cols[3],
                    objectHeight = double.Parse(cols[4]),
                    objectWidth = double.Parse(cols[5]),
                    damageType = (DamageType)Enum.Parse(typeof(DamageType), cols[6], true)
                };
                string temp = cols[7]; //temp = "|2|4|5"

                string[] facadePolygonIds = temp.Split('|');
                for (int i = 1, n = facadePolygonIds.Count(); i < n; i++) //* i starts from 1 because polygonPoints[0] = ""
                {
                    //2
                    PolygonModel p = new PolygonModel();
                    foreach (PolygonModel pModel in polygons)
                    {
                        if (pModel.Id == Convert.ToInt32(facadePolygonIds[i]))
                        {
                            f.polygons.Add(pModel);
                        }
                    }
                }

                output.Add(f);
            }

            return output;
        }

        public static void SaveToPolygonsFile(this List<PolygonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PolygonModel polygon in models)
            {
                string listOfPoints = "";
                for (int i = 0, m = polygon.points.Count(); i < m; i++)
                {
                    listOfPoints += "|" + polygon.points[i].Coordinates;
                }

                lines.Add($"{polygon.Id},{polygon.perimeter},{polygon.surfaceArea},{polygon.diameter},{listOfPoints}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToFacadesFile(this List<FacadeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(FacadeModel facade in models)
            {
                string listOfPolygons = "";
                for (int i = 0, m = facade.polygons.Count(); i < m; i++)
                {
                    listOfPolygons += "|" + facade.polygons[i].Id;
                }

                lines.Add($"{facade.Id},{facade.objectName},{facade.objectAddress},{facade.objectOwner},{facade.objectHeight},{facade.objectWidth},{facade.damageType},{listOfPolygons}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
