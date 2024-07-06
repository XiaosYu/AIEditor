using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIEditor.Services
{
    public abstract class ServerBase
    {
        public ServerBase() => PythonContext.Initialize();
    }
}
