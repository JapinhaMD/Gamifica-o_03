using gamificacao03.Model;
namespace gamificacao03.Interfaces;

public interface PedidoRepository
{
    void Adicionar(Pedido pedido);
    void Atualizar(Pedido pedido);
    void Excluir(int id);
    Pedido ObterPorId(int id);
    IEnumerable<Pedido> ListarTodos();
    
}