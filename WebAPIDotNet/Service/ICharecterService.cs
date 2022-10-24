namespace WebAPIDotNet.Service
{
    public interface ICharecterService
    {

        public Task< List<Charecter>> GetAllCharecters();

        public Task<Charecter> GetSingleCharecter();



    }
}
