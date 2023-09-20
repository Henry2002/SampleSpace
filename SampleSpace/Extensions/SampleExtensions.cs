using SampleSpace.Contracts;

namespace SampleSpace.Extensions
{
    public static class SampleArrayExtensions
    {
        public static double Sum(this ISample[] samples)
        {

            double count = 0;

            for (int i = 0; i < samples.Length; i++) count += samples[i].Probability;

            return count;

        }

        public static bool IsFormatted(this ISample[] Samples) => Samples.Sum() <= 1;

        public static bool IsSorted(this ISample[] Samples)
        {
            for (int i = 1; i < Samples.Length; i++) if (Samples[i].Probability < Samples[i - 1].Probability) return false;

            return true;
        }

        public static bool IsValidInput(this ISample[] Samples) => Samples.IsFormatted() && Samples.IsSorted();

    }



}
