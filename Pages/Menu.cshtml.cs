using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTrial.Models;
using RazorPagesTrial.Services;

namespace RazorPagesTrial.Pages
{
    public class MenuModel : PageModel
    {
        public List<MenuItem> Menu { get; set; }

        public void OnGet()
        {
            var menuService = new MenuService();
            Menu = menuService.GetMenuItems();
        }
    }
}
