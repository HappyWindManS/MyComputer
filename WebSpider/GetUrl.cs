using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.DirectoryServices;
using JsonCnvData;
namespace WebSpider
{
    public class GetUrl
    {
        public string GetUrlInfo(string local_province_id,string local_type_id,string school_id,string year)
        {
            string p = string.Format(@"api.eol.cn/gkcx/api/?access_token=&local_province_id={0}&
              local_type_id={1}&school_id={2}&signsafe=&uri=apidata/api/gk/score/province&year={3}",
               local_province_id, local_type_id, school_id, year);
            return GetWebClient("https://"+p);           
        }
    }
}
