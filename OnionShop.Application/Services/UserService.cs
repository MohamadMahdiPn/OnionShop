using OnionShop.Application.Services.interfaces;
using OnionShop.DataLayer.Entities.Account;
using OnionShop.DataLayer.Repository.interfaces;

namespace OnionShop.Application.Services;

public class UserService : IUserService
{
    #region Constructor

    private readonly IGenericRepository<ApplicationUser> _genericRepository;

    public UserService(IGenericRepository<ApplicationUser> genericRepository)
    {
        _genericRepository = genericRepository;
    }

    #endregion



    #region Dispose

     public void Dispose()
     {
         _genericRepository.DisposeAsync();
     }

    #endregion
   
}