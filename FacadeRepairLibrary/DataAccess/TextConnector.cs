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

        /// <summary>
        /// Saves a new point to the Text file. TODO - Incorrect (from text to model)
        /// </summary>
        /// <param name="model">The point informations.</param>
        /// <returns>The point informations, including the unique identifier.</returns>
        public PointModel CreatePoint(PointModel pointModel)
        {
            //Load the text file and Convert the text to List<PointModel>
            List<PointModel> points = PointsFile.FullFilePath().LoadFile().ConvertToPointModels();

            //Find the max ID
            int currentId = 1;

            if (points.Count > 0)
            {
                currentId = points.OrderByDescending(p => p.Id).First().Id + 1;
            }

            pointModel.Id = currentId;

            //Add the new record with the new ID (max + 1)
            points.Add(pointModel);

            //Convert the prizes to List<string>
            //Save the List<string> to the text file
            points.SaveToPointsFile(PointsFile);

            return pointModel;
        }

        /// <summary>
        /// Deletes selected point from .csv file.
        /// </summary>
        /// <param name="pointModel">Selected point - point we want to delete from list.</param>
        /// <returns>New list of PointModels. Contains all points except the deleted one.</returns>
        public List<PointModel> DeletePoint(PointModel pointModel)
        {
            List<PointModel> points = PointsFile.FullFilePath().LoadFile().ConvertToPointModels();

            for (int i = pointModel.Id, n = points.Count(); i < n; i++)
            {
                points[i - 1] = points[i];
                points[i - 1].Id -= 1;
            }
            points.RemoveAt(points.Count - 1);

            points.SaveToPointsFile(PointsFile);

            return points;
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

        public PolygonModel CreatePolygon(PolygonModel model)
        {
            List<PolygonModel> polygons = PolygonFile.FullFilePath().LoadFile().ConvertToPolygonModels(PointsFile);

            int currentId = 1;

            if (polygons.Count > 0)
            {
                currentId = polygons.OrderByDescending(p => p.Id).First().Id + 1;
            }

            model.Id = currentId;

            polygons.Add(model);

            polygons.SaveToPolygonsFile(PolygonFile);

            return model;
        }

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
            facades.SaveToFacadesFile(FacadesFile);

            return model;

        }
    }
}
