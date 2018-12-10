using System;
using System.Collections.Generic;

using Libra.IAAS;

namespace Libra.PAAS
{
    public class Job
    {
        public Job()
        {

        }

        public string Say()
        {
            var result = new Task().Hello();

            Console.WriteLine(result);

            return result;
        }
    }
}
