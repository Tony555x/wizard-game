using WizardGame.Enemies;
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
            print("You have entered the forest.");
            print("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            print("You see a goblin.");
            print("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Enemy enemy=new Goblin();
            while(true){
                //print wizard name hp/max hp and mp/maxmp
                print(wizard.Name+": "+wizard.HP+"/"+wizard.MaxHP+" HP "+wizard.MP+"/"+wizard.MaxMP+" MP");
                print(enemy.Name+": "+enemy.HP+"/"+enemy.MaxHP+" HP");
                print("Spells:");
                for(int i=0;i<wizard.Spells.Count;i++){
                    print($"{wizard.Spells[i].Name}");
                }
                print("Type spell name to cast.");
                string spellName=Console.ReadLine();
                Console.Clear();
                for(int i=0;i<wizard.Spells.Count;i++){
                    if(wizard.Spells[i].Name==spellName){
                        print(wizard.Name+" cast "+spellName+"!");
                        wizard.Spells[i].Use(wizard,enemy);
                        break;
                    }
                }
                if(enemy.HP<=0){
                    print("You defeated the goblin!");
                    print("Press any key to continue.");
                    Console.ReadKey();
                    break;
                }
                enemy.TakeTurn(wizard);
                if(wizard.HP<=0){
                    print("You have been defeated.");
                    print("Press any key to exit.");
                    Console.ReadKey();
                    return;
                }
            }
        }
        static void print(string a){
            Console.WriteLine(a);
        }
    }
}