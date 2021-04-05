using BLL_GRBL.GCodeValidation.General;
using BLL_GRBL.GCodeValidation.Rectangle;
using DomainValidation.Validation;

namespace BLL_GRBL.DomainValidation.Rectangle
{
    public class RectangleIsValid : Validator<ENT_Sender_GRBL.Rectangle>
    {
        public RectangleIsValid()
        {
            Add("RectangleHorizontaltIsValid", new Rule<ENT_Sender_GRBL.Rectangle>(new RectangleHorizontaltIsValid(), "Axis X Out of Range Error: The expected value must be between 0 and Max config X"));
            Add("RectangleVerticalIsValid", new Rule<ENT_Sender_GRBL.Rectangle>(new RectangleVerticalIsValid(), "Axis Y Out of Range Error: The expected value must be between 0 and Max config Y"));
            Add("RectangleZHeightIsValid", new Rule<ENT_Sender_GRBL.Rectangle>(new RectangleZHeightIsValid(), "Axis Z Out of Range Error: The expected value must be between 0 and Max config Z"));
            Add("ShapeOriginIsValid", new Rule<ENT_Sender_GRBL.Rectangle>(new ShapeOriginIsValid(), "Origin error: X, Y or Z value not between 0 and max axis configured value"));
        }
    }
}
