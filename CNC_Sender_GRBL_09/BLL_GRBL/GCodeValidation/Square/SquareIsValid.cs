using DomainValidation.Validation;

namespace BLL_GRBL.GCodeValidation.Square
{
    public class SquareIsValid : Validator<ENT_Sender_GRBL.Square>
    {
        public SquareIsValid()
        {
            Add("SquareVerticalSideIsValid", new Rule<ENT_Sender_GRBL.Square>(new SquareVerticalSideIsValid(), "Vertical Side Error: Expected value is > 0 and < Max Height"));
            Add("SquareHorizontalSideIsValid", new Rule<ENT_Sender_GRBL.Square>(new SquareHorizontalSideIsValid(), "Horizontal Side Error: Expected value is > 0 and < Max Width"));
        }
    }
}
