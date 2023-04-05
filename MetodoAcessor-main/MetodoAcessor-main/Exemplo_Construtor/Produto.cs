namespace Exemplo_Construtor;
class Produto
{
    public Produto(){
        this.Nome = "XPTO";
        this.Preco = 1;
    }
    
    public Produto(double preco){
        this.Nome = "NÃO INFORMADO";
        this.Preco = preco;
    }
    
    public Produto(string nome,double desconto){
        this.Nome = nome;
        this.Preco = 10 - 10*desconto/100;
    }
   public string? Nome;
   public double Preco;

   public void MostraDados(){}

   
}
