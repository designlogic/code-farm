namespace CodeFarm.World.Animals
{

    public abstract class Cattle : IAnimal
    {
        public abstract AnimalType AnimalType { get; }
        
        public string Name { get; set; } = "";
        public string Sex { get; set; } = "";
        public int Age { get; set; }
        public int Weight { get; set; }
        public CattleBreed Breed { get; set; }

        public virtual string MakeSound()
        {
            return "Mooooooooooo";
        }
    }
}
