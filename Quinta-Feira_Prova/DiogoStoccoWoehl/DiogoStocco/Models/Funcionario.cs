namespace DiogoStocco.Models;

public class Funcionario
{
    public Funcionario()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }
    public string? Id { get; set; }
    public string? Name { get; set;}
    public int Cpf { get; set;}
    public DateTime CriadoEm { get; set; }
}