using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace HospitalScheds.Common
{
    public static class HelperHttpClient
    {
        //三个参数第一个参数是他的Http请求方法 第二个是方法名称  第三个是对象参数
        public static string GetAll(string request, string actionName, object obj = null)
        {
            //创建返回字符串
            string json = "";
            //实例化HTTP客户端
            HttpClient hc = new HttpClient();
            //配置HTTP客户端要访问的服务器地址 主机名+端口+API+控制器+/


            hc.BaseAddress = new Uri("http://localhost:61163/");
            hc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent httpContent = new StringContent(obj.ToString());
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            httpContent.Headers.ContentType.CharSet = "utf-8";

            ////创建取服务端回包的任务
            //Task<HttpResponseMessage> task = null;

            //根据不同的请求方式,发送不同的请求包
            HttpResponseMessage result = new HttpResponseMessage(); 
            switch (request)
            {
                //tcp/ip 第一次握手 客户端hc发送请求包
                case "get": result = hc.GetAsync(actionName).Result; break;
                case "post": result = hc.PostAsync(actionName, httpContent).Result; break;
                case "put": result = hc.PutAsync(actionName, httpContent).Result; break;
                case "delete": result = hc.DeleteAsync(actionName).Result; break;
            }
            //tcp/ip 第三次握手 客户端hc确认回包完整性
            if (result.IsSuccessStatusCode)
            {
                //获取回包里面我们所需的数据转化为字符串
                var getresultstringTask = result.Content.ReadAsStringAsync();

                getresultstringTask.Wait();
                //获取转换为字符串的最终结果
                json = getresultstringTask.Result;
            }
            return json;
        }
    }
}