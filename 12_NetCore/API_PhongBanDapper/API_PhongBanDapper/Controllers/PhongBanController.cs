using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API_PhongBanDapper.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_PhongBanDapper.Controllers
{
    public class PhongBanController : Controller
    {
        public IActionResult Index()
        {
            var phongBan = new List<PhongBanView>();
            var url = "http://localhost:62402/api/phongban/gets";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                phongBan = JsonConvert.DeserializeObject<List<PhongBanView>>(responseData);
            }
            return View(phongBan);
        }

        public IActionResult Create()
        {
            TempData["Success"] = null;
            return View();
        }
        [HttpPost]
        public IActionResult Create(PhongBanCreateView model)
        {
            var createResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:62402/api/phongban/create");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                createResult = bool.Parse(result);
            }
            if (createResult)
            {
                TempData["Success"] = "User has been created successfully";
            }
            ModelState.Clear();
            return View(new PhongBanCreateView() { });
        }

    }
}