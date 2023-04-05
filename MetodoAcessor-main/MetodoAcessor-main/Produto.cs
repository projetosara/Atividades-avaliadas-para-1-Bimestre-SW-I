namespace Exemplo_Acessor;
class Produto
{
   public string? Nome;
   public double Preco;

   public void MostraDados(){
    Console.WriteLine("Nome: "+ this.Nome);
    Console.WriteLine("Preço: "+ this.Preco);
   }
   public void AlteraPreco(double preco){
        if(preco >=0){
            this.Preco = preco;
        }else{
            Console.WriteLine("VALOR INVÁLIDO!");
        }
   }
   public void AlteraNome(string nome){
    this.Nome = nome;
   }
}
