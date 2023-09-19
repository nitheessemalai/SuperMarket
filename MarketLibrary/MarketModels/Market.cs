using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLibrary.MarketModels
{
     public  class Market
    {
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


    }
}
