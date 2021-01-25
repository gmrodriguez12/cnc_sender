using DomainValidation.Interfaces.Specification;
using System.Configuration;

namespace BLL_GRBL.GCodeValidation.Line
{
    public class LineZHeightIsValid : ISpecification<ENT_Sender_GRBL.Line>
    {
        public bool IsSatisfiedBy(ENT_Sender_GRBL.Line entity)
        {
            double maxAxisZ = double.Parse(ConfigurationManager.AppSettings["MAX_AXIS_Z_mm"]);
            return LineValidation.IsValid(entity.SafetyHeightZ, entity.Start.Z, maxAxisZ);
        }
    }
}
