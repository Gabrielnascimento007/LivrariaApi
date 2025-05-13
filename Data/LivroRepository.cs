namespace LivrariaApi.Data;

public static class LivroRepository
{
    // Lista simulando um "banco de dados"
    public static List<Livro> Livros = new();

    // Buscar livro por ID
    public static Livro GetById(int id) =>
        Livros.FirstOrDefault(l => l.Id == id);

    // Adicionar novo livro
    public static void Add(Livro livro) =>
        Livros.Add(livro);

    // Atualizar livro existente
    public static bool Update(int id, Livro livroAtualizado)
    {
        var index = Livros.FindIndex(l => l.Id == id);
        if (index == -1)
            return false;

        livroAtualizado.Id = id; // Garante que o ID não será alterado
        Livros[index] = livroAtualizado;
        return true;
    }

    // Deletar livro por ID
    public static bool Delete(int id)
    {
        var livro = GetById(id);
        if (livro == null)
            return false;

        Livros.Remove(livro);
        return true;
    }
}
