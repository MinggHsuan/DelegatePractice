using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Action_Func練習
{
    internal class HttpRequest
    {
        public static void Get<T>(Action<T> callback)
        {

            //建立 WebRequest 並指定目標的 uri
            WebRequest request = WebRequest.Create("http://jsonplaceholder.typicode.com/posts");
            // 使用 HttpWebRequest.Create 實際上也是呼叫 WebRequest.Create
            //WebRequest request = HttpWebRequest.Create("http://jsonplaceholder.typicode.com/posts");
            //指定 request 使用的 http verb
            request.Method = "GET";
            //使用 GetResponse 方法將 request 送出，如果不是用 using 包覆，請記得手動 close WebResponse 物件，避免連線持續被佔用而無法送出新的 request
            var httpResponse = (HttpWebResponse)request.GetResponse();
            //使用 GetResponseStream 方法從 server 回應中取得資料，stream 必需被關閉
            //使用 stream.close 就可以直接關閉 WebResponse 及 stream，但同時使用 using 或是關閉兩者並不會造成錯誤，養成習慣遇到其他情境時就比較不會出錯
            var streamReader = new StreamReader(httpResponse.GetResponseStream());
            string result = streamReader.ReadToEnd();


            T articles = JsonConvert.DeserializeObject<T>(result);

            callback(articles);
        }


    }
}
