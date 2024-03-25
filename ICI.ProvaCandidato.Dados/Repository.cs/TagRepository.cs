using ICI.ProvaCandidato.Dados.Context;
using ICI.ProvaCandidato.Negocio.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using ICI.ProvaCandidato.Negocio.Models.Noticias.Tags;
using System.Linq.Expressions;
using ICI.ProvaCandidato.Negocio.Models.Noticias;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ICI.ProvaCandidato.Dados.Repository.cs
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        private readonly NoticiaContext _context;

        public TagRepository(NoticiaContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Tag>> GetAllAsync()
        {
            var sql = $@"SELECT * FROM noticia.Tag";

            var r = await _dapper.QueryAsync<Tag>(sql);

            return r.ToList();
        }

        public async Task<IEnumerable<Tag>> GetByIdAsync(int id)
        {
            var sql = $@"SELECT * FROM noticia.Tag WHERE id = '{id}'";

            var r = await _dapper.QueryAsync<Tag>(sql);

            return r;
        }

        public override async Task<Tag> Add(Tag tag)
        {
            var sql = @"INSERT INTO noticia.Tag (Descricao) Values (@Descricao);
                SELECT CAST(SCOPE_IDENTITY() AS INT)";

            var parameters = new { Descricao = tag.Descricao };

            var id = await _dapper.QueryFirstOrDefaultAsync<int>(sql, parameters);

            tag.Id = id;

            return tag;
        }

        public override async Task Delete(int id)
        {
            var sql = "DELETE FROM noticia.Tag WHERE Id = @Id";
            await _dapper.ExecuteAsync(sql, new { Id = id });

        }
        
        public override async Task Update(Tag tag)
        {
            var sql = $@"UPDATE noticia.Tag SET Descricao = @Descricao WHERE Id = @Id";
            await _dapper.ExecuteAsync(sql, tag);
        }

        public async Task<IEnumerable<Tag>> AnyAsync(int tagId)
        {
            var sql = $@"
                SELECT * 
                FROM noticia.Tag
                WHERE Id = {tagId}";

            var r = await _dapper.QueryAsync<Tag>(sql, new { tagId });

            return r.ToList();
        }
    }
}
