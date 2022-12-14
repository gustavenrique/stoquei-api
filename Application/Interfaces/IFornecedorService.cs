using Domain.Dtos;
using Domain.ViewModels;

namespace Application.Interfaces
{
    public interface IFornecedorService
    {
        Task<MensagemBase<List<FornecedorDto>>> BuscarTodos();
        Task<MensagemBase<int>> CriarFornecedor(FornecedorDto fornecedor);
        Task<MensagemBase<bool>> DeletarFornecedor(int fornecedorId);
        Task<MensagemBase<bool>> AtualizarFornecedor(FornecedorDto fornecedor);
    }
}
