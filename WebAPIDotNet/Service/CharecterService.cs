namespace WebAPIDotNet.Service
{
    public class CharecterService : ICharecterService
    {


        private static List<Charecter> charecters = new List<Charecter> {
            new Charecter(),
            new Charecter{Name="Javaid"}
        };
        public async Task<List<Charecter>> GetAllCharecters()
        {
            return charecters;
        }

        public async Task<Charecter> GetSingleCharecter()
        {
            return charecters.First();
        }
    }
}
