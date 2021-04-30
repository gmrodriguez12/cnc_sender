using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;

namespace BLL_GRBL.GCodeValidation.General
{
    public class ShapeOriginIsValid : ISpecification<Geometric>
    {
        public bool IsSatisfiedBy(Geometric entity)
        {
            return PointValidation.IsValid(entity.Start.X, entity.Start.Y, entity.Start.Z);
        }
    }
}