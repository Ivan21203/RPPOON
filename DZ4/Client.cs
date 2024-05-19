using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class Client
    {
        public static void Run()
        {
            SMTP smtp = new SMTP(new MailConstructor());
            smtp.SendNoReplyMail();
        }
    }
}
