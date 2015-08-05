namespace PandyIT.HMS.Business.Logic.Services
{
    public abstract class BaseService
    {
        public IBusinessContext BusinessContext { get; set; }

        protected BaseService(IBusinessContext businessContext)
        {
            BusinessContext = businessContext;
        }
    }
}
