using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal.Aereo
{
    public abstract class Aereo
    {
        public Areo(string color, string marca){
            Color = color;
            Marca = marca;

     }
        public string Color { get; set; }
        public string Marca { get; set; }
    }
}
