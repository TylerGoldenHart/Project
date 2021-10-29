using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Project.Pages
{
    public class ProjectBase : ComponentBase
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
