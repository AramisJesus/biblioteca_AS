 class Biblioteca //Classe para o gerenciamento da classe ItemBiblioteca
 {
 private List<ItemBiblioteca> colecao = new List<ItemBiblioteca>(); //Lista do ItemBiblioteca

  public void AdicionarItem(ItemBiblioteca item) //Método para adicionar itens/livros
  {
    colecao.Add(item);
  }

  public void RemoverItem (ItemBiblioteca item) //Método para remover itens/livros
  {
    colecao.Remove(item);
  }

  public ItemBiblioteca BuscarItemPorTitulo(string titulo) //Método para buscar itens/livros
  {
    return colecao.Find(item => item.titulo == titulo);
  }
    public ItemBiblioteca BuscarItemPorId(int id) //Método para buscar itens/livros
  {
    return colecao.Find(item => item.id == id);
  }
  
 }