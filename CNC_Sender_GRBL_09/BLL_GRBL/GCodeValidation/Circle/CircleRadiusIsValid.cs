using DomainValidation.Interfaces.Specification;
using System.Configuration;

namespace BLL_GRBL.GCodeValidation.Circle
{
    public class CircleRadiusIsValid : ISpecification<ENT_Sender_GRBL.Circle>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Circle entity)
        {
            double maxSideX = double.Parse(ConfigurationManager.AppSettings["MAX_AXIS_X_mm"]);
            bool xSideIsValid = LineValidation.IsValid(entity.Radio, entity.Center.X, maxSideX);

            if (xSideIsValid)
            {
                double maxSideY = double.Parse(ConfigurationManager.AppSettings["MAX_AXIS_Y_mm"]);
                return LineValidation.IsValid(entity.Radio, entity.Center.Y, maxSideY);
            }

            return false;
        }
    }
}
