using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowMax_Timer_GUI
{
    class TimeAllocation : WorkFlowMaxJob, IRecordable
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; }

        public DateTime FortnightStartDate { get; set; }

        // username for direct entry into WFM. Not sure if this is possible.
        public string User { get; set; }


        // return total time for allocation based on start and stop times
        public TimeSpan AllocatedTime()
        {
            return this.EndTime - this.StartTime;
        }

        public void Delete()
        {
            // delete record method here
        }

        public void Edit()
        {
            // edit record method here
        }

        public void Save()
        {
            // save record method here
        }
    }
}
