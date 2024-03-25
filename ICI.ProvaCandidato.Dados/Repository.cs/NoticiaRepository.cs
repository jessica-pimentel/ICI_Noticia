using Dapper;
using ICI.ProvaCandidato.Dados.Context;
using ICI.ProvaCandidato.Negocio.Interfaces.Repository;
using ICI.ProvaCandidato.Negocio.Models.Noticias;
using ICI.ProvaCandidato.Negocio.Models.Noticias.Tags;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados.Repository.cs
{
    public class NoticiaRepository : Repository<Noticiia>, INoticiaRepository
    {
        private readonly NoticiaContext _context;

        public NoticiaRepository(NoticiaContext context) : base(context)
        {
            _context = context;
        }

        public Task<bool> AnyAsync(Expression<Func<Noticiia, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Noticiia>> GetAllAsync()
        {
            var sql = $@"SELECT * FROM noticia.Noticia";

            var r = await _dapper.QueryAsync<Noticiia>(sql);

            return r.ToList();
        }

        public async Task<IEnumerable<Noticiia>> GetById(int id)
        {
            var sql = $@"SELECT * FROM noticia.Noticia WHERE id = '{id}'";

            var r = await _dapper.QueryAsync<Noticiia>(sql);

            return r.ToList();
        }

        public override async Task Delete(int id)
        {
            var sql = "DELETE FROM noticia.Noticia WHERE Id = @Id";
            await _dapper.ExecuteAsync(sql, new { Id = id });

        }

        public override async Task Update(Noticiia noticia)
        {
            var sql = $@"UPDATE noticia.Noticia SET Titulo = @Titulo, Texto = @Texto, Tag = @Tag WHERE Id = @Id";
            await _dapper.ExecuteAsync(sql, noticia);
        }

        public Task<IEnumerable<Noticiia>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Noticiia> AddAsync(Noticiia noticia)
        {
            var insertNoticiaSql = @"
                            INSERT INTO noticia.Noticia (Titulo, Texto, Tag) 
                            OUTPUT INSERTED.Id
                            VALUES (@Titulo, @Texto, @Tag)";

            var noticiaParameters = new
            {
                Titulo = noticia.Titulo,
                Texto = noticia.Texto,
                Tag = noticia.Tag, 
            };
            var noticiaId = await _dapper.QueryFirstOrDefaultAsync<int>(insertNoticiaSql, noticiaParameters);

            noticia.Id = noticiaId;

            return noticia;
        }

        public async Task<int> GetOrCreateTagId(string tagName)
        {
            var tagId = await _dapper.QueryFirstOrDefaultAsync<int?>(
                @"SELECT Id FROM noticia.Tag WHERE Nome = @Nome",
                new { Nome = tagName }
            );

            if (tagId.HasValue)
            {
                return tagId.Value;
            }
            else
            {
                tagId = await _dapper.QuerySingleAsync<int>(
                    @"INSERT INTO noticia.Tag (Nome) OUTPUT INSERTED.Id VALUES (@Nome);",
                    new { Nome = tagName }
                );

                return tagId.Value;
            }
        }

        public async Task<IEnumerable<Noticiia>> AnyAsync(int id)
        {
            var sql = $@"
                SELECT * 
                FROM noticia.Noticia
                WHERE Id = {id}";

            var r = await _dapper.QueryAsync<Noticiia>(sql, new { id });

            return r.ToList();
        }
    }
}
