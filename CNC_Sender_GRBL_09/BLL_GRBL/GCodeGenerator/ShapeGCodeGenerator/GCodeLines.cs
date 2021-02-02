using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_GRBL.GCodeValidation.Line;
using ENT_Sender_GRBL;

namespace BLL_Sender_GRBL.GCodeGenerator.ShapeGCodeGenerator
{
    internal class GCodeLines : IGCodeGenerator
    {
        public override StringBuilder GenerateGCode(Geometric shape)
        {
            Line line = (Line)shape;
            return GenerateGCode(line, false);
        }

        public override StringBuilder GenerateSimulatorGCode(Geometric shape)
        {
            Line line = (Line)shape;
            return GenerateGCode(line, true);
        }

        private StringBuilder GenerateGCode(Line line, bool isSimulator)
        {
            var validation = new LineIsValid().Validate(line);

            if (!validation.IsValid)
                throw new Exception(string.Join("\n", validation.Erros.Select(w => w.Message)));

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(GMovement(line.Start, "G0"));

            if(!isSimulator)
                sb.AppendLine(ToggleRele(true));

            sb.AppendLine(GMovement(line.Finish, line.Feed, "G1"));

            if(!isSimulator)
                sb.AppendLine(ToggleRele(false));

            sb.AppendLine(ReturnToHome(line.SafetyHeightZ));

            return sb;
        }
    }
}
