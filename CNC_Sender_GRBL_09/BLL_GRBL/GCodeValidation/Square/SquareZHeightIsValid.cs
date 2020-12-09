using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeValidation.Square
{
    public class SquareZHeightIsValid : ISpecification<ENT_Sender_GRBL.Square>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Square entity)
        {
            double max = double.Parse(ConfigurationManager.AppSettings["MAX_AXIS_Z_mm"]);
            return LineValidation.IsValid(entity.SafetyHeightZ, entity.Start.Z, max);
        }
    }
}