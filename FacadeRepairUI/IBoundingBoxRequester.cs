using FacadeRepairLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRepairUI
{
    public interface IBoundingBoxRequester
    {
        void BoundingBoxComplete(PolygonModel polygonModel);
    }
}
