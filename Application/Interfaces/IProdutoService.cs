using Domain.Dtos;
using Domain.ViewModels;

namespace Application.Interfaces
{
    public interface IProdutoService
    {
        Task<MensagemBase<ProdutoSimplificadoDto>> BuscarTodos();
        Task<MensagemBase<int>> CriarProduto(ProdutoDto produto);
        Task<MensagemBase<bool>> AtualizarProduto(ProdutoDto produto);
        Task<MensagemBase<bool>> DeletarProduto(int produtoId);
    }
}
