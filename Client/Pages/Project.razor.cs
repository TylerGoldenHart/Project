using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BlazorApp.Client
{

    public partial class Project
    {
        public int num1 = 0;
        public int num2 = 0;
        public int num3 = 0;
        public int avg = 0;
 
        public void DoAverage()
        {
            avg = (num1 + num2 + num3) / 3;
        }
}
}
