

using SampleSpace.Contracts;
using SampleSpace.Models;
using SampleSpace.Extensions;
using System.Runtime.CompilerServices;
using static SampleSpace.Models.RandomDouble;
using SampleSpace.Exceptions;

namespace ProbabalisticEvents
{
    public abstract class SampleSpace : ISampleSpace
    {
        private readonly ISample[] Samples;

        protected SampleSpace(ISample[] samples) => Samples = samples;

        public ISample? TryFind(double Sample)
        {
            int i;

            //Strange for loop for branch elimination (code optimisation).

            for 
            (
                (i, double accumulator) = (0, Samples[0].Probability); 
                i < Samples.Length && accumulator > Sample; 
                accumulator += Samples[++i].Probability

            );

            return i==Samples.Length? null:Samples[i];
        }

        public ISample Find(double Sample) => TryFind(Sample) ?? new NoSample();
    
        public virtual ISample Sample() => Find(NextRandomDouble());

    }

    public class SampleSpace<T> : SampleSpace, ISampleSpace<T>
    {
        private T? Default; private bool IsDefaultInitialised = false;
        protected SampleSpace(ISample<T>[] samples) : base(samples) { }

        public static ISampleSpace<T>? TryCreate(params Sample<T>[] samples) => samples.IsValidInput() ? new SampleSpace<T>(samples) : null;

        public static ISampleSpace<T>? TryCreate(T _default, params Sample<T>[] samples) => TryCreate(samples)?.InitialiseDefault(_default);

        public static ISampleSpace<T> Create(params Sample<T>[] samples) => TryCreate(samples) ?? throw new ValidationException();

        public static ISampleSpace<T> Create(T _default, params Sample<T>[] samples) => Create(samples).InitialiseDefault(_default);

        public ISampleSpace<T> InitialiseDefault(T _default)
        {
            (Default, IsDefaultInitialised) = (_default, true);

            return this;
        }

        public override ISample<T> Sample() => (ISample<T>) base.Sample();

        public T? GetValue()
        {
            var sample = Sample();

            return sample.GetType() != typeof(NoSample) ?
                sample.Value : IsDefaultInitialised ?
                Default : default;

        }
           
    }


}
