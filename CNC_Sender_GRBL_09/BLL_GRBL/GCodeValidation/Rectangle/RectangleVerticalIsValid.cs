using BLL_GRBL.GCodeValidation;
using DomainValidation.Interfaces.Specification;
using System.Configuration;

namespace BLL_GRBL.DomainValidation.Rectangle
{
    public class RectangleVerticalIsValid : ISpecification<ENT_Sender_GRBL.Rectangle>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Rectangle entity)
        {
            double maxAxisY = double.Parse(ConfigurationManager.AppSettings["MAX_AXIS_Y_mm"]);
            return LineValidation.IsValid(entity.Height, entity.Start.Y, maxAxisY);
        }
    }
}