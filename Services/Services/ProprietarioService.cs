using Domain.Dtos;
using Domain.Entities;
using Domain.Repositories;
using Domain.Services;

namespace Services.Services;

public class ProprietarioService : IProprietarioService
{
	private readonly IProprietarioRepository _proprietarioRepository;

    public ProprietarioService(IProprietarioRepository proprietarioRepository)
    {
        _proprietarioRepository = proprietarioRepository;
    }

    public async Task DeleteAsync(int id)
    {
		try
		{
			var proprietario = await _proprietarioRepository.FindByIdAsync(id);

            if (proprietario == null) throw new Exception("Proprietário não encontrado");

			await _proprietarioRepository.DeleteAsync(proprietario);

        }
		catch (Exception ex)
		{

			throw ex;
		}
    }

    public async Task<IEnumerable<Proprietario>> FindAllAsync()
    {
		try
		{
			return await _proprietarioRepository.FindallAsync();
		}
		catch (Exception ex)
		{

			throw ex;
		}
    }

    public async Task<Proprietario> FindByIdsync(int id)
    {
		try
		{
			var proprietario = await _proprietarioRepository.FindByIdAsync(id);

			if (proprietario == null) throw new Exception("Proprietário não encontrado");

			return proprietario;
		}
		catch (Exception ex)
		{

			throw ex;
		}
    }

    public async Task Insertsync(RequestCriarProprietarioDto dto)
    {
		try
		{
			await _proprietarioRepository.InsertAsync(new Proprietario(dto));
		}
		catch (Exception ex)
		{

			throw ex;
		}
    }

    public async Task UpdateAsync(Proprietario proprietario, int id)
    {
		try
		{
			if (proprietario.Id != id) throw new Exception("Id diferente do objeto");
			var data = _proprietarioRepository.FindByIdAsync(proprietario.Id);

            if (proprietario == null) throw new Exception("Proprietário não encontrado");


            await _proprietarioRepository.UpdateAsync(proprietario);
		}
		catch (Exception ex)
		{

			throw ex;
		}
    }
}
