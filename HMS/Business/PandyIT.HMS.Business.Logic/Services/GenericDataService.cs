using System.Collections.Generic;
using PandyIT.HMS.Data.Model.Entities;

namespace PandyIT.HMS.Business.Logic.Services
{
    public class GenericDataService : BaseService, IGenericDataService
    {
        public GenericDataService(IBusinessContext businessContext) : base(businessContext) { }

        public IEnumerable<UserType> GetUserTypes()
        {
            return BusinessContext.GetEntities<UserType>();
        } 
    }
}
