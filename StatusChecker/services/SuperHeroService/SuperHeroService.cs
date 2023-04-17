namespace StatusChecker.services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private List<SuperHero> superHeros = new List<SuperHero>
            {
                new SuperHero {
                    id =1,
                    name= "Spider man"
                },
                 new SuperHero {
                    id =2,
                    name= "Hulk"
                },
                 new SuperHero {
                    id =3,
                    name= "Iron Man"
                }
};
        public List<SuperHero> AddHero(SuperHero hero)
        {
            superHeros.Add(hero);

            return superHeros;
        }

        public List<SuperHero> DeleteHero(int id)
        {

            var hero = superHeros.Find(x => x.id == id);
            superHeros.Remove(hero);
            return superHeros;
        }

        public List<SuperHero> GetAll()
        {
            return superHeros;
        }

        public SuperHero GetSingle(int id)
        {
            var hero = superHeros.Find(x => x.id == id);
            if (hero is null)
            {
                return null;
            }
            return hero;
        }

        public List<SuperHero> UpdateHero(SuperHero hero)
        {
            var hero1 = superHeros.Find(x => x.id == hero.id);
            hero1.name = hero.name;
            return superHeros;
        }

     
    }
}
