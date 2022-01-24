using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class language
    {
        //id
        public int language_id { get; set; }
        public string nams { get; set; }


        //Propiedades para la relacion con film
        public int film_id { get; set; }
        public film film { get; set; }
    }
}
