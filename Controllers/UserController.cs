using System.Security.Cryptography;
using ctrlspec.DTO;
using ctrlspec.Helpers;
using ctrlspec.Models;
using ctrlspec.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using ctrlspec.UtilityService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ctrlspec.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using ctrlspec.Repos;
using ctrlspec.Repository.ILogin;

namespace ctrlspec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        //     private readonly ILogger<UserController> _logger;

        //     public UserController(ILogger<UserController> logger)
        //     {
        //         _logger = logger;
        //     }

        //     public IActionResult Index()
        //     {
        //         return View();
        //     }

        //     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //     public IActionResult Error()
        //     {
        //         return View("Error!");
        //     }

        private readonly CtrlSpecDbContext _context;
        private readonly ILogin _login;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        private readonly ClientRepository _client;
        public string? EmailId { get; private set; }

        public UserController(CtrlSpecDbContext context,ILogin login, ClientRepository client ,IEmailService emailService,IConfiguration configuration )
        {
            _login = login;
            _context = context;
            _client= client;
            _emailService =emailService;
            _configuration=configuration;
        }

      


        [HttpGet("{Id}")]
        public async Task<ActionResult<Login>> GetByID(int Id)
        {
            var login = await _login.GetByID(Id);
            if (login == null)
            {
                return NotFound();
            }
            return Ok(login);
        }
        // [HttpPost("refresh")]
        // public async Task<IActionResult> Refresh ([FromBody]TokenApiDto tokenApiDto)
        // {
            
        // }


        [HttpPost("send-reset-email/{email}")]
        public async Task<IActionResult> SendEmail(string email)
        {
            var user = await _context.login.FirstOrDefaultAsync(a => a.EmailId == email);
            if (user is null)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = "Email doesn't exist"
                });
            }

            var tokenBytes = RandomNumberGenerator.GetBytes(64);
            var emailToken = Convert.ToBase64String(tokenBytes);
            user.ResetPasswordToken = emailToken;
            user.ResetPasswordExpiry = DateTime.Now.AddMinutes(15);
            string from = _configuration["EmailSettings:From"];
            var emailModel = new EmailModel(email, "Reset Password!!", EmailBody.EmailStringBody(email, emailToken));
            _emailService.SendEmail(emailModel);

            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(new
            {
                StatusCode = 200,
                Message = "Email sent!"
            });
        }
        // private string CreateJWT(Login user)
        // {
        //     var jwtTokenHandler = new JwtSecurityTokenHandler();
        //     var key =Encoding.ASCII.GetBytes("veryverysecret....");
            
        // }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordDTO resetPasswordDTO)
        {
            var newToken = resetPasswordDTO.EmailToken.Replace(" ", "+");
            var user = await _context.login.AsNoTracking().FirstOrDefaultAsync(a => a.EmailId == resetPasswordDTO.EmailId);

            if (user is null)
            {
                return NotFound(new 
                {
                    StatusCode = 404,
                    Message = "User doesn't exist"
                });
            }

            var tokenCode = user.ResetPasswordToken;
            DateTime emailTokenExpiry = user.ResetPasswordExpiry;
            if (tokenCode != resetPasswordDTO.EmailToken || emailTokenExpiry < DateTime.Now)
            {
                return BadRequest(new
                {
                    StatusCode = 400,
                    Message = "Invalid Reset Link"
                });
            }
            // _context.Entry(user).State=EntityState.Modified;
            // await _context.SaveChangesAsync();

            IPasswordHasher<Login> passwordHasher = new PasswordHasher<Login>();
            string hashedPassword = passwordHasher.HashPassword(user, resetPasswordDTO.NewPassword);

            // var hasher = new PasswordHasher<string>();
            // user.PasswordHasher = hasher.HashPassword(user, resetPasswordDTO.NewPassword);
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(new
            {
                StatusCode = 200,
                Message = "Password Reset successfully"
            });
        }

        // You should define your actual user type here
        public class YourUserType
        {
            // Define properties for your user
        }
    }
}