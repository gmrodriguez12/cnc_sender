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
    public class SquareHorizontalSideIsValid : ISpecification<ENT_Sender_GRBL.Square>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Square entity)
        {
            double maxSide = double.Parse(ConfigurationManager.AppSettings["Max_Width_mm"]);
            return LineValidation.IsValid(entity.Side, entity.Start.Y, maxSide);
        }
    }
}