using LeagueOfLegends.Business.Abstract;
using LeagueOfLegends.Business.Concrete;
using LeagueOfLegends.Entities.Abstract;
using LeagueOfLegends.Entities.Concrete.Equipments.Attack;
using LeagueOfLegends.Entities.Concrete.Equipments.Health;
using System;

namespace LeagueOfLegends
{
    public class Program
    {
        static void Main(string[] args)
        {

            ICharacterService characterService = new CharacterManager();
            IEquipmentService equipmentService = new EquipmentManager();

            DisplayAshe(characterService, equipmentService);
            DisplayAlistar(characterService, equipmentService);
            DisplayAnnie(characterService, equipmentService);

            Console.ReadLine();
        }

        static void DisplayAshe(ICharacterService characterService, IEquipmentService equipmentService)
        {
            Warrior warrior = characterService.CreateAshe();
            equipmentService.BuyEquipment(warrior, new SwordItem(), new BlueMagicItem());

            Console.WriteLine(warrior.Name + "'in Atak Gücü: " + characterService.GetTotalAttack(warrior) + " Sağlık Değeri: " + characterService.GetTotalHealth(warrior));
        }

        static void DisplayAlistar(ICharacterService characterService, IEquipmentService equipmentService)
        {
            Support support = characterService.CreateAlistar();
            equipmentService.BuyEquipment(support, new GunItem());

            Console.WriteLine(support.Name + "'ın Atak Gücü: " + characterService.GetTotalAttack(support) + " Sağlık Değeri: " + characterService.GetTotalHealth(support));
        }

        static void DisplayAnnie(ICharacterService characterService, IEquipmentService equipmentService)
        {
            Wizard wizard = characterService.CreateAnnie();
            equipmentService.BuyEquipment(wizard, new BlueMagicItem());

            Console.WriteLine(wizard.Name + "'nin Atak Gücü: " + characterService.GetTotalAttack(wizard) + " Sağlık Değeri: " + characterService.GetTotalHealth(wizard));
        }


    }
}