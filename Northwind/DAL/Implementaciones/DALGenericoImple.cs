using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementaciones
{
    public class DALGenericoImple<TEntity> : IDALGenerico<TEntity> where TEntity : class
    {
        private NorthWndContext _northWndContext;

        public DALGenericoImple(NorthWndContext northWndContext)
        {
            _northWndContext = northWndContext;
        }
        public bool Add(TEntity entity)
        {
            try
            {
                _northWndContext.Add(entity);
                return true;
            }
            catch (Exception)
            { 
                return false;

            }
                
        }

        public TEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
