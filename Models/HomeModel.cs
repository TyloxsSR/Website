namespace Website.Models
{
    public static class HomeModel
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
