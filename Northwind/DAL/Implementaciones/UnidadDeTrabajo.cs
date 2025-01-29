using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementaciones
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public IShipperDAL ShipperDAL { get; set; }

        private NorthWndContext _northWndContext;

        public UnidadDeTrabajo(NorthWndContext northWndContext,
                       IShipperDAL shipperDAL
            
            )
        {
            this._northWndContext = northWndContext;
            this.ShipperDAL = shipperDAL;
        }
        public bool Complete()
        {
            try
            {
                _northWndContext.SaveChanges();
                return true;
            }
            catch (Exception)
            { 
                return false;
            }
        }

        public void Dispose()
        {
           this._northWndContext.Dispose();
        }
    }
}
