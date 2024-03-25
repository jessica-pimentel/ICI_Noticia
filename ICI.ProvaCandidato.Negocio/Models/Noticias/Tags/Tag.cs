using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Models.Noticias.Tags
{
    public class Tag : BaseModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
