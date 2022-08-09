namespace FortniteTracker.Domain
{
    public static class Info
    {
        private static IList<Proxy> Proxies { get; set; }
        private static IList<Account> Accounts { get; set; }
        private static string ResultsFolder { get; set; }

        public static void SetProxies(IList<Proxy> proxies)
            => Proxies = proxies;

        public static void SetAccounts(IList<Account> accounts)
            => Accounts = accounts;

        public static void SetResultsFolder(string resultsFolder)
            => ResultsFolder = resultsFolder;

        public static void Clear()
        {
            Proxies = new List<Proxy>();
            Accounts = new List<Account>();
            ResultsFolder = string.Empty;
        }
    }
}
