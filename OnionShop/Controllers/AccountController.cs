using Microsoft.AspNetCore.Mvc;
using OnionShop.DataLayer.DTOs.Account;

namespace OnionShop.Controllers;

public class AccountController : BaseSiteController
{
    #region Register

    [HttpGet("register")]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost("register"), AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Register(RegisterUserDTO register)
    {
        return View();
    }
    #endregion


}
