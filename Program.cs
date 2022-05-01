using static System.Console;
namespace RPG.src.Entities
{
    class Program
    {
        static void Main(string[] args)
        {

            Knight arus = new Knight("Arus", 2, "Knight");
            Wizard jennica = new Wizard("Jennica", 2, "White Wizard");
        
            WriteLine(jennica.Attack(10));
            WriteLine(arus.Attack());
        }
    }
}