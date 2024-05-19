using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public interface IMailConstructor
    {
        public IMailConstructor AddSubject(string subject);
        public IMailConstructor AddContent(string content);
        public IMailConstructor AddRecipient(string recipient);
        public IMailConstructor AddAttachments(string attachments);
        public IMailConstructor Reset();
        public Mail Construct();
    }
}
