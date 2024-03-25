using ICI.ProvaCandidato.Negocio.Models.Noticias.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Models.Noticias
{
    public class Noticiia : BaseModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        //public int UsuarioId { get; set; } 

        public string Tag { get; set; } 
    }
}
