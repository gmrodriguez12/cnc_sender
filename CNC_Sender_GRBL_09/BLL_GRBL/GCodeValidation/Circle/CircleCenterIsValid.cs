using DomainValidation.Interfaces.Specification;

namespace BLL_GRBL.GCodeValidation.Circle
{
    public class CircleCenterIsValid : ISpecification<ENT_Sender_GRBL.Circle>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Circle entity)
        {
            return PointValidation.IsValid(entity.Center.X, entity.Center.Y, entity.Center.Z);
        }
    }
}
