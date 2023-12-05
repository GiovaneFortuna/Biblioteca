public class Livro : ItemBiblioteca
{
    public string Autor { get; set; }

    // Construtor
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor;
    }

     public Livro(int id, string titulo, string autor, string descricaoInterna) : base(id, titulo)
    {
        DescricaoInterna = descricaoInterna;
    }

    // Método para exibir a DescricaoInterna
    public void ExibirDescricaoInterna()
    {
        Console.WriteLine($"Descrição Interna do Livro: {DescricaoInterna}");
    }

    


}
