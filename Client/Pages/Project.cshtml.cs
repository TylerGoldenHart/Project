using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.InMemory;

namespace RazorPagesIntro.Pages {
public class Project
{
    int num1,num2,num3,avg;
    
    [Range(1, 99, ErrorMessage = "Number invalid.")]
    public int num1 { get; set; }
    
    [Range(1, 99, ErrorMessage = "Number invalid.")]
    public int num2 { get; set; }
    
    [Range(1, 99, ErrorMessage = "Number invalid.")]
    public int num3 { get; set; }
    
    public int avg = (num1 + num2 + num3) / 3;
}

public class Index2Model : PageModel
    {
        public string Message { get; private set; } = "Null";

        public void OnGet()
        {
            Message += $" Average is { avg }";
        }
    }
}
