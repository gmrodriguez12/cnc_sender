namespace BLL_GRBL.GCodeValidation
{
    public static class LineValidation
    {
        public static bool IsValid(double lenght, double starAxis, double max)
        {
            double aux = lenght + starAxis;
            return (aux > 0 && aux <= max);
        }
    }
}