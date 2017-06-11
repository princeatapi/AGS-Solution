using System.Collections.Generic;
using StackExchange.StacMan;

namespace AsgSearch.Services
{
    public interface IStackExchangeSearch
    {
        StacManResponse<Question> Search(string strText);
    }
}