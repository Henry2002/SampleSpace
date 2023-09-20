namespace SampleSpace.Models
{
    public class RandomDouble
    {
        private static Random Random = new Random();

        public static double NextRandomDouble() => Random.NextDouble();

    }



}
