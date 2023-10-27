using Microsoft.EntityFrameworkCore;
using NZwalks.Data;
using NZwalks.Model.Domains;

namespace NZwalks.Repositries
{
    public class RegionRepositries : IRegionRepositries
    {
        private readonly NZwalksDbcontext nZwalksDbcontext;

        public RegionRepositries(NZwalksDbcontext nZwalksDbcontext)
        {
            this.nZwalksDbcontext = nZwalksDbcontext;
        }
        public  IEnumerable<Regions> GetAll()

        {
            
            
               return  nZwalksDbcontext.Regions.ToList();
        }

        public Task GetAll(Guid id)
        {
            return nZwalksDbcontext.Regions.FirstOrDefault(X => X.Id == id);
        }

        public Task GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public object ToList()
        {
            throw new NotImplementedException();
        }

        void IRegionRepositries.GetAll()
        {


        }
    }



}
