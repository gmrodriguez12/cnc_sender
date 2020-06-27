using BLL_CNC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CNC
{
    public class GrblCore
    {
        public List<IGrblRow> Sent { get; set; }

        public int Executed
        {
            get { return Sent.Count; }
        }

        public enum MacStatus
        { Unknown, Disconnected, Connecting, Idle, Run, Hold, Door, Home, Alarm, Check, Jog, Queue, Cooling }

        public List<IGrblRow> SentCommand(int index, int count)
        {
            index = Math.Min(index, Sent.Count - 1);       //force index to be in range
            count = Math.Min(count, Sent.Count - index);   //force count to be in range

            if (index >= 0 && count > 0)
                return Sent.GetRange(index, count);
            else
                return new System.Collections.Generic.List<IGrblRow>();
        }
    }
}
