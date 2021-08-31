namespace CodeFarm.World.Animals
{
    public class Bull : Cattle
    {
        public override AnimalType AnimalType => AnimalType.Bull;

        public Bull()
        {
            Sex = "Male";
        }
    }
}