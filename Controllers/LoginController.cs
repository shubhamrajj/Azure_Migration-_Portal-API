
using System.Security.Cryptography;
using ctrlspec.Data;
using ctrlspec.DTO;
using ctrlspec.Helpers;
using ctrlspec.Models;
using ctrlspec.Repos;
using ctrlspec.Repository;
using ctrlspec.Repository.ILogin;
using ctrlspec.UtilityService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ctrlspec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[AllowAnonymous]
    public class LoginController : ControllerBase
    {
        private readonly ILogin _Login;
        private readonly ITokenHandler handler;

        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        private readonly ClientRepository _client;
        private readonly CtrlSpecDbContext _context;


        public string? EmailId { get; private set; }

        public LoginController(CtrlSpecDbContext _context, ILogin _Login, ITokenHandler handler,ClientRepository client ,IEmailService emailService,IConfiguration configuration)
        {

            this._Login = _Login;
            this.handler = handler;
             _client= client;
            _emailService =emailService;
            _configuration=configuration;
            
        }
        [HttpPost]
        [Route("SignUp")]
        public async Task<ActionResult<LoginRepository>> SignUp(Login loginTable)

        {
            var add = await _Login.SignUp(loginTable);

            if (loginTable == null)
            {
                return Ok("Bad request");
            }

            return Ok("Success");
        }

        /*  [HttpPost]
          [Route("LoginAsync")]
          public async Task<IActionResult> LoginAsync(LoginDTO LoginDTO)
          {
              try
              {
                  if 
                  (LoginDTO.EmailId == null && LoginDTO.Password == null )
                  {
                      return NotFound("EmailId or password is null");

                  }
                  //we check if user is authenticated which is check the username and password is present 
                  // in our database.
                  var user = await _Login.Login(LoginDTO.EmailId, LoginDTO.Password);
                  if (user != null)
                  {
                      var token = handler.CreateTokenAsync(user);
                      return Ok(token);
                  }


                    return BadRequest("Emailid or password is incorrect ");


              }

                      //generate jwt token


               catch (Exception e)
               {
                   return BadRequest("Error in Controller method LoginAsync"+ e);
               }

      }*/

        [HttpPost]
        [Route("LoginAsync")]
        public async Task<IActionResult> LoginAsync(LoginDTO LoginDTO)
        {
            try
            {
                if
                (LoginDTO.EmailId == null && LoginDTO.Password == null && LoginDTO.Role == null)
                {
                    return NotFound("EmailId or password is null");

                }
                //we check if user is authenticated which is check the username and password is present 
                // in our database.
                var user = await _Login.Login(LoginDTO.EmailId, LoginDTO.Password, LoginDTO.Role);
                if (user != null)
                {
                    var token = handler.CreateTokenAsync(user);
                    return Ok(token);
                }

                return BadRequest("Emailid or password or Role is incorrect ");


            }

            //generate jwt token


            catch (Exception e)
            {
                return BadRequest("Error in Controller method LoginAsync" + e);
            }


        }
//         [HttpPost("send-reset-email/{email}")]
        
//         public async Task<IActionResult> SendEmail(string email)
        
//         {
//             var user = await _context.login.FirstOrDefaultAsync(a => a.EmailId == email);
//             if (user == null)
//             {
//                 return NotFound(new
//                 {
//                     StatusCode = 404,
//                     Message = "Email doesn't exist"
//                 });
//             }

//             var tokenBytes = RandomNumberGenerator.GetBytes(64);
//             var emailToken = Convert.ToBase64String(tokenBytes);
//             user.ResetPasswordToken = emailToken;
//             user.ResetPasswordExpiry = DateTime.Now.AddMinutes(15);
//             string from = _configuration["EmailSettings:From"];
//             var emailModel = new EmailModel(email, "Reset Password!!", EmailBody.EmailStringBody(email, emailToken));
//             _emailService.SendEmail(emailModel);

//             _context.Entry(user).State = EntityState.Modified;
//             await _context.SaveChangesAsync();

//             return Ok(new
//             {
//                 StatusCode = 200,
//                 Message = "Email sent!"
//             });
//         }
//         // private string CreateJWT(Login user)
//         // {
//         //     var jwtTokenHandler = new JwtSecurityTokenHandler();
//         //     var key =Encoding.ASCII.GetBytes("veryverysecret....");
            
//         // }

//         [HttpPost("reset-password")]
//         public async Task<IActionResult> ResetPassword(ResetPasswordDTO resetPasswordDTO)
//         {
//             var newToken = resetPasswordDTO.EmailToken.Replace(" ", "+");
//             var user = await _context.login.AsNoTracking().FirstOrDefaultAsync(a => a.EmailId == resetPasswordDTO.EmailId);

//             if (user is null)
//             {
//                 return NotFound(new
//                 {
//                     StatusCode = 404,
//                     Message = "User doesn't exist"
//                 });
//             }

//             var tokenCode = user.ResetPasswordToken;
//             DateTime emailTokenExpiry = user.ResetPasswordExpiry;
//             if (tokenCode != resetPasswordDTO.EmailToken || emailTokenExpiry < DateTime.Now)
//             {
//                 return BadRequest(new
//                 {
//                     StatusCode = 400,
//                     Message = "Invalid Reset Link"
//                 });
//             }
//             // _context.Entry(user).State=EntityState.Modified;
//             // await _context.SaveChangesAsync();

//             IPasswordHasher<Login> passwordHasher = new PasswordHasher<Login>();
//             string hashedPassword = passwordHasher.HashPassword(user, resetPasswordDTO.NewPassword);

//             // var hasher = new PasswordHasher<string>();
//             // user.PasswordHasher = hasher.HashPassword(user, resetPasswordDTO.NewPassword);
//             _context.Entry(user).State = EntityState.Modified;
//             await _context.SaveChangesAsync();

//             return Ok(new
//             {
//                 StatusCode = 200,
//                 Message = "Password Reset successfully"
//             });
//         }

//         // You should define your actual user type here
//         public class YourUserType
//         {
//             // Define properties for your user
//         }
//     }
// }
    }
}











