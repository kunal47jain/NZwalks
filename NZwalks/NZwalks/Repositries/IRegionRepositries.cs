using NZwalks.Model.Domains;

namespace NZwalks.Repositries
{
    public interface IRegionRepositrie
    {
      Task <IEnumerable<Regions>>GetAll();

    }
}
