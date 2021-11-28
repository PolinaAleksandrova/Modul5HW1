using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5HW1.Models.MethodGet
{
    public class ListData<T>
    {
        public T[] Data { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }
        public int Total { get; set; }
        public int TotalPages { get; set; }
        public Support Support { get; set; }
    }
}
