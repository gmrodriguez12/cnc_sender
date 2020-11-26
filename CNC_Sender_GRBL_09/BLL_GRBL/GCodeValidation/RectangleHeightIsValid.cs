using BLL_GRBL.GCodeValidation;
using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.DomainValidation
{
    public class RectangleHeightIsValid : ISpecification<Rectangle>
    {
        public bool IsSatisfiedBy(Rectangle entity)
        {
            return HeightValidation.HeghtIsValid(entity.Height, entity.Start.Y);
        }
    }
}
