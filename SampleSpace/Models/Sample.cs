using SampleSpace.Contracts;

namespace SampleSpace.Models
{
    public abstract class Sample : ISample
    {
        public Probability Probability { get; set; }
    }

    public class Sample<T> : Sample, ISample<T>
    {
        public T Value { get; set; }

        public static implicit operator Sample<T>((Probability Probability, T Value) input) => new Sample<T>
        {
            Probability = input.Probability,
            Value = input.Value
        };


    }


}
