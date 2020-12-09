using BLL_GRBL.GCodeValidation.General;
using DomainValidation.Validation;

namespace BLL_GRBL.GCodeValidation.Square
{
    public class SquareIsValid : Validator<ENT_Sender_GRBL.Square>
    {
        public SquareIsValid()
        {
            Add("SquareVerticalSideIsValid", new Rule<ENT_Sender_GRBL.Square>(new SquareVerticalSideIsValid(), "Vertical Side Error: Expected value is > 0 and < Max Y Axis configured value"));
            Add("SquareHorizontalSideIsValid", new Rule<ENT_Sender_GRBL.Square>(new SquareHorizontalSideIsValid(), "Horizontal Side Error: Expected value is > 0 and < Max X Axis configured value"));
            Add("SquareZHeightIsValid", new Rule<ENT_Sender_GRBL.Square>(new SquareZHeightIsValid(), "Height Z Error: Expected value is > 0 and < Max Z Axis configured value"));
            Add("SquareZHeightIsValid", new Rule<ENT_Sender_GRBL.Square>(new SquareZHeightIsValid(), "Height Z Error: Expected value is > 0 and < Max Z Axis configured value"));
            Add("ShapeOriginIsValid", new Rule<ENT_Sender_GRBL.Square>(new ShapeOriginIsValid(), "Origin error: x, y or z value not between 0 and max axis configured value"));
        }
    }
}
