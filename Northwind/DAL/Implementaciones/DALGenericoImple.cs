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
            return _northWndContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _northWndContext.Set<TEntity>().ToList(); 
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                _northWndContext.Set<TEntity>().Attach(entity);
                _northWndContext.Set<TEntity>().Remove(entity);
                return true;
            }
            catch (Exception) 
            {
                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
