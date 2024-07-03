using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDreamWorks
{
    public class TaskProcessor
    {
        public event EventHandler<int> ProgressChanged;

        public void PerformTask()
        {
            for (int i = 0; i <= 105; i++)
            {
                
                ProgressChanged?.Invoke(this, i);
            }
        }
    }
}
