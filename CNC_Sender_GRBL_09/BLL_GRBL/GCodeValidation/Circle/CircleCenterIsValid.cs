using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
