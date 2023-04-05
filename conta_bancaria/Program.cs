namespace conta_bancaria;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ExercÍcio Conta Bancaria - ETEC MCM");
        Conta conta = new Conta ();

        conta.nomeCliente = "Sara Beatriz";

       // conta.numeroConta = 123;

        conta.limite = 500;

        //conta.saldo = 5000;

        conta.depositar(200);
        conta.sacar(50);

        //Console.WriteLine("Olá, " + conta.nomeCliente + ", seu saldo é de: " + conta.saldo);
       //Console.WriteLine("Seu Limite de Saque é de:" + conta.limite);
        //Console.WriteLine("O numero da sua conta é: "+ conta.numeroConta);

        double saldo = conta.ConsultaSaldo();
        Console.WriteLine("Seu saldo é de: "+ saldo);
    }
}
