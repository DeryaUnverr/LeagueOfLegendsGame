using LeagueOfLegends.Business.Abstract;
using LeagueOfLegends.Entities.Abstract;
using LeagueOfLegends.Entities.Concrete;

namespace LeagueOfLegends.Business.Concrete
{
    public class EquipmentManager : IEquipmentService
    {
        public void BuyEquipment(Warrior warrior, AttackItemBase attackItem, HealthItemBase healthItem)
        {
            warrior.AttackItem = attackItem;
            warrior.HealthItem = healthItem;
        }

        public void BuyEquipment(Support support, AttackItemBase attackItem)
        {
            support.AttackItem = attackItem;
        }

        public void BuyEquipment(Wizard wizard, HealthItemBase healtItem)
        {
            wizard.HealthItem = healtItem;
        }
    }
}
