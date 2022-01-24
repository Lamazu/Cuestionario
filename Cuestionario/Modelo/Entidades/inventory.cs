using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class inventory
    {
        //id
        public int inventory_id { get; set; }
        public int store_id { get; set; }


        //Propiedades para la relacion con film
        public List<film> films { get; set; }
    }
}
