using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_05b_asp_core_demo
{
    public class test_03Model : PageModel
    {
        public string DisplayItem { get; set;  }
        public void OnGet()
        {
            DisplayItem = "Some Text";
        }
    }
}