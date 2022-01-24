using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class film
    {
        //id
        public int film_id { get; set; }
        public int title { get; set; }
        public string description { get; set; }
        public DateTime release_year { get; set; }
        public DateTime rental_duration { get; set; }
        public int rental_rate { get; set; }
        public int lenght { get; set; }
        public int replacement_cost { get; set; }
        public int ratinng { get; set; }
        public DateTime last_update { get; set; }
        public string special_features { get; set; }
        public string fulltext { get; set; }


        //Propiedades para la relacion con inventory
        public int inventory_id { get; set; }
        public inventory inventory { get; set; }


        //Propiedades para la relacion con language
        public List<language> languages { get; set; }
    }
}
