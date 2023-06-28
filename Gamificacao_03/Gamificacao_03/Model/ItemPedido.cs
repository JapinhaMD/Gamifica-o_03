namespace gamificacao03.Model;

public class ItemPedido
{
    public int Id { get; set; }
    public string? Produto { get; set; }
    public int Quantidade { get; set; }
    public double PrecoUnitario { get; set; }
    public int PedidoId { get; set; }

    public ItemPedido(int id, string? produto, int quantidade, double precoUnitario, int pedidoId)
    {
        if (string.IsNullOrWhiteSpace(produto))
        {
            throw new ArgumentException("Nome do Produto não pode ser nulo.");
        }
        if (quantidade <= 0)
        {
            throw new ArgumentException("Quantidade do Produto não pode ser nulo.");
        }
        if (precoUnitario <= 0)
        {
            throw new ArgumentException("Preço unitário deve ser maior que zero.");
        }
        
        Id = id;
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
        PedidoId = pedidoId;
    }

    public ItemPedido(string? produto, int quantidade, double precoUnitario, int pedidoId)
    {
        if (string.IsNullOrWhiteSpace(produto))
        {
            throw new ArgumentException("Nome do Produto não pode nulo.");
        }
        if (quantidade <= 0)
        {
            throw new ArgumentException("Quantidade do Produto deve ser maior que zero.");
        }
        if (precoUnitario <= 0)
        {
            throw new ArgumentException("Preço unitário deve ser maior que zero.");
        }
        
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
        PedidoId = pedidoId;
    }


}

