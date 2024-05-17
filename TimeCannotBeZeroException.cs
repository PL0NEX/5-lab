using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    public class TimeCannotBeZeroException: Exception
    {
        public TimeCannotBeZeroException():base("Время не может быть нулевым") { }
    }

}
