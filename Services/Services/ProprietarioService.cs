

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

    public async Task Insert(RequestCriarProprietarioDto dto)
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
}
