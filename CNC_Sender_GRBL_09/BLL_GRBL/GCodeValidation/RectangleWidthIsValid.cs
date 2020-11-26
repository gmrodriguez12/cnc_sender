using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeValidation
{
    public class RectangleWidthIsValid : ISpecification<Rectangle>
    {
        public bool IsSatisfiedBy(Rectangle entity)
        {
            return WidthValidation.IsValid(entity.Height, entity.Start.Y);
        }
    }
}