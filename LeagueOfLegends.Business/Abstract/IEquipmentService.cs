using LeagueOfLegends.Entities.Abstract;
using LeagueOfLegends.Entities.Concrete;

namespace LeagueOfLegends.Business.Abstract
{
    public interface IEquipmentService
    {
        void BuyEquipment(Warrior warrior, AttackItemBase attackItem, HealthItemBase healtItem);
        void BuyEquipment(Support support, AttackItemBase attackItem);
        void BuyEquipment(Wizard wizard, HealthItemBase healtItem);
    }
}
