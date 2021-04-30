using BLL_GRBL.GCodeValidation.General;
using DomainValidation.Validation;

namespace BLL_GRBL.GCodeValidation.Square
{
    public class SquareIsValid : Validator<ENT_Sender_GRBL.Square>
    {
        public SquareIsValid()
        {
            Add("SquareVerticalSideIsValid", new Rule<ENT_Sender_GRBL.Square>(new SquareVerticalSideIsValid(), "Axis Y Out of Range Error: The expected value must be between 0 and Max config Y"));
            Add("SquareHorizontalSideIsValid", new Rule<ENT_Sender_GRBL.Square>(new SquareHorizontalSideIsValid(), "Axis X Out of Range Error: The expected value must be between 0 and Max config X"));
            Add("SquareZHeightIsValid", new Rule<ENT_Sender_GRBL.Square>(new SquareZHeightIsValid(), "Axis Z Out of Range Error: The expected value must be between 0 and Max config Z"));
            Add("ShapeOriginIsValid", new Rule<ENT_Sender_GRBL.Square>(new ShapeOriginIsValid(), "Origin error: X, Y or Z value not between 0 and max axis configured value"));
        }
    }
}
