public class Biblioteca
{
    private List<ItemBiblioteca> item = new List<ItemBiblioteca>();

  

    // Método para adicionar um item à coleção
    public void AdicionarItem(ItemBiblioteca itens)
    {
        item.Add(itens);
        Console.WriteLine("Livro adicionado com sucesso");
    }

    // Método para remover um item da coleção
    public void RemoverItem(ItemBiblioteca itens)
    {
        item.Remove(itens);
        Console.WriteLine("Livro removido com sucesso.");
    }

    // Método de busca por título
    public ItemBiblioteca BuscaritensPorTitulo(string titulo)
    {
        foreach (ItemBiblioteca itens in item){
            if(itens.Titulo == titulo)
            return itens;
        }
        return null;
    }

    // Método de busca por ID
    public ItemBiblioteca BuscarItemPorId(int id)
    {
        foreach (ItemBiblioteca itens in item){
            if (itens.Id == id)
            return itens;
        }
        return null;
    }
}
