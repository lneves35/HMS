using PandyIT.HMS.Data.Model.Entities;

namespace PandyIT.HMS.Business.Logic.Services
{
    public interface IUserService
    {
        User GetUserById(int userId);
    }
}