
using Domain.Dtos;
using Domain.Entities;
using Domain.Repositories;
using Domain.Services;

namespace Services.Services;

public class ImovelService : IImovelService
{
    private readonly IImovelRepository _repository;
    private readonly IProprietarioRepository _proprietarioRepository;

    public ImovelService(IImovelRepository repository, IProprietarioRepository proprietarioRepository)
    {
        _repository = repository;
        _proprietarioRepository = proprietarioRepository;
    }

    public async Task DeleteAsync(int id)
    {
        try
        {
            var imovel = await _repository.FindByIdAsync(id);

            if (imovel == null) throw new Exception("Imovel não encontrado");

            await _repository.DeleteAsync(imovel);

        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<IEnumerable<Imovel>> FindAllAsync()
    {
        try
        {
            return await _repository.FindallAsync();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<Imovel> FindByIdAsync(int id)
    {
        var imovel = await _repository.FindByIdAsync(id);

        if (imovel == null) throw new Exception("Imovel não encontrado");

        return imovel;
    }

    public async Task Finish(int id)
    {
        try
        {
            var imovel = await _repository.FindByIdAsync(id);
            if (imovel == null) throw new Exception("Imovel não encontrado");

            if (imovel.Area == null || imovel.Endereco == null) throw new Exception("Preencha as informações do imovel para finalizar o cadastro.");

            imovel.Concluido = true;

            await _repository.UpdateAsync(imovel);
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task InsertAsync(RequestCriarImovelDto dto)
    {
        try
        {
            var proprietario = await _proprietarioRepository.FindByIdAsync(dto.ProprietarioId);
            if (proprietario == null) throw new Exception("Proprietário não encontrado");

            var imovel = new Imovel { Area = dto.Area, Endereco = dto.Endereco, ProprietarioId = dto.ProprietarioId};
            await _repository.InsertAsync(imovel);
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task UpdateAsync(RequestUpdateImovelDto ImovelDto, int id)
    {
        try
        {
            if (ImovelDto.Id != id) throw new Exception("Id diferente do objeto");
            var imovel = await _repository.FindByIdAsync(ImovelDto.Id);

            if (imovel == null) throw new Exception("Imovel não encontrado");

            if (ImovelDto.Area < 1) throw new Exception("Area do imovel não pode ser 0 ou negativo");

            imovel.AtualizaValores(ImovelDto);
            await _repository.UpdateAsync(imovel);
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
