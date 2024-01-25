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
        // TODO - Finish CreatePolygon in SqlConnector
        public PolygonModel CreatePolygon(PolygonModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Finish CreateFacade in SqlConnector
        public FacadeModel CreateFacade(FacadeModel model)
        {
            throw new NotImplementedException();
        }

        public PolygonModel CreatePolygonId(PolygonModel polygonModel)
        {
            throw new NotImplementedException();
        }

        public void SavePolygon(PolygonModel polygonModel)
        {
            throw new NotImplementedException();
        }
    }
}
