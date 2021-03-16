using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kutse_app.Models
{
    public class Puhad
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Sisesta puhkuse nimi")]
        public string HolidayName { get; set; }
        [Required(ErrorMessage = "Sisesta korraldaja nimi")]
        public string OrgName { get; set; }
        [Required(ErrorMessage = "Sisesta puhkuse kuupäev")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime HolidayDate { get; set; }
    }
}