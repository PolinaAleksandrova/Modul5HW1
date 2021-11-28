using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5HW1.Models.OtherMethods
{
    public class UserCreateInfo
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
