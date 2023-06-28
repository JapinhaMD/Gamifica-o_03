using gamificacao03.Model;
namespace gamificacao03.Interfaces;


public interface ItemPedidoRepository
{
    void Adicionar(ItemPedido itemPedido);
    void Atualizar(ItemPedido itemPedido);
    void Excluir(int id);
    ItemPedido ObterPorId(int id);
    IEnumerable<ItemPedido> ListarTodos();
}