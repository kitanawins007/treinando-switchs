namespace Month
{
    class Semana
    {
       public static int dia = Convert.ToInt32(Console.ReadLine());
        static void Main(string[] args)
        {
            switch (dia)
            {
                case 1: Console.WriteLine("Domingo!");
                        break;
                    case 2: Console.WriteLine("Segunda!");
                        break;

            }
        }
    }
}

