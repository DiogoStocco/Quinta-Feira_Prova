namespace DiogoStocco.Models;

public class FolhaPagamento
{
    public int FolhaPagamentoId { get; set; }
    public string? Nome { get; set; }
    public DateTime CriadoEm { get; set; } = DateTime.Now;
    public double SalarioBruto {get; set; } 
}
    