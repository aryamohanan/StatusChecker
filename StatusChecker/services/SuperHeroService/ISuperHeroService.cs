namespace StatusChecker.services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetAll();
        SuperHero GetSingle(int id);
        List<SuperHero> AddHero(SuperHero hero);
        List<SuperHero> UpdateHero(SuperHero hero);
        List<SuperHero> DeleteHero(int id);
    }
}
