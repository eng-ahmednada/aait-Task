using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using aait_Task.Models;
using System.Web.Http.Cors;
using System.ServiceModel.Activities;

namespace aait_Task.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
            
        }

        public ActionResult Add()
        {
            return View();
        }

        //public async Task<ActionResult> getAll()
        //{
        //    s.WebService sss = new s.WebService();
        //    string urlAction = String.Format("/aait/Service/WebService.asmx/Request_SEL");
        //    var T = await GetWSObject(urlAction);
        //    return Json(T, JsonRequestBehavior.AllowGet);

        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public async Task <List<TestClass>> GetWSObject(string uriActionString)
        //{
        //    List<TestClass> list;
        //    try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri(@"http://dev.aait.com.sa");
        //            client.DefaultRequestHeaders.Accept.Clear();
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            HttpResponseMessage response = await client.GetAsync(uriActionString);
        //            response.EnsureSuccessStatusCode();
        //            var r = response.Content.ReadAsStringAsync().Result;
        //             list= JsonConvert.DeserializeObject<List<TestClass>>(response.Content.ReadAsStringAsync().Result);
        //            //var ssss= JsonConvert.DeserializeObject<T>(((HttpResponseMessage)response).Content.ReadAsStringAsync().Result);
        //            //returnValue = JsonConvert.DeserializeObject<T>(((HttpResponseMessage)response).Content.ReadAsStringAsync().Result);
        //        }
        //        return list;
        //    }
        //    catch (Exception e)
        //    {
        //        throw (e);
        //    }
        //}

    
    }
}