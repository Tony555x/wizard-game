namespace WizardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            print("Wizard Game");
            print("Press any key to start");
            Console.ReadKey();
            print("Type your name:");
            string name=Console.ReadLine();
            Wizard wizard=new Wizard(name);
            Console.Clear();
            print("Type 'char' to see your stats and spells.");
            print("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            print("You have entered the forest.");
            print("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            print("You see a goblin.");
            while(true){
               break; 
            }
        }
        static void print(string a){
            Console.WriteLine(a);
        }
    }
}