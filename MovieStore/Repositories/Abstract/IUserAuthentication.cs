using MovieStore.Models.DTO;

namespace MovieStore.Repositories.Abstract
{
    public interface IUserAuthentication
    {  
        Task<Status> LoginAsync(Login model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(Registration model);
    }
}
