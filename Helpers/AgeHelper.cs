namespace Website.Helpers
{
    public static class AgeHelper
    {
        public static int Calculate(DateTime birthdate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthdate.Year;

            if (birthdate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
