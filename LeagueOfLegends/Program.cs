using LeagueOfLegends.Business.Abstract;
using LeagueOfLegends.Business.Concrete;
using LeagueOfLegends.Entities.Abstract;
using LeagueOfLegends.Entities.Concrete;
using LeagueOfLegends.Entities.Concrete.Equipments.Attack;
using LeagueOfLegends.Entities.Concrete.Equipments.Health;
using System;
using System.Threading;

namespace LeagueOfLegends
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICharacterService characterService = new CharacterManager();
            IEquipmentService equipmentService = new EquipmentManager();

            Console.WriteLine(UIOperation.Wait("\n\n\n\t\tLeagueOfLegends Oyununa HoşGeldiniz.Lütfen Bekleyiniz!"));
            Thread.Sleep(5000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;

            string[] characterMenu = { "Ashe", "Alistar", "Annie" };
            while (true)
            {
                Console.WriteLine(UIOperation.CharacterList(characterMenu));
                Console.Write("\t Karakter seçimi yapınız (Çıkış yapmak için q'ya basınız) : \n");
                char choose = Console.ReadKey(true).KeyChar;
                Console.WriteLine();
                switch (choose)
                {
                    case '1':
                        DisplayAshe(characterService, equipmentService);
                        break;
                    case '2':
                        DisplayAlistar(characterService, equipmentService);
                        break;
                    case '3':
                        DisplayAnnie(characterService, equipmentService);
                        break;
                    case 'q':
                    case 'Q':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                        break;
                }
            }
        }

        static void DisplayAshe(ICharacterService characterService, IEquipmentService equipmentService)
        {
            Warrior warrior = characterService.CreateAshe();

            AttackItemBase attackItem = SelectAtackItem();
            HealthItemBase healthItem = SelectHealthItem();

            equipmentService.BuyEquipment(warrior, attackItem, healthItem);

            Console.WriteLine("\t " + warrior.Name + "'in Atak Gücü: " + characterService.GetTotalAttack(warrior) + " Sağlık Değeri: " + characterService.GetTotalHealth(warrior));
        }

        static void DisplayAlistar(ICharacterService characterService, IEquipmentService equipmentService)
        {
            Support support = characterService.CreateAlistar();

            AttackItemBase attackItem = SelectAtackItem();

            equipmentService.BuyEquipment(support, attackItem);

            Console.WriteLine("\t " + support.Name + "'ın Atak Gücü: " + characterService.GetTotalAttack(support) + " Sağlık Değeri: " + characterService.GetTotalHealth(support));
        }

        static void DisplayAnnie(ICharacterService characterService, IEquipmentService equipmentService)
        {
            Wizard wizard = characterService.CreateAnnie();

            HealthItemBase healthItem = SelectHealthItem();

            equipmentService.BuyEquipment(wizard, healthItem);

            Console.WriteLine("\t " + wizard.Name + "'nin Atak Gücü: " + characterService.GetTotalAttack(wizard) + " Sağlık Değeri: " + characterService.GetTotalHealth(wizard));
        }

        /// <summary>
        /// Atak ekipmanı seçer.
        /// </summary>
        /// <returns>Seçilen atak ekipmanıdır.</returns>
        static AttackItemBase SelectAtackItem()
        {
            AttackItemBase attackItem = null;

            while (attackItem == null)
            {
                Console.WriteLine("\t Atak Ekipman Seçim Ekranı:\n\t 1 - Silah || 2 - Kılıç \n");
                char chooseEquipment = Console.ReadKey(true).KeyChar;
                switch (chooseEquipment)
                {
                    case '1':
                        attackItem = new GunItem();
                        break;
                    case '2':
                        attackItem = new SwordItem();
                        break;
                    default:
                        Console.WriteLine("\t Lütfen geçerli bir seçim yapınız!\n");
                        break;
                }
            }
            return attackItem;
        }

        /// <summary>
        /// Sağlık ekipmanı seçer.
        /// </summary>
        /// <returns>Seçilen sağlık ekipmanıdır.</returns>
        static HealthItemBase SelectHealthItem()
        {
            HealthItemBase healthItem = null;

            while (healthItem == null)
            {
                Console.WriteLine("\t Sağlık Ekipman Seçim Ekranı:\n\t 1 - Blue || 2 - Green\n");
                char healthEquipment = Console.ReadKey(true).KeyChar;
                switch (healthEquipment)
                {
                    case '1':
                        healthItem = new BlueMagicItem();
                        break;
                    case '2':
                        healthItem = new GreenMagicItem();
                        break;
                    default:
                        Console.WriteLine("\t Lütfen geçerli bir seçim yapınız!\n");
                        break;
                }
            }
            return healthItem;
        }

    }
}