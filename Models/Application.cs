using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ctrlspec.Models
{
    public class Application
    {
        [Key]
        public int  C_Id{ get; set; }
        public int AppId {get;set;}
        public string? C_Email{get;set;}
        public string? Application_Name{get;set;}
        
        public string? Serverinfo{get;set;}
        public string? Portinfo{get;set;}

         public Login login {get;set;}
    }
}

   