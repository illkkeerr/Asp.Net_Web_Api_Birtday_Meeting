using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirtdayApp.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> _liste;
        static Veritabani()
        {
            _liste = new Dictionary<string, DavetiyeModel>();
            _liste.Add("Hasan", new DavetiyeModel()
            {
                Ad = "Hasan",
                EPosta = "hasan@gmail.com",
                KatilmaDurumu = true
            });
            _liste.Add("Mehmet", new DavetiyeModel()
            {
                Ad = "Mehmet",
                EPosta = "mehmet@gmail.com",
                KatilmaDurumu = false
            });
            _liste.Add("Berrin", new DavetiyeModel()
            {
                Ad = "Berrin",
                EPosta = "berrin@gmail.com",
                KatilmaDurumu = true
            });
        }

        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);
            }
        }

        public static IEnumerable<DavetiyeModel> liste
        {
            get { return _liste.Values; }
        }
    }
}