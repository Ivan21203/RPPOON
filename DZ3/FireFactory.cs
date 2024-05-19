using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    public class FireFactory : AbstractFactory
    {
        public override Goblin CreateGoblin()
        {
            return new FireGoblin();
        }

        public override Wizard CreateWizard()
        {
            return new FireWizard();
        }
    }
}
