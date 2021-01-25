using DomainValidation.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeValidation.Circle
{
    public class CircleIsValid : Validator<ENT_Sender_GRBL.Circle>
    {
        public CircleIsValid()
        {
            Add("CircleZHeightIsValid", new Rule<ENT_Sender_GRBL.Circle>(new CircleZHeightIsValid(), "Axis Z Out of Range Error: The expected value must be between 0 and Max config Z"));
            Add("CircleRadiusIsValid", new Rule<ENT_Sender_GRBL.Circle>(new CircleRadiusIsValid(), "Radius Lenght: The expected value must be between 0 and Max config X and Y"));
            Add("CircleCenterIsValid", new Rule<ENT_Sender_GRBL.Circle>(new CircleCenterIsValid(), "Center Point Error: X or Y value not between 0 and max axis configured value"));
        }
    }
}
