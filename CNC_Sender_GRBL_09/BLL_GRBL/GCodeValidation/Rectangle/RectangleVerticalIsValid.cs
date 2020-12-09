using BLL_GRBL.GCodeValidation;
using DomainValidation.Interfaces.Specification;
using ENT_Sender_GRBL;
using System.Configuration;

namespace BLL_GRBL.DomainValidation.Rectangle
{
    public class RectangleVerticalIsValid : ISpecification<ENT_Sender_GRBL.Rectangle>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Rectangle entity)
        {
            double maxSide = double.Parse(ConfigurationManager.AppSettings["Max_Height_mm"]);
            return LineValidation.IsValid(entity.Height, entity.Start.Y, maxSide);
        }
    }
}