using Domain.Dtos;
using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Imoveis_Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ImovelController : ControllerBase
{
   private readonly IImovelService _imovelService;

    public ImovelController(IImovelService imovelService)
    {
        _imovelService = imovelService;
    }


    [HttpPatch("concluir/{id}")]
    public async Task<ActionResult> Finish([FromRoute]int id)
    {
        try
        {
            await _imovelService.Finish(id);
            return Ok();
        }
        catch (Exception ex)
        {

            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult> Save([FromBody]RequestCriarImovelDto dto)
    {
        try
        {
            await _imovelService.InsertAsync(dto);
            return Ok();
        }
        catch (Exception ex)
        {

            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Imovel>>> FindAll()
    {
        try
        {
            return Ok(await _imovelService.FindAllAsync());
        }
        catch (Exception ex)
        {

            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Imovel>> FindById([FromRoute]int id)
    {
        try
        {
            return Ok(await _imovelService.FindByIdAsync(id));
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
            await _imovelService.DeleteAsync(id);
            return Ok();
        }
        catch (Exception ex)
        {

            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update([FromBody] RequestUpdateImovelDto dto, [FromRoute]int id)
    {
        try
        {
            await _imovelService.UpdateAsync(dto,id);
            return Ok();
        }
        catch (Exception ex)
        {

            return BadRequest(ex.Message);
        }
    }
}
