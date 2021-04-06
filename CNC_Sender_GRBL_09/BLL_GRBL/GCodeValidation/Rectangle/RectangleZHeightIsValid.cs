using DomainValidation.Interfaces.Specification;
using System.Configuration;

namespace BLL_GRBL.GCodeValidation.Rectangle
{
    public class RectangleZHeightIsValid : ISpecification<ENT_Sender_GRBL.Rectangle>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Rectangle entity)
        {
            double maxAxisZ = double.Parse(ConfigurationManager.AppSettings["MAX_AXIS_Z_mm"]);
            return LineValidation.IsValid(entity.SafetyHeightZ, entity.Start.Z, maxAxisZ);
        }
    }
}