namespace MVCDERSLERİ_BTK_AKADEMİ_SAYFASI_.Models
{
    public static class Repository
    {
        private static List<Candidates> applications = new();
        public static IEnumerable<Candidates> Applications => applications;

        public static void Add(Candidates candidate)
        {
            applications.Add(candidate);
        }
    }
}
