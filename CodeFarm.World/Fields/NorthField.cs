using System.Collections.Generic;
using CodeFarm.World.Animals;

namespace CodeFarm.World.Fields
{
    public static class NorthField
    {
        private static readonly List<IAnimal> animals = new List<IAnimal>()
        {
            new Cow(){Age = 2, Breed = CattleBreed.Holstein, Name = "Sally", Weight = 1535},
            new Cow(){Age = 4, Breed = CattleBreed.Holstein, Name = "Marge", Weight = 1435},
            new Cow(){Age = 3, Breed = CattleBreed.Holstein, Name = "Millie", Weight = 1652},
            new Cow(){Age = 6, Breed = CattleBreed.Holstein, Name = "Sue", Weight = 1120},
            new Bull(){Age = 5, Breed = CattleBreed.BlackAngus, Name = "Mac", Weight = 2045},
            new Bull(){Age = 5, Breed = CattleBreed.BlackAngus, Name = "Big John", Weight = 2545},
            new Bull(){Age = 5, Breed = CattleBreed.BlackAngus, Name = "Earl", Weight = 2345},
        };

        public static IReadOnlyList<IAnimal> Animals => animals;
    }
}
