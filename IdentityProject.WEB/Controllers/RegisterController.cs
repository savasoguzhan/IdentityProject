using IdentityProject.DTO.Dtos.AppUserDtos;
using IdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.WEB.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if(ModelState.IsValid)
            {
                Random rnd = new Random();
                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegisterDto.Username,
                    Name = appUserRegisterDto.Name,
                    Email = appUserRegisterDto.Email,
                    Surname = appUserRegisterDto.Surname,
                    City = "DEneme",
                    District = "deneme",
                    ImageUrl="/deneme",
                    ConfirmCode =rnd.Next(100000, 1000000)
                };
                var result =await _userManager.CreateAsync(appUser,appUserRegisterDto.Password);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index","ConfirmMail");
                }
                
            }
            return View();
        }
    }
}
