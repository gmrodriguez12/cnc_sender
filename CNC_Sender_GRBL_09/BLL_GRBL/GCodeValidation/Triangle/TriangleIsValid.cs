using DomainValidation.Validation;

namespace BLL_GRBL.GCodeValidation.Triangle
{
    public class TriangleIsValid : Validator<ENT_Sender_GRBL.Triangle>
    {
        public TriangleIsValid()
        {
            Add("TriangleBaseIsValid", new Rule<ENT_Sender_GRBL.Triangle>(new TriangleBaseIsValid(), "Base Out of Range: The expected value must be between 0 and Max config X"));
            Add("TriangleHeightIsValid", new Rule<ENT_Sender_GRBL.Triangle>(new TriangleHeightIsValid(), "Height Out of Range: The expected value must be between 0 and Max config Y"));
        }
    }
}