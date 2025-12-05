namespace WizardGame{
    public abstract class Spell{
        public virtual string Name => "None";
        public virtual string Description => "None";
        public virtual int Cost => 0;
        public abstract void Use(Wizard wizard, Enemy enemy);
    }
}