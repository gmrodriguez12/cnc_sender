using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CNC.Interfaces
{
    public interface IGrblRow
    {
        string GetMessage();
        string GetResult(bool decode, bool erroronly);
        string GetToolTip(bool decode);
    }
}
