
using SampleSpace.Contracts;

namespace ProbabalisticEvents;

public interface ISampleSpace
{
   ISample Sample();
}

public interface ISampleSpace<T> : ISampleSpace
{
   public T? GetValue();

   internal ISampleSpace<T> InitialiseDefault(T _default);
}




