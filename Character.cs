namespace WizardGame{
    public abstract class Character{
        public string Name => "";
        public int HP{get;set;}
        public int MaxHP{get;set;}
        public int ATK{get;set;}
        public int DEF{get;set;}
        public void TakeDamage(int damage){
            int finalDamage = damage - DEF/2;
            if (finalDamage < 0){
                finalDamage = 0;
            }
            HP -= finalDamage;
            if (HP < 0){
                HP = 0;
            }
            Console.WriteLine($"{Name} took {finalDamage} damage.");
        }
    }
}