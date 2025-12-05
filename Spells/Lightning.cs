namespace WizardGame.Spells{
    public class Lightning:Spell{
        public override string Name => "Lightning";
        public override string Description => $"A lightning bolt that deals ATK*3 damage. Costs 7 MP";
        public override int Cost => 7;
        public override void Use(Wizard wizard, Enemy enemy){
            enemy.TakeDamage(wizard.ATK*3);
        }
    }
}