using LeagueOfLegends.Entities.Abstract;
using LeagueOfLegends.Entities.Concrete;

namespace LeagueOfLegends.Business.Abstract
{
    public interface ICharacterService 
    {
        Warrior CreateAshe();
        Support CreateAlistar();
        Wizard CreateAnnie();

        int GetTotalHealth(Warrior warrior);
        int GetTotalHealth(Support support);
        int GetTotalHealth(Wizard wizard);

        int GetTotalAttack(Warrior warrior);
        int GetTotalAttack(Support support);
        int GetTotalAttack(Wizard wizard);
    }
}
