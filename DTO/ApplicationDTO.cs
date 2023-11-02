using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctrlspec.DTO
{
    public class ApplicationDTO
    {
        public string? C_Id { get; set; }
        public int AppId { get; set; }
        public string? C_Email { get; set; }
        public string? Application_Name { get; set; }

        public string? Serverinfo { get; set; }
        public string? Portinfo { get; set; }
    }
}