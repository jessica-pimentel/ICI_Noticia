using ICI.ProvaCandidato.Dados.Context;
using ICI.ProvaCandidato.Negocio.Interfaces.Repository;
using ICI.ProvaCandidato.Negocio.Models.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados.Repository.cs
{
    public class NoticiaTagRepository : Repository<NoticiaTag>, INoticiaTagRepository
    {
        private readonly NoticiaContext _context;

        public NoticiaTagRepository(NoticiaContext context) : base(context)
        {
            _context = context;
        }

        public Task<bool> AnyAsync(Func<NoticiaTag, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<NoticiaTag> FirstOrDefaultAsync(Func<NoticiaTag, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<NoticiaTag>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NoticiaTag>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}