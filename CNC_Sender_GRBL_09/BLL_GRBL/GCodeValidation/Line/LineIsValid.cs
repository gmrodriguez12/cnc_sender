using DomainValidation.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeValidation.Line
{
    public class LineIsValid : Validator<ENT_Sender_GRBL.Line>
    {
        public LineIsValid()
        {
            Add("LineZHeightIsValid", new Rule<ENT_Sender_GRBL.Line>(new LineZHeightIsValid(), "Axis Z Out of Range Error: The expected value must be between 0 and Max config Z"));
            Add("LineOriginIsValid", new Rule<ENT_Sender_GRBL.Line>(new LineOriginIsValid(), "Origin Point Error: X or Y value not between 0 and max axis configured value"));
            Add("LineTargetIsValid", new Rule<ENT_Sender_GRBL.Line>(new LineTargetIsValid(), "Target Point Error: X or Y value not between 0 and max axis configured value"));
        }
    }
}
