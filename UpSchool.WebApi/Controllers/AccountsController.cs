using Microsoft.AspNetCore.Mvc;
using UpSchool.Domain.Dtos;
using UpSchool.Domain.Entities;
using UpSchool.Domain.Utilities;

namespace UpSchool.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : Controller
    {
        private static List<Account> _accounts = new()
        {
            new Account()
            {
                Id = Guid.NewGuid(),
                UserName = "mspickle",
                Password = StringHelper.Base64Encode("123fullspeed123"),
                IsFavourite = false,
                CreatedOn = DateTimeOffset.Now,
                Title = "UpSchool",
                Url = "https://www.upschool.com",
            },

            new Account()
            {
                Id = Guid.NewGuid(),
                UserName = "aybisbebisi",
                Password = StringHelper.Base64Encode("aybiskobebisko"),
                IsFavourite = true,
                CreatedOn = DateTimeOffset.Now,
                Title = "Aybis",
                Url = "https://www.sinemalar.com",
            },

            new Account()
            {
                Id = Guid.NewGuid(),
                UserName = "fullspeed@gmail.com",
                Password = StringHelper.Base64Encode("123fullspeed123"),
                IsFavourite = true,
                CreatedOn = DateTimeOffset.Now,
                Title = "Gmail",
                Url = "https://www.google.com/intl/tr/gmail/about/",
            }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            var accountDtos = _accounts.Select(account => AccountDto.MapFromAccount(account));
            return Ok(accountDtos);
        }
    }
}
