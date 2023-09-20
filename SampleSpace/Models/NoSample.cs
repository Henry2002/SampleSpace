using SampleSpace.Contracts;

namespace SampleSpace.Models
{
    public class NoSample : ISample
    {
        public Probability? Probability { get; set; }

        public NoSample(){}
    }
}
