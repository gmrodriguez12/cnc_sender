using BLL_GRBL.GCodeValidation;
using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;

namespace BLL_GRBL.DomainValidation
{
    public class RectangleWidthIsValid : ISpecification<Rectangle>
    {
        public bool IsSatisfiedBy(Rectangle entity)
        {
            return WidthValidation.IsValid(entity.Width, entity.Start.X);
        }
    }
}