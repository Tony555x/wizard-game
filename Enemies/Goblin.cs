namespace WizardGame.Enemies{
    public class Goblin:Enemy{
        public Goblin():base("Goblin"){
            ATK=3;
            DEF=2;
            HP=5;
            MaxHP=5;
        }
        public override void TakeTurn(Wizard wizard){
            Console.WriteLine("Goblin attacks!");
            wizard.TakeDamage(ATK);
        }
    }
}