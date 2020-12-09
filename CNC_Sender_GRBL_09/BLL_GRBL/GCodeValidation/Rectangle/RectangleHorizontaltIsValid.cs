using BLL_GRBL.GCodeValidation;
using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;
using System.Configuration;

namespace BLL_GRBL.DomainValidation.Rectangle
{
    public class RectangleHorizontaltIsValid : ISpecification<ENT_Sender_GRBL.Rectangle>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Rectangle entity)
        {
            double maxSide = double.Parse(ConfigurationManager.AppSettings["MAX_X_AXIS_mm"]);
            return LineValidation.IsValid(entity.Width, entity.Start.X, maxSide);
        }
    }
}
