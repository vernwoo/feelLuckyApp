using System.Collections.Generic;
using System.Threading.Tasks;


namespace feelLuckyApp
{
    public interface IDataStore
    {
      string GetLuckyString(bool forceRefresh = false);
    }
}
