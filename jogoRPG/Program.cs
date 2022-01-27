using jogoRPG.src.Entities;

namespace dotnet
{
    class Program
    {
        public static void Main(string[] args)
        {
            Knight knight = new Knight("Hero", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");
            

            System.Console.WriteLine(knight.Attack());
            System.Console.WriteLine(wizard.Attack(1));
            System.Console.WriteLine(wizard.Attack(8));
        }
    }
}