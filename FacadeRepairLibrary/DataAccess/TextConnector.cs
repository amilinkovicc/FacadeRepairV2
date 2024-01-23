using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRepairLibrary.Model;
using FacadeRepairLibrary.DataAccess.TextHelpers;
using System.Reflection;

namespace FacadeRepairLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PointsFile = "PointModels.csv";
        private const string PolygonFile = "PolygonModels.csv";
        private const string FacadesFile = "FacadeModels.csv";

        public FacadeModel CreateFacade(FacadeModel model)
        {
            //Load the text file and Convert the text to List<FacadeModel>
            List<FacadeModel> facades = FacadesFile.FullFilePath().LoadFile().ConvertToFacadeModels();

            //Find the max ID
            int currentId = 1;

            if (facades.Count > 0)
            {
                currentId = facades.OrderByDescending(p => p.Id).First().Id + 1;
            }

            model.Id = currentId;

            //Add the new record with the new ID (max + 1)
            facades.Add(model);

            //Convert the facades to List<string>
            //Save the List<string> to the text file
            facades.SaveToFacadesFile(PointsFile);

            return model;

        }

        // TODO - Make the CreatePoint actually save to the txt file.
        /// <summary>
        /// Saves a new point to the Text file.
        /// </summary>
        /// <param name="model">The point informations.</param>
        /// <returns>The point informations, including the unique identifier.</returns>
        public PointModel CreatePoint(PointModel model)
        {
            //Load the text file and Convert the text to List<PointModel>
            List<PointModel> points = PointsFile.FullFilePath().LoadFile().ConvertToPointModels();

            //Find the max ID
            int currentId = 1;

            if (points.Count > 0)
            {
                currentId = points.OrderByDescending(p => p.Id).First().Id + 1;
            }

            model.Id = currentId;

            //Add the new record with the new ID (max + 1)
            points.Add(model);

            //Convert the prizes to List<string>
            //Save the List<string> to the text file
            points.SaveToPointsFile(PointsFile);

            return model;
        }

        public PolygonModel CreatePolygon(PolygonModel model)
        {
            List<PolygonModel> polygons = PolygonFile.FullFilePath().LoadFile().ConvertToPolygonModels(PointsFile);
        }

        public List<PointModel> EditPoint(PointModel model, string xValue, string yValue)
        {
            List<PointModel> points = PointsFile.FullFilePath().LoadFile().ConvertToPointModels();

            foreach (PointModel point in points) 
            {
                if (point.Id == model.Id)
                {
                    point.x = double.Parse(xValue);
                    point.y = double.Parse(yValue);
                }
            }

            points.SaveToPointsFile(PointsFile);

            return points;
        }

        public List<PointModel> GetPointsAll()
        {
            return PointsFile.FullFilePath().LoadFile().ConvertToPointModels();
        }
    }
}
