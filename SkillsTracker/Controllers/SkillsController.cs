using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    
    public class SkillsController : Controller
    {
        [Route("/skills")]
        [HttpGet]
        [HttpPost]
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>"+"<h2>Coding Languages</h2>"+"<ol><li>C#</li><li>Python</li><li>JavaScript</li></ol>";
            return Content(html, "text/html");
        }

        [Route("/skills/form")]
        [HttpGet]
        [HttpPost]
        public IActionResult form()
        {
            string date = "<label for='date'>Date:</label><input type='date' id='date' name='date'>";

            string cSharp = "<h2>C#</h2>  <select name='cSharp' id='c#'> <option value='beginner'>Beginner</option>" +
                "<option value='intermediate'>Intermediate</option>"+
                "<option value='advanced'>Advanced</option></select>";

            string python = "<h2>Python</h2>  <select name='python' id='python'> <option value='beginner'>Beginner</option>" +
                "<option value='intermediate'>Intermediate</option>" +
                "<option value='advanced'>Advanced</option></select>";

            string javaScript = "<h2>JavaScript</h2>  <select name='js' id='js'> <option value='beginner'>Beginner</option>" +
                "<option value='intermediate'>Intermediate</option>" +
                "<option value='advanced'>Advanced</option></select>";


            string button = "<input type='submit' value='Submit'/>";
            string html ="<form method = 'POST' action='/skills/form/saved'>"+date+cSharp+python+javaScript+"</br>"+button+"</form>";
            return Content(html, "text/html");
        }

        [Route("/skills/form/saved")]
        public IActionResult PostForm(string date, string cSharp, string python, string js)
        {
            string Date = "<h1>" + date + "</h1></br>";
            string csharp = "1. C#" + cSharp+"</br>";
            string JS = "2. JavaScript:" + js+"</br>";
            string Python = "3. Python:" + python;

            string html = Date + csharp + JS + Python;

            return Content(html, "text/html");

        }
    }
}
