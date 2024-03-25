using ICI.ProvaCandidato.Negocio.Interfaces.Service;
using ICI.ProvaCandidato.Negocio.Models.Noticias.Tags;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : Controller
    {
        private readonly ITagService _tagService; 

        public TagController( ITagService tagService)
        {
            _tagService = tagService;
        }

        public async Task<IActionResult> Index()
        {
            var tags = await _tagService.GetAllTagsAsync();
            return View(tags);
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var tags = await _tagService.GetAllTagsAsync();
            return Ok(tags);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tag = await _tagService.GetTagByIdAsync(id);
            if (tag == null)
            {
                return NotFound("Erro ao encontrar tag.");
            }
            return Ok(tag);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Tag tag)
        {
            if (tag != null)
            {
                await _tagService.AddTagAsync(tag);
                return Ok("Tag cadastrada com sucesso!");
            }
            return BadRequest("Não foi possível cadastrar a tag.");
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id, Tag tag)
        {
            if (id != tag.Id)
            {
                return BadRequest("ID da tag não corresponde ao ID fornecido.");
            }

            try
            {
                await _tagService.UpdateTagAsync(tag);
            }
            catch
            {
                return StatusCode(500, "Erro interno do servidor ao atualizar a tag.");
            }

            return Ok("Tag atualizada com sucesso!");
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var tag = await _tagService.GetTagByIdAsync(id);
            if (tag == null)
            {
                return NotFound("Erro ao encontrar tag.");
            }

            var isTagLinkedToNews = await _tagService.IsTagLinkedToNew(id);
            if (isTagLinkedToNews.Any())
            {
                return Ok("Não é possível excluir esta tag pois está vinculada a uma notícia.");
            }

            await _tagService.DeleteTagAsync(id);

            return Ok("Tag excluída com sucesso!");
        }
    }
}
