public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite o valor: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a taxa de juros: ");
        double juros = Convert.ToDouble(Console.ReadLine()); 

        Juros juros1= new Juros();
        double retornojuros = juros1.CalcularJuros(valor, juros);
        double total = retornojuros + valor;


        Console.WriteLine($"O valor total com juros é: R${total.ToString("0.00")}");

    }
}
