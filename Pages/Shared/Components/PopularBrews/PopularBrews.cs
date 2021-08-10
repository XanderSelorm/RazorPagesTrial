using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorPagesTrial.Services;

namespace RazorPagesTrial.Pages.Components.PopularBrews
{
    public class PopularBrews : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var menu = new MenuService();
            return View(menu.GetPopularItems().Take(count));
        }
    }
}
