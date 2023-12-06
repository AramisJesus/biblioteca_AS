Biblioteca biblioteca = new Biblioteca (); //Criação da biblioteca

Livro livro1 = new Livro (1, "O poder do hábito", "Charles Duhigg"); //Primeiro objeto que capta os atributos por parametro

Livro livro2 = new Livro (2, "Livro do Aramaias", "Aramis Jesus"); //segundo objeto que capta os atributos por parametro

Livro livro3 = new Livro (3, "Harry Potter", "J. K. Rowling"); //terceiro objeto que capta os atributos por parametro


biblioteca.AdicionarItem(livro1); //método de adição
biblioteca.AdicionarItem(livro2);
biblioteca.AdicionarItem(livro3);

Livro livroEncontrado = biblioteca.BuscarItemPorTitulo("O poder do hábito") as Livro; //Método de busca
if (livroEncontrado != null)
        {
            Console.WriteLine($"Livro encontrado: {livroEncontrado.titulo} - Autor: {livroEncontrado.autor}");
            livroEncontrado.ExibirDescriçãoInterna();
        }

livroEncontrado = biblioteca.BuscarItemPorId(2) as Livro; //segundo método de busca
if (livroEncontrado != null)
        {
            Console.WriteLine($"Livro encontrado: {livroEncontrado.titulo} - Autor: {livroEncontrado.autor}");
            livroEncontrado.ExibirDescriçãoInterna(); 
        }


        else if (livroEncontrado == null)
        {
            Console.WriteLine("Livro não encontrado na biblioteca.");
        }

biblioteca.RemoverItem(livro3); //método de exclusão

livroEncontrado = biblioteca.BuscarItemPorId(3) as Livro;
if (livroEncontrado != null)
        {
            Console.WriteLine($"Livro encontrado: {livroEncontrado.titulo} - Autor: {livroEncontrado.autor}");
            livroEncontrado.ExibirDescriçãoInterna(); 
        }


        else if (livroEncontrado == null)
        {
            Console.WriteLine("Livro não encontrado na biblioteca.");
        }


