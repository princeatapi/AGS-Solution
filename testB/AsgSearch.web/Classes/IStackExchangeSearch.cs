using System.Collections.Generic;
using StackExchange.StacMan;

namespace AsgSearch.web.Classes
{
    public interface IStackExchangeSearch
    {
        StacManResponse<Question> Search(string strText);
    }
}