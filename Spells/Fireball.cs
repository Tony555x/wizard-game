namespace WizardGame.Spells{
    public class Fireball:Spell{
        public string Name => "Fireball";
        public string Description => $"A fireball that deals ATK*2 damage. Costs 4 MP";
        public int Cost => 4;
        public override void Use(Wizard wizard, Enemy enemy){
            enemy.TakeDamage(wizard.ATK*2);
        }
    }
}