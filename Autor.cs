public class Autor 
{

          public string nome;
          public string nacionalidade;

          public Autor(string nome, string nacionalidade) 
          {
                    this.nome = nome;
                    this.nacionalidade = nacionalidade;
          }

          public void mostrarInfo(){
                    Console.WriteLine($"\n\nNome: {nome} \n Nacionalidade: {nacionalidade}\n\n");
          }
}