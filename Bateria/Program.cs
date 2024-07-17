namespace Bateria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ale = new Random();
            ConsoleKeyInfo a;
            Celula[] cel = new Celula[4];
            cel[0] = new Celula();
            cel[1] = new Celula();
            cel[2] = new Celula();
            cel[3] = new Celula();

            do
            {

                int bateria = ale.Next(4);
                int qual = ale.Next(2);

                if (qual == 0 && cel[bateria].getCargaBateira() > 0) { cel[bateria].consumir(); }
                else if (cel[bateria].getCargaBateira() <= 100) { cel[(bateria)].carregar(); }

                Console.WriteLine("Carga da bateria 1:" + cel[0].carga);
                Console.WriteLine("Carga da bateria 2:" + cel[1].carga);
                Console.WriteLine("Carga da bateria 3:" + cel[2].carga);
                Console.WriteLine("Carga da bateria 4:" + cel[3].carga);
                int total = cel[0].carga + cel[1].carga + cel[2].carga + cel[3].carga;
                cel[1].setCargabateria(total);

                Console.WriteLine("Carga total:" + cel[0].getCargaBateira());

                Console.WriteLine("Pressione 'F' para sair ou qualquer outra tecla para continuar:");
                a = Console.ReadKey();
                Console.Clear();

            } while (a.Key != ConsoleKey.F);


        }
    }
}
