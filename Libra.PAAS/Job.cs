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
            return new Task().Hello();
        }
    }
}
