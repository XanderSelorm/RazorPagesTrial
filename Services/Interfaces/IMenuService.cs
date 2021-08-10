using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesTrial.Models;

namespace RazorPagesTrial.Services.Interfaces
{
    public interface IMenuService
    {
        List<MenuItem> GetMenuItems();
    }
}
