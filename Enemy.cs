namespace WizardGame{
    public abstract class Enemy:Character{
        public abstract void TakeTurn(Wizard wizard);
        public Enemy(string name):base(name){
        }
    }
}