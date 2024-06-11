using DiyetProgrami.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.CCS
{
    public interface IMailSender
    {
        Task<string> SendEmailAsync(UserViewModel userViewModel,string psw);
    }
}
