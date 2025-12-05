namespace WizardGame{
    public abstract class Spell{
        public string Name => "None";
        public string Description => "None";
        public int Cost => 0;
        public abstract void Use(Wizard wizard, Enemy enemy);
    }
}