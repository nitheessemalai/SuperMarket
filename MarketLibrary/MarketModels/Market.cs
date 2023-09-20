using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLibrary.MarketModels
{
    public class Market
    {
        public Market()
        {
            type = new List<dropdown>();
        }
        [Key]
        public int  ID { get; set; }
        [Required]
        
        public string Name { get; set; }
        [Required]

        public  int code { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public  int salary { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        public List<dropdown> type { get; set; }


    }
}
