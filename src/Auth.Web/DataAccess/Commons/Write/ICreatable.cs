using Auth.Web.Models;

namespace Auth.Web.DataAccess.Commons.Write;

public interface ICreatable
{
    public bool Creat(User user);
}