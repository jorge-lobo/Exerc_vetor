using System.Drawing;
using System.Globalization;
using System.Numerics;
using ConsoleApp2;
internal class Program
{
    private static void Main(string[] args)
    {
        /* Point p;
         p.X = 10;
         p.Y = 20;
         Console.WriteLine(p);

         p = new Point();
         Console.WriteLine(p); */

        /*//NULLABLE
        //double x = null; impossível

        double? x = null;
        double? y = 10.0;

        if (x.HasValue)
        {
            Console.WriteLine(x.Value);
        }
        else { Console.WriteLine("x é nulo"); }

        if (y.HasValue)
        {
            Console.WriteLine(y.Value);
        }
        else { Console.WriteLine("y é nulo"); }*/


        /* //  EXERCÍCIO 1

        Console.WriteLine("Indique o número de pessoas: ");
        int N = int.Parse(Console.ReadLine());

        //criação do vector e instanciação
        double[] vetAlturas = new double[N];


        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite altura:");
            vetAlturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double soma = 0.0;
        for (int i = 0;i < N; i++)
        {
            soma += vetAlturas[i];
        }
        double media = soma / N;
        Console.WriteLine("A média das alturas é: " + media); */


        /*//  EXERCÍCIO 2

        Console.WriteLine("Indique o número de produtos a introduzir");
        int n = int.Parse(Console.ReadLine());

        Produto[] vet = new Produto[n];


        for (int i = 0; i < n; i++)
        {
            string nome = Console.ReadLine();
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vet[i] = new Produto { Nome = nome, Preco = preco };

           
        }

        double soma = 0.0;
        for (int i = 0;i < n;i++)
        {
            soma += vet[i].Preco;
        }

        double media = soma / n;
        Console.WriteLine("A média dos preços é " + media.ToString("F2"), CultureInfo.InvariantCulture);
        */


        //  EXERCÍCIO 3

        


    }
}