using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadades
{
   public  class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "soportein552@gmail.com";
            password = "admin4321";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
