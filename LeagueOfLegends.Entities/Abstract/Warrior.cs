using LeagueOfLegends.Entities.Concrete;

namespace LeagueOfLegends.Entities.Abstract
{
    public abstract class Warrior : CharacterBase
    {
        public AttackItemBase AttackItem { get; set; }
        public HealthItemBase HealthItem { get; set; }
    }
}
