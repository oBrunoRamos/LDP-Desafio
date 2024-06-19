public class Livro
{
          public string titulo;
          public Autor autor;
          public double preco;

          public Livro(string titulo, Autor autor){
                    this.titulo=titulo;
                    this.autor=autor;
                    preco = 200;
          }

          public Livro(string titulo, Autor autor, double preco){
                    this.titulo=titulo;
                    this.autor=autor;
                    this.preco=preco;
          }

          public void mostrarInfo()
          {
                    Console.WriteLine($"Titulo: {titulo}\nAutor: {autor.nome}\n Preço: {preco}\n\n");
          }
          public void aplicarDesconto(double desonto)
          {
                    this.preco =  this.preco - ((this.preco / 100) * desonto);       
          }
          public void aplicarDesconto(int desonto)
          {
                    this.preco =  this.preco - desonto;       
          }
}