using LeagueOfLegends.Entities.Concrete;

namespace LeagueOfLegends.Entities.Abstract
{
    public abstract class Support : CharacterBase
    {
        public AttackItemBase AttackItem { get; set; }
    }
}