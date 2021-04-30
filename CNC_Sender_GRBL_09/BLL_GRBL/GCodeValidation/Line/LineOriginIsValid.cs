using DomainValidation.Interfaces.Specification;

namespace BLL_GRBL.GCodeValidation.Line
{
    public class LineOriginIsValid : ISpecification<ENT_Sender_GRBL.Line>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Line entity)
        {
            return PointValidation.IsValid(entity.Start.X, entity.Start.Y, entity.Start.Z);
        }
    }
}
