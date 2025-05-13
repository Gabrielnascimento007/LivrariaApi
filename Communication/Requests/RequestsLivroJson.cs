namespace LivrariaApi.Communication.Requests;

public class RequestsLivroJson
{
    public string Titulo { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Genero { get; set; } = string.Empty;
    public double Preco { get; set; }
    public int Quantidade { get; set; }
}
