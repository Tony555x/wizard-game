namespace WizardGame.Spells{
    public class Lightning:Spell{
        public string Name => "Lightning";
        public string Description => $"A lightning bolt that deals ATK*3 damage. Costs 7 MP";
        public int Cost => 7;
        public override void Use(Wizard wizard, Enemy enemy){
            enemy.TakeDamage(wizard.ATK*3);
        }
    }
}