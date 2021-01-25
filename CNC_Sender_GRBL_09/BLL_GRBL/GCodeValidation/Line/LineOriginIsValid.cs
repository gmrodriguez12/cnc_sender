using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
