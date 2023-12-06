class ItemBiblioteca  // classe = molde Base (pai de todos)
{
    public int id {get; set;} //1º Atributo 

    public string? titulo {get; set;} //2º Atributo
    
    protected string? DescriçãoInterna {get; set;} //3º Atributo 

    public ItemBiblioteca (int Id, string Titulo) // Construtor para passar por parametro os atributos para classe
    {
        id = Id;
        titulo = Titulo;
        DescriçãoInterna = "Um bom livro para um bom leitor";

    }
    
}