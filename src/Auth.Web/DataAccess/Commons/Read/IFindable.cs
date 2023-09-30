using System.Linq.Expressions;
using Auth.Web.Models;

namespace Auth.Web.DataAccess.Commons.Read;

public interface IFindable
{
    public Task<User> FindByIdAsync(int id);
    public Task<User> FirstOrDefault(Expression<Func<User, bool>> predicate);
}