using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFrist.DataAccess
{
    public interface IRepository<IModel> : IDisposable where IModel : class
    {
        IModel Create(IModel reg);
        IModel CreateOrUpdate(IModel reg);
        int AddAll(List<IModel> reg);
        bool Update(IModel reg);
        bool Delete(IModel reg);
        bool Delete(Expression<Func<IModel, bool>> exp);
        IModel Find(Expression<Func<IModel, bool>> exp, bool isEager = false);
        IModel Find(Expression<Func<IModel, bool>> exp);
        IModel Find(Expression<Func<IModel, bool>> exp, List<Expression<Func<IModel, object>>> listexp);
        List<IModel> ListTo(Expression<Func<IModel, bool>> exp);
        List<IModel> ListTo(Expression<Func<IModel, bool>> exp, List<Expression<Func<IModel, object>>> listexp);
        Task<List<IModel>> ListDataAsync();
        bool TryUpdateManyToMany<TKey>(IEnumerable<IModel> currentItems, IEnumerable<IModel> newItems, Func<IModel, TKey> getKey);
    }
}
