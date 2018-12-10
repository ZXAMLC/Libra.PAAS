using System;
using System.Collections.Generic;

using Libra.Iass;

namespace Libra.PAAS
{
    public class Job
    {
        public Job()
        {

        }

        public string Say()
        {
            return new Libra.Iass.Task().Hello();
        }
    }
}
