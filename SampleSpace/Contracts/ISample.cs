using SampleSpace.Models;

namespace SampleSpace.Contracts
{

    public interface ISample<T> : ISample
    {

        T Value { get; set; }
    }

    public interface ISample
    {
        Probability Probability { get; set; }
    }
}
