using BirtdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirtdayApp.Controllers
{
    public class DavetiyeController : ApiController
    {
        //[HttpGet]
        public IEnumerable<DavetiyeModel> GetKatilanlar()
        {
            return Veritabani.liste.Where(i => i.KatilmaDurumu == true).ToList();
        }
        public IEnumerable<DavetiyeModel> GetKatilmayanlar()
        {
            return Veritabani.liste.Where(i => i.KatilmaDurumu == false).ToList();
        }
        //[HttpPost]
        public void PostEkle(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                Veritabani.Add(model);
            }
           
        }
    }
}
