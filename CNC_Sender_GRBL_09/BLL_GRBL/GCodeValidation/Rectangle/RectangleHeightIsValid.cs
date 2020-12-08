using BLL_GRBL.GCodeValidation;
using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;

namespace BLL_GRBL.DomainValidation.Rectangle
{
    public class RectangleHeightIsValid : ISpecification<ENT_Sender_GRBL.Rectangle>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Rectangle entity)
        {
            return HeightValidation.IsValid(entity.Height, entity.Start.Y);
        }
    }
}
