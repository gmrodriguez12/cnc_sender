using DomainValidation.Validation;

namespace BLL_GRBL.DomainValidation.Rectangle
{
    public class RectangleIsValid : Validator<ENT_Sender_GRBL.Rectangle>
    {
        public RectangleIsValid()
        {
            Add("RectangleHorizontaltIsValid", new Rule<ENT_Sender_GRBL.Rectangle>(new RectangleHorizontaltIsValid(), "Horizontal Side Error: Expected value is > 0 and < Max Width"));
            Add("RectangleVerticalIsValid", new Rule<ENT_Sender_GRBL.Rectangle>(new RectangleVerticalIsValid(), "Vertical Side Error: Expected value is > 0 and < Max Height"));
        }
    }
}
