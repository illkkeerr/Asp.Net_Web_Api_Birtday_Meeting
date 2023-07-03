using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirtdayApp.Models
{
    public class DavetiyeModel
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string EPosta { get; set; }
        [Required]
        public bool? KatilmaDurumu { get; set; }
    }
}