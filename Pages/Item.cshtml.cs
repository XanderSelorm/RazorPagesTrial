using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTrial.Models;
using RazorPagesTrial.Services;

namespace RazorPagesTrial.Pages
{
    public class ItemModel : PageModel
    {
        public string Message { get; set; }

        public MenuItem Item { get; private set; }

        public void OnGet(int id)
        {
            var menuService = new MenuService();

            Item = menuService
                .GetMenuItems()
                .FirstOrDefault(x => x.Id.Equals(id));
            Message = "The id is " + id;
        }
    }
}
