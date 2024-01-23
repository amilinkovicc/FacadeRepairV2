using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRepairLibrary.Model;

namespace FacadeRepairLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public FacadeModel CreateFacade(FacadeModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Make the CreatePoint actually save to the database.
        /// <summary>
        /// Saves a new point to the database.
        /// </summary>
        /// <param name="model">The point informations.</param>
        /// <returns>The point informations, including the unique identifier.</returns>
        public PointModel CreatePoint(PointModel model)
        {
            model.Id = 1;

            return model;
        }

        // TODO - Finish CreatePolygon in SqlConnector
        public PolygonModel CreatePolygon(PolygonModel model)
        {
            throw new NotImplementedException();
        }

        public List<PointModel> DeletePoint(PointModel pointModel)
        {
            throw new NotImplementedException();
        }

        // TODO - Finish EditPoint in SqlConnector
        public List<PointModel> EditPoint(PointModel model, string xValue, string yValue)
        {
            throw new NotImplementedException();
        }

        // TODO - Finish GetPointsAll in SqlConnector
        public List<PointModel> GetPointsAll()
        {
            throw new NotImplementedException();
        }
    }
}
