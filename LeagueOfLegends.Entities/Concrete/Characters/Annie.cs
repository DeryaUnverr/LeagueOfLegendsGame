using LeagueOfLegends.Entities.Abstract;

namespace LeagueOfLegends.Entities.Concrete
{
    public class Annie : Wizard
    {
        public Annie()
        {
            this.Name = "Annie";
            this.HealthPoint = 150;
            this.AttackPower = 20;
        }
    }
}
