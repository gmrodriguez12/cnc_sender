using DomainValidation.Interfaces.Specification;

namespace BLL_GRBL.GCodeValidation.Square
{
    public class SquareOriginIsValid : ISpecification<ENT_Sender_GRBL.Square>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Square entity)
        {
            return PointValidation.IsValid(entity.Start.X, entity.Start.Y, entity.Start.Z);
        }
    }
}