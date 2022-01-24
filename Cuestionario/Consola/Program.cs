using Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace Consola   
{
    class Program
    {
        static void Main(string[] args)
        {
            language español = new language()
            {
                nams = "Spanish",
                films = new List<film>() { new film() { } }
            };

            language ingles = new language()
            {
                nams = "English",
                films = new List<film>() { new film() { } }
            };

            language aleman = new language()
            {
                nams = "Germany",
                films = new List<film>() { new film() { } }
            };
        }
    }
}
