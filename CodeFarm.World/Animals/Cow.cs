using CodeFarm.World.Helpers;
using CodeFarm.World.Items;

namespace CodeFarm.World.Animals
{
    public class Cow : Cattle
    {
        public override AnimalType AnimalType => Animals.AnimalType.Cow;

        public Cow()
        {
            Sex = "Female";
        }

        public Milk Milk()
        {
            Log.WriteLine($"Milking {Name}");

            return new Milk();
        }

    }
}