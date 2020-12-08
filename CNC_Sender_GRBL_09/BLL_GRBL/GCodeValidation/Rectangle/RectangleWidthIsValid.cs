using BLL_GRBL.GCodeValidation;
using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;

namespace BLL_GRBL.DomainValidation.Rectangle
{
    public class RectangleWidthIsValid : ISpecification<ENT_Sender_GRBL.Rectangle>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Rectangle entity)
        {
            return WidthValidation.IsValid(entity.Width, entity.Start.X);
        }
    }
}