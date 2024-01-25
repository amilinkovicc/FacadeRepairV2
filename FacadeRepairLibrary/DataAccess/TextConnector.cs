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
        private const string PolygonFile = "PolygonModels.csv";
        private const string FacadeFile = "FacadeModels.csv";
        private PolygonModel chosenPolygon;

        // TODO - write summaries

        /// <summary>
        /// Saves a new point to the Text file. TODO - Incorrect (from text to model)
        /// </summary>
        /// <param name="model">The point informations.</param>
        /// <returns>The point informations, including the unique identifier.</returns>
        //public PointModel CreatePoint(PointModel pointModel)
        //{
        //    //Load the text file and Convert the text to List<PointModel>
        //    List<PointModel> points = PointsFile.FullFilePath().LoadFile().ConvertToPointModels();

        //    //Find the max ID
        //    int currentId = 1;

        //    if (points.Count > 0)
        //    {
        //        currentId = points.OrderByDescending(p => p.Id).First().Id + 1;
        //    }

        //    pointModel.Id = currentId;

        //    //Add the new record with the new ID (max + 1)
        //    points.Add(pointModel);

        //    //Convert the prizes to List<string>
        //    //Save the List<string> to the text file
        //    points.SaveToPointsFile(PointsFile);

        //    return pointModel;
        //}

        /// <summary>
        /// Deletes selected point from .csv file.
        /// </summary>
        /// <param name="pointModel">Selected point - point we want to delete from list.</param>
        /// <returns>New list of PointModels. Contains all points except the deleted one.</returns>
        //public List<PointModel> DeletePoint(PointModel pointModel)
        //{
        //    List<PointModel> points = PointsFile.FullFilePath().LoadFile().ConvertToPointModels();

        //    for (int i = pointModel.Id, n = points.Count(); i < n; i++)
        //    {
        //        points[i - 1] = points[i];
        //        points[i - 1].Id -= 1;
        //    }
        //    points.RemoveAt(points.Count - 1);

        //    points.SaveToPointsFile(PointsFile);

        //    return points;
        //}

        /// <summary>
        /// Edits selected point from .csv file.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="xValue"></param>
        /// <param name="yValue"></param>
        /// <returns></returns>
        //public List<PointModel> EditPoint(PointModel model, string xValue, string yValue)
        //{
        //    List<PointModel> points = PointsFile.FullFilePath().LoadFile().ConvertToPointModels();

        //    foreach (PointModel point in points)
        //    {
        //        if (point.Id == model.Id)
        //        {
        //            point.x = double.Parse(xValue);
        //            point.y = double.Parse(yValue);
        //        }
        //    }

        //    points.SaveToPointsFile(PointsFile);

        //    return points;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //public List<PointModel> GetPointsAll()
        //{
        //    return PointsFile.FullFilePath().LoadFile().ConvertToPointModels();
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PolygonModel CreatePolygonId(PolygonModel polygonModel)
        {
            List<PolygonModel> polygons = PolygonFile.FullFilePath().LoadFile().ConvertToPolygonModels(PolygonFile);

            int currentId = 1;

            if (polygons.Count > 0)
            {
                currentId = polygons.OrderByDescending(p => p.Id).First().Id + 1;
            }

            polygonModel.Id = currentId;


            return polygonModel;
        }

        public void SavePolygon(PolygonModel polygonModel)
        {
            List<PolygonModel> polygons = PolygonFile.FullFilePath().LoadFile().ConvertToPolygonModels(PolygonFile);

            polygons.Add(polygonModel);

            polygons.SaveToPolygonsFile(PolygonFile);
        }

        public PolygonModel GetPolygonById(int id)
        {
            List<PolygonModel> polygons = PolygonFile.FullFilePath().LoadFile().ConvertToPolygonModels(PolygonFile);
            PolygonModel chosenPolygon = new PolygonModel();

            foreach (PolygonModel polygon in polygons)
            {
                if (id == polygon.Id)
                {
                    chosenPolygon = polygon;
                }
            }

            return chosenPolygon;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public FacadeModel CreateFacadeId(FacadeModel facadeModel)
        {
            //Load the text file and Convert the text to List<FacadeModel>
            List<FacadeModel> facades = FacadeFile.FullFilePath().LoadFile().ConvertToFacadeModels(FacadeFile);

            //Find the max ID
            int currentId = 1;

            if (facades.Count > 0)
            {
                currentId = facades.OrderByDescending(p => p.Id).First().Id + 1;
            }

            facadeModel.Id = currentId;

            return facadeModel;
        }
 
        public void SaveFacede(FacadeModel facadeModel)
        {
            List<FacadeModel> facades = FacadeFile.FullFilePath().LoadFile().ConvertToFacadeModels(FacadeFile);

            facades.Add(facadeModel);

            facades.SaveToFacadesFile(FacadeFile);
        }
    }
}
