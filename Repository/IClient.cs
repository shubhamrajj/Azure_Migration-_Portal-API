using ctrlspec.Models;

namespace ctrlspec.Repository
{
    public interface IClient
    {
        object Login { get; }
        object Application { get; }
        object login { get; }

        Task<List<Application>> GetAll();
        Task<Application> GetByID(int Id);
        Task<Application> Add(Application application);
        Task<Application> Update(int Id, Application cardetails);
        Task Delete(int Id);
        IEnumerable<object> GetServerLists();
        IEnumerable<object> GetApplicationLists();

        Task<IEnumerable<Application>>GetClientDataByClientIdAsync(string C_Email);
        // IEnumerable<object> GetApplicationById();

    }

    
}