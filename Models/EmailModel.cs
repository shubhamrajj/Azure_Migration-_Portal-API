using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ctrlspec.Models
{
    public class EmailModel
    {
        [Key]
         public string To {get;set;}
         public string Subject {get;set;}
        public string Content {get;set;}
        public EmailModel(string to, string subject,string content)
        {
            To = to;
            Subject= subject;
            Content= content;
        }
    }
}