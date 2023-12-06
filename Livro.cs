class Livro : ItemBiblioteca //classe derivada da classe Base (ItemBiblioteca)
{
 public string? autor {get; set;} //atributo adicional 
 
 public Livro (int Id, string Titulo,string Autor) : base (Id, Titulo) //Construtor Para puxar os atributos da classe pai 
 {
    autor = Autor;

 }

    public void ExibirDescriçãoInterna() //método sobreescrito 
    {
        Console.WriteLine($"A descrição interna desde livro é : {DescriçãoInterna}");
    }
  
}