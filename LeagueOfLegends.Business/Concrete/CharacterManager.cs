using LeagueOfLegends.Business.Abstract;
using LeagueOfLegends.Entities.Abstract;
using LeagueOfLegends.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends.Business.Concrete
{
    public class CharacterManager : ICharacterService
    {
        public Support CreateAlistar()
        {
            return new Alistar();
        }

        public Wizard CreateAnnie()
        {
            return new Annie();
        }

        public Warrior CreateAshe()
        {
            return new Ashe();
        }

        public int GetTotalAttack(Warrior warrior)
        {
            return warrior.AttackItem == null ? warrior.AttackPower : warrior.AttackPower + warrior.AttackItem.XP;
        }

        public int GetTotalAttack(Support support)
        {
            return support.AttackItem == null ? support.AttackPower : support.AttackPower + support.AttackItem.XP;
        }

        public int GetTotalAttack(Wizard wizard)
        {
            return wizard.AttackPower;
        }

        public int GetTotalHealth(Warrior warrior)
        {
            return warrior.HealthItem == null ? warrior.HealthPoint : warrior.HealthPoint + warrior.HealthItem.HP;
        }

        public int GetTotalHealth(Support support)
        {
            return support.HealthPoint;
        }

        public int GetTotalHealth(Wizard wizard)
        {
            return wizard.HealthItem == null ? wizard.HealthPoint : wizard.HealthPoint + wizard.HealthItem.HP;
        }
    }
}
