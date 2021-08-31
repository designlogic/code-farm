namespace CodeFarm.World.Animals
{
    public interface IAnimal
    {
        public string Name { get; }
        public AnimalType AnimalType { get; }
        public string Sex { get; }

        public string MakeSound();
    }
}
