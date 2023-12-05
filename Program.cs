// Criando uma instância de Biblioteca
        Biblioteca biblioteca = new Biblioteca();

        // Criando uma instância de Livro
        var livro = new Livro(1, "Aventuras de Sherlock Holmes", "Arthur Conan Doyle");
        var livro2 = new Livro(2, "Harry Potter", "JK Rowling", "Livro de magia");
        Console.WriteLine($"Id {livro.Id}, {livro.Titulo} , {livro.Autor}, {livro.ExibirDescricaoInterna}");
        Console.WriteLine($"Id {livro2.Id}, {livro2.Titulo} , {livro2.Autor}, {livro2.ExibirDescricaoInterna}");

        /*
        // Adicionando o livro à biblioteca
        biblioteca.AdicionarItem(livro);

        // Buscando o livro por título
        var livroEncontrado = biblioteca.BuscaritensPorTitulo("Aventuras de Sherlock Holmes");

        // Exibindo a Descrição Interna do livro
        livro.ExibirDescricaoInterna();
        
        // Removendo o livro da biblioteca
        biblioteca.RemoverItem(livro);

        // Verificando se o livro foi removido
        ItemBiblioteca livroRemovido = biblioteca.BuscarItemPorId(1);
        if (livroRemovido == null)
        {
            Console.WriteLine("Livro removido com sucesso.");
        }
        else
        {
            Console.WriteLine("O livro ainda está na biblioteca.");
        } */