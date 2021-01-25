using DomainValidation.Interfaces.Specification;
using System.Configuration;

namespace BLL_GRBL.GCodeValidation.Circle
{
    public class CircleZHeightIsValid : ISpecification<ENT_Sender_GRBL.Circle>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Circle entity)
        {
            double maxAxisZ = double.Parse(ConfigurationManager.AppSettings["MAX_AXIS_Z_mm"]);
            return LineValidation.IsValid(entity.SafetyHeightZ, entity.Start.Z, maxAxisZ);
        }
    }
}
