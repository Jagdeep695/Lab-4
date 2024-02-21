namespace NUnitDemonstration
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            string result; //Jagdeep Singh
            if ((firstAngle + secondAngle + thirdAngle) == 180) // After killing all the mutants in this source code
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}
