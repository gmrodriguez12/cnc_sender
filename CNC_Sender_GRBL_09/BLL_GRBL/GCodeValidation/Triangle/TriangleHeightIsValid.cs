using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeValidation.Triangle
{
    public class TriangleHeightIsValid : ISpecification<ENT_Sender_GRBL.Triangle>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Triangle entity)
        {
            double maxAxisY = double.Parse(ConfigurationManager.AppSettings["MAX_AXIS_Y_mm"]);
            return LineValidation.IsValid(entity.Height, entity.Start.Y, maxAxisY);
        }
    }
}