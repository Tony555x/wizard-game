namespace WizardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            print("Wizard Game");
            print("Press any key to start");
            Console.ReadKey();
            print("Choose a spell to learn.");
            print("1. Fireball");
            print("2. Icicle");
            print("3. Lightning");
            print("Enter number between 1 and 3.");
            int spell=0;
            while (true)
            {
                try{
                    spell=int.Parse(Console.ReadLine());
                    if (spell>=1 && spell<=3){
                        break;
                    }
                }
                catch{
                    print("Enter a number between 1 and 3.");
                }
            }
            Console.Clear();
            print("You have entered the forest.");
            print("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            print("You see a goblin.");
        }
        static void print(string a){
            Console.WriteLine(a);
        }
    }
}