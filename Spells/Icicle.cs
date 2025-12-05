namespace WizardGame.Spells{
    public class Icicle:Spell{
        public new string Name => "Icicle";
        public new string Description => $"An icicle that deals ATK damage and lowers enemy attack. Costs 3 MP";
        public new int Cost => 3;
        public override void Use(Wizard wizard, Enemy enemy){
            enemy.TakeDamage(wizard.ATK);  
            enemy.ATK -= 2;
            Console.WriteLine($"{enemy.Name} lost 2 ATK.");
        }
    }
}