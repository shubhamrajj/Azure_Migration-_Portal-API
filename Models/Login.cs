using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ctrlspec.Models
{
    public class Login
    {
        [Key]
        public int LoginId{get;set;}
        public string? Name{get;set;}

        public string? EmailId{get;set;}

        public string? Password{get;set;}
         public string? Role{get;set;}
        public string? ResetPasswordToken{get;set;}
        public string? PasswordHasher{get;set;}

         public DateTime ResetPasswordExpiry{get;set;}
        public string? RefreshToken{get;set;}
        public DateTime RefreshTokenExpiryTime{get;set;}
        public Application? Application { get; set;}

    }
}