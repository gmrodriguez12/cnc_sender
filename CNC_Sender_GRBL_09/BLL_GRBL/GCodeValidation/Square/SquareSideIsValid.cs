using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeValidation.Square
{
    public class SquareSideIsValid : ISpecification<ENT_Sender_GRBL.Square>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Square entity)
        {
            return LineValidation.IsValid(entity.Side, entity.Start.X);
        }
    }
}
