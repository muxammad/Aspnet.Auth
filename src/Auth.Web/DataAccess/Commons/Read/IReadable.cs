using System.Linq.Expressions;
using Auth.Web.Models;

namespace Auth.Web.DataAccess.Commons.Read;

public interface IReadable
{
    public IQueryable<User> GetAll();
    public IQueryable<User> Where(Expression<Func<User, bool>> expression);
}