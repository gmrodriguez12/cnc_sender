using DomainValidation.Validation;

namespace BLL_GRBL.GCodeValidation.Square
{
    public class SquareIsValid : Validator<ENT_Sender_GRBL.Square>
    {
        public SquareIsValid()
        {
            Add("SquareSideIsValid", new Rule<ENT_Sender_GRBL.Square>(new SquareSideIsValid(), "Side validation error: Expected value is > 0 and < Max"));
        }
    }
}
