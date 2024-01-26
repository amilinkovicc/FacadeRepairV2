using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRepairLibrary.DataAccess.TextHelpers;
using FacadeRepairLibrary.Model;

namespace FacadeRepairLibrary.DataAccess
{
    // TODO LOOK summary
    /// <summary>
    /// Interface for XMLConnector, XLSXConnector and CSVConnector
    /// </summary>
    public interface IDataConnection
    {
        PolygonModel CreatePolygonId(PolygonModel polygonModel);

        void SavePolygon(PolygonModel polygonModel);

        PolygonModel GetPolygonById(int id);

        FacadeModel CreateFacadeId(FacadeModel facadeModel);

        void SaveFacede(FacadeModel facadeModel);

        List<FacadeModel> GetAllFacades();
    }
}
