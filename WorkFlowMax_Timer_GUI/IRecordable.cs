using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowMax_Timer_GUI
{
    interface IRecordable
    {
        void Save();

        void Delete();

        void Edit();

    }
}
