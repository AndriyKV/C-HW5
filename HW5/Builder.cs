using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Builder : IDeveloper
    {
        public Builder() { }
        public Builder(string _tool)
        {
            this.tool = _tool;
        }
        string tool;
        public string Tool
        {
            get
            {
                return tool;
            }
            set
            {
                Tool = tool;
            }
        }
        public void Create()
        {
            Console.WriteLine("Builder use {0}", Tool);
        }
        public void Destroy()
        {
            Console.WriteLine("The Builder uses {0} to break a wall \n", Tool);
        }
    }
}
