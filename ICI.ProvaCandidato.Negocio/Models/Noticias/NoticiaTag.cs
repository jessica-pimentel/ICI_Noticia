using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Models.Noticias
{
    public class NoticiaTag : BaseModel
    {
        public int Id { get; set; }
        public int NoticiaId { get; set; }
        public int TagId { get; set; }
    }
}
