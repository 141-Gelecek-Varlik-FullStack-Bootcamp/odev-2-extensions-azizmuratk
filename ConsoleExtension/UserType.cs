using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExtension
{
    public enum UserType
    {
        // Example Type
        [Display(Name = "Admin")]
        Type1 = 1,

        [Display(Name = "Business")]
        Type2 = 2,

        [Display(Name = "Client")]
        Type3 = 3,
    }
}
