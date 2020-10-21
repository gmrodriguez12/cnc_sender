using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Sender_GRBL
{
    public class Geometric
    {
        public virtual Point Start { get; set; }

        public double Feed { get; set; }

        public double SafetyHeightZ { get; set; }
    }
}
