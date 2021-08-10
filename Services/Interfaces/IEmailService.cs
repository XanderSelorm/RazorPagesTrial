using System;
using RazorPagesTrial.Models;

namespace RazorPagesTrial.Services.Interfaces
{
    public interface IEmailService
    {
        public void SendEmail(Contact contact);

        public void SendEmail(string contact);
    }
}
