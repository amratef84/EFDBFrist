using EFDBFrist.DataAccess;
using EFDBFrist.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFrist
{
    public class Repository<IModel> : IRepository<IModel> where IModel : class
    {
        SezureSystemDB44Context Context = null;

        public Repository()
        {
            Context = new SezureSystemDB44Context();
        }
        private DbSet<IModel> EntitySet
        {
            get { return Context.Set<IModel>(); }
        }

        public int AddAll(List<IModel> reg)
        {
            try
            {
                int counter = 0;
                foreach (var item in reg)
                {
                    Context.Add<IModel>(item);
                    counter++;
                }
                Context.SaveChanges();
                return counter;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw;
            }
        }

        public IModel Create(IModel reg)
        {
            try
            {
                Context.Add<IModel>(reg);
                Context.SaveChanges();
                return reg;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw;
            }

        }

        public IModel CreateOrUpdate(IModel reg)
        {
            IModel Result = null;
            try
            {
                if (reg == null)
                    throw new ArgumentNullException("entity");

                var entry = Context.Entry<IModel>(reg);

                switch (entry.State)
                {
                    case EntityState.Modified:
                        Context.Update<IModel>(reg);
                        break;
                    case EntityState.Added:

                        Context.Add<IModel>(reg);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Context.SaveChanges();

                Result = reg;
                return Result;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public bool Delete(IModel reg)
        {
            try
            {
                Context.Remove<IModel>(reg);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(Expression<Func<IModel, bool>> exp)
        {
            bool Result = false;
            try
            {
                var entities = Context.Set<IModel>().Where(exp).ToList();

                #region DeleteByForEach

                //foreach (var item in entities)
                //{
                //    Context.Remove<IModel>(item);
                //}

                #endregion
                
                entities.ForEach(x => Context.Entry(x).State = EntityState.Deleted);

                return Result = Context.SaveChanges() > 0;
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine(exception.Message);
                return false;
            }
        }
        public bool Update(IModel reg)
        {
            try
            {
                Context.Update<IModel>(reg);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return false;
            }
        }

        public Task<List<IModel>> ListDataAsync()
        {
            try
            {
                var data = Context.Set<IModel>().ToListAsync();

                return data;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw;
            }
        }
        public List<IModel> ListData()
        {
            try
            {
                var data = Context.Set<IModel>().ToList();

                return data;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw;
            }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IModel Find(Expression<Func<IModel, bool>> exp, bool isEager = false)
        {
            throw new NotImplementedException();
        }

        public IModel Find(Expression<Func<IModel, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public IModel Find(Expression<Func<IModel, bool>> exp, List<Expression<Func<IModel, object>>> listexp)
        {
            throw new NotImplementedException();
        }


        public List<IModel> ListTo(Expression<Func<IModel, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public List<IModel> ListTo(Expression<Func<IModel, bool>> exp, List<Expression<Func<IModel, object>>> listexp)
        {
            throw new NotImplementedException();
        }

        public bool TryUpdateManyToMany<TKey>(IEnumerable<IModel> currentItems, IEnumerable<IModel> newItems, Func<IModel, TKey> getKey)
        {
            try
            {
               // Context.TryUpdateManyToMany(currentItems, newItems, getKey);
                Context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

    }
}
