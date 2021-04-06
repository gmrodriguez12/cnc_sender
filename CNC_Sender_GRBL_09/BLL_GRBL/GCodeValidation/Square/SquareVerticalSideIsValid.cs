using DomainValidation.Interfaces.Specification;
using System.Configuration;

namespace BLL_GRBL.GCodeValidation.Square
{
    public class SquareVerticalSideIsValid : ISpecification<ENT_Sender_GRBL.Square>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Square entity)
        {
            double maxSide = double.Parse(ConfigurationManager.AppSettings["MAX_AXIS_Y_mm"]);
            return LineValidation.IsValid(entity.Side, entity.Start.X, maxSide);
        }
    }
}
