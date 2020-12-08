using DomainValidation.Validation;
using ENT_Sender_GRBL;

namespace BLL_GRBL.DomainValidation
{
    public class RectangleIsValid : Validator<Rectangle>
    {
        public RectangleIsValid()
        {
            Add("RectangleHeightIsValid", new Rule<Rectangle>(new RectangleHeightIsValid(), "Height validation error: Expected value is 0 >= Start y + Val <= Max"));
            Add("RectangleWidthIsValid", new Rule<Rectangle>(new RectangleWidthIsValid(), "Width validation error: Expected value is 0 >= Start x + Val <= Max"));
        }
    }
}
