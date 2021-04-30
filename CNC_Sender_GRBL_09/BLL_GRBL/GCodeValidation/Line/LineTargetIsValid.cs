using DomainValidation.Interfaces.Specification;
using System;

namespace BLL_GRBL.GCodeValidation.Line
{
    public class LineTargetIsValid : ISpecification<ENT_Sender_GRBL.Line>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Line entity)
        {
            return PointValidation.IsValid(entity.Finish.X, entity.Finish.Y, entity.Finish.Z);
        }
    }
}
