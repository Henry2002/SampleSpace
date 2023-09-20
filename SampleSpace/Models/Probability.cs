namespace SampleSpace.Models
{
    public class Probability : IProbability
    {
        public double Value
        {
            get => Value;
            set => Value = value <= 1 ? value : throw new ArgumentException("Cannot have greater than one probability");
        }

        public static implicit operator double(Probability probability) => probability.Value;

        public static implicit operator Probability(double d) => new Probability { Value = d };



    }

    public interface IProbability
    {
        double Value { get; set; }
    }
}
