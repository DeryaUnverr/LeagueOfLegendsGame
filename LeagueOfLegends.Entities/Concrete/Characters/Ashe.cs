using LeagueOfLegends.Entities.Abstract;

namespace LeagueOfLegends.Entities.Concrete
{
    public class Ashe : Warrior
    {
        public Ashe()
        {
            this.Name = "Ashe";
            this.HealthPoint = 105;
            this.AttackPower = 80;
        }
    }
}