using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRepairLibrary.Model;

namespace FacadeRepairLibrary.DataAccess
{
    // TODO summary
    /// <summary>
    /// 
    /// </summary>
    public interface IDataConnection
    {
        PointModel CreatePoint(PointModel pointModel);

        List<PointModel> DeletePoint(PointModel pointModel);

        List<PointModel> EditPoint(PointModel polygonModel, string xValue, string yValue);

        List<PointModel> GetPointsAll();

        PolygonModel CreatePolygon(PolygonModel polygonModel);

        FacadeModel CreateFacade(FacadeModel facadeModel);
    }
}
