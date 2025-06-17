using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Location
    {
        public int Id {  get; set; }
        public string Continente {  get; set; }
        public string Pais {  get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
    }
}
