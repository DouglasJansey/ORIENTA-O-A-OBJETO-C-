namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType){}

        public override string Attack()
        {
            return this.Name + " Laçou uma magia";
        }
        public string Attack(int Bonus){
            return this.Name + " Lançou uma magia com bonus de " + Bonus;
        }
    }
}