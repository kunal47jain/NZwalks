namespace NZwalks.Repositries
{
    public interface IRegionRepositries
    {
        void GetAll();
        Task GetAllAsync();
        object ToList();
    }
}