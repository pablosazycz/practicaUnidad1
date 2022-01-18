using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    internal class Comments
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string Comment { get; set; }
        //relacion
        public string User { get; set; }
        
    }
}
