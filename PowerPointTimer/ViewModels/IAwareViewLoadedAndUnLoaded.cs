using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPointTimer.ViewModels
{
    public interface IAwareViewLoadedAndUnloaded
    {
        void ViewLoaded(object view);
        void ViewUnloaded(object view);
    } 
}
