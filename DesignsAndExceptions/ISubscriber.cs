using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsAndExceptions
{
    public interface ISubscriber
    {
        public void Update(int currentHealth);
    }
}
