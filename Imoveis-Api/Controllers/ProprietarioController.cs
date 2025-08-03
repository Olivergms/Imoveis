
using Domain.Dtos;
using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Imoveis_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProprietarioController : ControllerBase
    {
        private readonly IProprietarioService _service;

        public ProprietarioController(IProprietarioService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> Save([FromBody]RequestCriarProprietarioDto dto)
        {
            try
            {
                await _service.Insertsync(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proprietario>>> GetAll()
        {
            try
            {
                return Ok(await _service.FindAllAsync());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Proprietario>> FindById([FromRoute]int id)
        {
            try
            {
                var proprietario = await _service.FindByIdsync(id);

                return Ok(proprietario);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute]int id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromBody]Proprietario proprietario, [FromRoute]int id)
        {
            try
            {
                await _service.UpdateAsync(proprietario, id);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
