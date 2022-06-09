using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using XO_WebApp.Models;

namespace XO_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Win()
        {
            return View(Program.mainModelData);
        }


        public IActionResult Index(MainModel model)
        {
            if (Program.mainModelData == null) 
                Program.mainModelData = new MainModel();
            //model.xo = "resutl will be here"; 
            return View(Program.mainModelData);
        }
        public IActionResult SinglePlayer(MainModel model)
        {
            if (Program.mainModelData == null)
                Program.mainModelData = new MainModel();
            //model.xo = "resutl will be here"; 
            Program.mainModelData.Action = "SinglePlayer";
            return View(Program.mainModelData);
        }
        public IActionResult SinglePlayer55(MainModel model)
        {
            if (Program.mainModelData == null)
                Program.mainModelData = new MainModel();
            //model.xo = "resutl will be here"; 
            Program.mainModelData.Action = "SinglePlayer55";
            return View(Program.mainModelData);
        }
        public IActionResult SinglePlayer99(MainModel model)
        {
            if (Program.mainModelData == null)
                Program.mainModelData = new MainModel();
            //model.xo = "resutl will be here"; 
            Program.mainModelData.Action = "SinglePlayer99";
            return View(Program.mainModelData);
        }
        public IActionResult reload()
        {
            string action  = Program.mainModelData.Action;
            Program.mainModelData = new MainModel();
            var model = Program.mainModelData;
            Program.mainModelData.Action = action; 
            model.Field = new Dictionary<string, string>();
            int ia = (int)'a';
            char a = 'a';
            for (int i = 0; i < model.size; i++)
            {
                for (int j = 0; j < model.size; j++)
                {
                    string key = a.ToString() + j.ToString();
                    model.Field.Add(key, "_");
                }
                ia++;
                a = (char)ia;
            }
            return RedirectToAction(action, model);
        }
        public IActionResult test(string cellname = "", string xplayer = "X")
        {
            Random rnd = new Random();
            int res = rnd.Next(1, 100);
            string RES = "";
            string next = "";
            if (xplayer == "X" || xplayer == "")
            {
                RES = "X";
                next = "O";
            }

            else  if(xplayer == "O")
            {
                RES = "O";
                next = "✓";
            }
            else
            {
                RES = "✓";
                next = "X";
            }
            //check
            if (Program.mainModelData == null)
                Program.mainModelData = new MainModel();

            var model = Program.mainModelData;
            //заполнить клеточку поля 
            model.Field[cellname] = RES;

            model.xo = RES;
            model.Xplayer = next;
            model.cellname = cellname;
            //проверка на победу
            bool resWin = CheckWin.checkWin(Program.mainModelData);
            if (resWin)
            {
                return RedirectToAction("win");
            }
            //вернуть вместо test.cshtml обратно главную страницу
            //на главной странице в выбранной клетке должно стоять значение (Х или O или V)
            return RedirectToAction(model.Action, model);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
