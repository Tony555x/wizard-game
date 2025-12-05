namespace WizardGame{
    public class Wizard:Character{
        public int MP{get;set;}
        public int MaxMP{get;set;}
        public List<Spell> Spells{get;set;} = new List<Spell>();
    }
}