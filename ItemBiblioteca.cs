public abstract class ItemBiblioteca
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    protected string DescricaoInterna = "Descrição do livro";

    // Construtor
    protected ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        
    }
    
}