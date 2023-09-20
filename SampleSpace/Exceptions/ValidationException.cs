using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSpace.Exceptions
{
    [Serializable]
    public class ValidationException : Exception
    {
        public ValidationException() : base("Input to SampleSpace constructor is not formatted properly," +
            "please make sure probabilities are sorted and sum to 1") { }
    }
}
