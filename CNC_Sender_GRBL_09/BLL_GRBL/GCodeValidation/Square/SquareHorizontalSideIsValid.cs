using DomainValidation.Interfaces.Specification;
using System.Configuration;

namespace BLL_GRBL.GCodeValidation.Square
{
    public class SquareHorizontalSideIsValid : ISpecification<ENT_Sender_GRBL.Square>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Square entity)
        {
            double maxSide = double.Parse(ConfigurationManager.AppSettings["MAX_AXIS_X_mm"]);
            return LineValidation.IsValid(entity.Side, entity.Start.Y, maxSide);
        }
    }
}