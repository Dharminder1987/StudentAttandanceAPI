using StudentAttandance.Data.Entity;
using StudentAttandance.RequestResponse.User;

namespace StudentAttandance.Data
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
