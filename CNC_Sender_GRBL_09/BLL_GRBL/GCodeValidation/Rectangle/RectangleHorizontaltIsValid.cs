using BLL_GRBL.GCodeValidation;
using DomainValidation.Interfaces.Specification;
using System.Configuration;

namespace BLL_GRBL.DomainValidation.Rectangle
{
    public class RectangleHorizontaltIsValid : ISpecification<ENT_Sender_GRBL.Rectangle>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Rectangle entity)
        {
            double maxAxisX = double.Parse(ConfigurationManager.AppSettings["MAX_AXIS_X_mm"]);
            return LineValidation.IsValid(entity.Width, entity.Start.X, maxAxisX);
        }
    }
}
