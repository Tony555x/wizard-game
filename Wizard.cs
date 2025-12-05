using WizardGame.Spells;
namespace WizardGame{
    public class Wizard:Character{
        public int MP{get;set;}
        public int MaxMP{get;set;}
        public List<Spell> Spells{get;set;} = new List<Spell>();
        public Wizard(string name):base(name){
            ATK=2;
            DEF=2;
            HP=10;
            MaxHP=10;
            MP=10;
            MaxMP=10;
            Spells.Add(new Fireball());
            Spells.Add(new Icicle());
            Spells.Add(new Lightning());
        }
    }
}