using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiJenkins.Module
{
    public class HiJenkinsSpeaker
    {
        public string Hi(string name)
        {
            return string.Format("Hi, {0}. I'm Jenkins.", name);
        }
    }
}
