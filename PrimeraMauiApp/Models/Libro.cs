using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraMauiApp.Models
{
    public class Libro
    {
        public string _id { get; set; }
        public string nombre { get; set; }
        public string autor { get; set; }
        public string editorial { get; set; }
        public string portada_url;

        public string Portada_url
        {
            get { return portada_url==""?"dotnet_bot.png":portada_url; }
            set { portada_url = value; }
        }

        public string sinopsis { get; set; }
        public int paginas { get; set; }
        public string genero { get; set; }

        public override string ToString()
        {
            return $"{nombre} - {editorial} - {genero}";
        }
    }
}
