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
        public ICustomerDAL CustomerDAL { get; set; }
        public IEmployeesDAL EmployeesDAL { get; set; }
        public IOrderDAL OrderDAL { get; set; }

        private NorthWndContext _northWndContext;

        public UnidadDeTrabajo(NorthWndContext northWndContext,
                       IShipperDAL shipperDAL,
                       ICustomerDAL customerDAL,
                       IEmployeesDAL employeesDAL,
                       IOrderDAL orderDAL
            
            )
        {
            this._northWndContext = northWndContext;
            this.ShipperDAL = shipperDAL;
            this.CustomerDAL = customerDAL;
            this.EmployeesDAL = employeesDAL;
            this.OrderDAL = orderDAL;
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
