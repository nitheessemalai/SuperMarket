using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLibrary.MarketModels
{
   public class dropdown
    {
            [Key]
            public int Departmentid { get; set; }
            [Required]
            public string Department{ get; set; }

        
    }
}
