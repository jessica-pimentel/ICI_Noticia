using ICI.ProvaCandidato.Negocio.Interfaces.Service;
using ICI.ProvaCandidato.Negocio.Models.Noticias;
using ICI.ProvaCandidato.Negocio.Models.Noticias.Tags;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class NoticiaController : Controller
    {
        private readonly INoticiaService _noticiaService;

        public NoticiaController(INoticiaService noticiaService)
        {
            _noticiaService = noticiaService;
        }

        public async Task<IActionResult> Index()
        {
            var noticias = await _noticiaService.GetAllNoticiasAsync();
            return View(noticias);
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var tags = await _noticiaService.GetAllNoticiasAsync();
            return Ok(tags);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var noticia = await _noticiaService.GetNoticiaByIdAsync(id);
            if (noticia == null)
            {
                return NotFound("Erro ao encontrar noticia.");
            }
            return Ok(noticia);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Noticiia noticia)
        {
            if (noticia != null)
            {
                await _noticiaService.AddNoticiaAsync(noticia);
                return Ok("Tag cadastrada com sucesso!");
            }
            return BadRequest("Não foi possível cadastrar a noticia.");
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id, Noticiia noticia)
        {
            if (id != noticia.Id)
            {
                return BadRequest("ID da noticia não corresponde ao ID fornecido.");
            }

            try
            {
                await _noticiaService.UpdateNoticiaAsync(noticia);
            }
            catch
            {
                return StatusCode(500, "Erro interno do servidor ao atualizar a noticia.");
            }

            return Ok("Noticia atualizada com sucesso!");
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var tag = await _noticiaService.GetNoticiaByIdAsync(id);
            if (tag == null)
            {
                return NotFound("Erro ao encontrar Noticia.");
            }

            await _noticiaService.DeleteNoticiaAsync(id);

            return Ok("Noticia excluída com sucesso!");
        }
    }
}
