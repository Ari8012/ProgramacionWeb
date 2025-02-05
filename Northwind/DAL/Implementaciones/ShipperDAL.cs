using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog.Core;

namespace DAL.Implementaciones
{
    public class ShipperDAL : DALGenericoImple<Shipper>,  IShipperDAL
    {
        private NorthWndContext _context;

        public ShipperDAL(NorthWndContext context): base(context) 
        {
            _context = context;
        }


       public List<Shipper> GetAllShippers()
        {
            string query = "sp_GetAllShippers";
            var result = _context.Shippers.FromSqlRaw(query);

            return result.ToList();
        }

        public bool Add(Shipper entity)
        {
            try
            {
                string sql = "exec [dbo].[sp_AddShipper] @CompanyName";
                var param = new SqlParameter[]
                {
                    new SqlParameter()
                    {
                        ParameterName = "@CompanyName",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = entity.CompanyName
                    }
                };

                _context.Database.ExecuteSqlRaw(sql, param);
                return true;
            }
            catch (Exception e)
            {
                
                return false;
            }
        }
    }
}
