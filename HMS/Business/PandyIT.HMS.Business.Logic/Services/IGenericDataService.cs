using System.Collections.Generic;
using PandyIT.HMS.Data.Model.Entities;

namespace PandyIT.HMS.Business.Logic.Services
{
    public interface IGenericDataService
    {
        IEnumerable<UserType> GetUserTypes();
    }
}