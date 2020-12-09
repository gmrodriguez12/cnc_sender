using BLL_GRBL.GCodeValidation.Rectangle;
using DomainValidation.Validation;

namespace BLL_GRBL.DomainValidation.Rectangle
{
    public class RectangleIsValid : Validator<ENT_Sender_GRBL.Rectangle>
    {
        public RectangleIsValid()
        {
            Add("RectangleHorizontaltIsValid", new Rule<ENT_Sender_GRBL.Rectangle>(new RectangleHorizontaltIsValid(), "Vertical Side Error: Expected value is > 0 and < Max X Axis configured value"));
            Add("RectangleVerticalIsValid", new Rule<ENT_Sender_GRBL.Rectangle>(new RectangleVerticalIsValid(), "Horizontal Side Error: Expected value is > 0 and < Max Y Axis configured value"));
            Add("RectangleZHeightIsValid", new Rule<ENT_Sender_GRBL.Rectangle>(new RectangleZHeightIsValid(), "Height Z Error: Expected value is > 0 and < Max Z Axis configured value"));
        }
    }
}
