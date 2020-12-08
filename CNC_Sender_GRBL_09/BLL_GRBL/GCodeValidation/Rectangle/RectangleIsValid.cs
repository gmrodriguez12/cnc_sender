using DomainValidation.Validation;

namespace BLL_GRBL.DomainValidation.Rectangle
{
    public class RectangleIsValid : Validator<ENT_Sender_GRBL.Rectangle>
    {
        public RectangleIsValid()
        {
            Add("RectangleHeightIsValid", new Rule<ENT_Sender_GRBL.Rectangle>(new RectangleHeightIsValid(), "Height validation error: Expected value is 0 > Start y + Val <= Max"));
            Add("RectangleWidthIsValid", new Rule<ENT_Sender_GRBL.Rectangle>(new RectangleWidthIsValid(), "Width validation error: Expected value is 0 > Start x + Val <= Max"));
        }
    }
}
