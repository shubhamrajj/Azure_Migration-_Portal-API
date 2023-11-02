using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;

namespace ctrlspec.Repository.ILogin
{
    public interface ILogin
    {
        object login { get; }

        Task<Login> SignUp(Login loginTable);
        Task<Login> Login(string emailId, string Password, string Role);

         Task<List<Login>> GetAll();
        Task<Login> GetByID(int Id);
       Task<IEnumerable<Login>> GetbyroleAsync(string role);

         Task Delete(int loginId);
        object Entry(object user);
        Task SaveChangesAsync();
        // Task GetByEmail(string email);
        //  Task send-reset-email()
        //  Task SendEmail(string email);



    }
}