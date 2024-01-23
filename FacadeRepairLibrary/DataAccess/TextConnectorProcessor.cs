﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRepairLibrary.Model;

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

        public static List<PointModel> ConvertToPointModels(this List<string> lines)
        {
            List<PointModel> output = new List<PointModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PointModel p = new PointModel();
                p.Id = int.Parse(cols[0]);
                p.x = double.Parse(cols[1]);
                p.y = double.Parse(cols[2]);
                // TODO Add PolygonId
                output.Add(p);
            }

            return output;
        }

        public static List<PolygonModel> ConvertToPolygonModels(this List<string> lines, string pointsFileName)
        {
            List<PolygonModel> output = new List<PolygonModel> ();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                
                PolygonModel p = new PolygonModel();
                p.Id = int.Parse(cols[0]);
                //p.perimeter = double.Parse(cols[1]);
                //p.surfaceArea = double.Parse(cols[2]);
                //p.diameter = double.Parse(cols[3]);
                // TODO add FacadeId
                output.Add(p);
            }

            return output;
        }

        public static List<FacadeModel> ConvertToFacadeModels(this List<string> lines)
        {
            List<FacadeModel> output = new List<FacadeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                FacadeModel f = new FacadeModel();
                f.Id = int.Parse(cols[0]);
                f.objectName = cols[1];
                f.objectAddress = cols[2];
                f.objectOwner = cols[3];
                f.objectHeight = double.Parse(cols[4]);
                f.objectWidth = double.Parse(cols[5]);
                f.damageType = (DamageType) Enum.Parse(typeof(DamageType), cols[6], true);
                // TODO - Connect facades with polygons (foreign key)
                output.Add(f);
            }

            return output;
        }

        public static void SaveToPointsFile(this List<PointModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(PointModel p in models)
            {
                lines.Add($"{p.Id},{p.x},{p.y},{p.polygonId}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPolygonsFile(this List<PolygonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PolygonModel p in models)
            {
                lines.Add($"{p.Id},{p.perimeter},{p.surfaceArea},{p.diameter},{p.facadeId}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToFacadesFile(this List<FacadeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(FacadeModel f in models)
            {
                lines.Add($"{f.Id},{f.objectName},{f.objectAddress},{f.objectOwner},{f.objectHeight},{f.objectWidth},{f.damageType}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
