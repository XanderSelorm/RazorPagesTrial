using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesTrial.Models;

namespace RazorPagesTrial.Services
{
    public interface IMenuService
    {
        List<MenuItem> GetMenuItems();
    }
}
