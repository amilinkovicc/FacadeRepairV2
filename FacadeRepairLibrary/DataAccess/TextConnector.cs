using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRepairLibrary.Model;
using FacadeRepairLibrary.DataAccess.TextHelpers;
using System.Reflection;
using System.Data.OleDb;

namespace FacadeRepairLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PolygonFile = "PolygonModels.csv";
        private const string FacadeFile = "FacadeModels.csv";

        /// <summary>
        /// Updates Id value in the polygon properties.
        /// </summary>
        /// <param name="polygonModel">The polygon informations.This polygon doesn't have the (correct) Id value.</param>
        /// <returns>The polygon informations, including the unique identifier (Id).</returns>
        public PolygonModel CreatePolygonId(PolygonModel polygonModel)
        {
            List<PolygonModel> polygons = PolygonFile.FullFilePath().LoadFile().ConvertToPolygonModels();

            int currentId = 1;

            if (polygons.Count > 0)
            {
                currentId = polygons.OrderByDescending(p => p.Id).First().Id + 1;
            }

            polygonModel.Id = currentId;


            return polygonModel;
        }

        /// <summary>
        /// Saves new polygon to a correct PolygonFile. If it's just edited polygon that was already in the PolygonFile this method will just substitute old one with the new (edited) one.
        /// </summary>
        /// <param name="polygonModel">New or edited polygon.</param>
        public void SavePolygon(PolygonModel polygonModel)
        {
            List<PolygonModel> polygons = PolygonFile.FullFilePath().LoadFile().ConvertToPolygonModels();

            bool oldPolygon = false;
            for (int i = 0, n = polygons.Count; i < n; i++)
            {
                if (polygons[i].Id == polygonModel.Id)
                {
                    polygons[i] = polygonModel;
                    oldPolygon = true;
                }
            }

            if (!oldPolygon)
            {
                polygons.Add(polygonModel); 
            }

            polygons.SaveToPolygonsFile(PolygonFile);
        }

        /// <summary>
        /// Searches for polygons in the PolygonFile by polygon.Id.
        /// </summary>
        /// <param name="id">Id of the polygon we want to find</param>
        /// <returns>Requested polygon.</returns>
        public PolygonModel GetPolygonById(int id)
        {
            List<PolygonModel> polygons = PolygonFile.FullFilePath().LoadFile().ConvertToPolygonModels();
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
        /// Updates Id value in the facade properties.
        /// </summary>
        /// <param name="facadeModel">The facade informations.This facade doesn't have the (correct) Id value.</param>
        /// <returns>The facade informations, including the unique identifier (Id).</returns>
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

        /// <summary>
        /// Saves new facade to a correct FacadeFile. If it's just edited facade that was already in the FacadeFile this method will just substitute old one with the new (edited) one.
        /// </summary>
        /// <param name="facadeModel">New or edited facade.</param>
        public void SaveFacede(FacadeModel facadeModel)
        {
            List<FacadeModel> facades = FacadeFile.FullFilePath().LoadFile().ConvertToFacadeModels(FacadeFile);

            bool oldFacade = false;
            for (int i = 0, n = facades.Count; i < n; i++)
            {
                if (facades[i].Id == facadeModel.Id)
                {
                    facades[i] = facadeModel;
                    oldFacade = true;
                }
            }

            if (!oldFacade)
            {
                facades.Add(facadeModel);
            }

            facades.SaveToFacadesFile(FacadeFile);
        }

        public List<FacadeModel> GetAllFacades()
        {
            // Get content of FacadeModels.csv file and make facadeModels out of it
            List<FacadeModel> facades = FacadeFile.FullFilePath().LoadFile().ConvertToFacadeModels(PolygonFile);
            
            // Return List<FacadeModel>
            return facades;
        }
    }
}
