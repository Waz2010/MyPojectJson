using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JsonToJsonCompareEngine.UI.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System;
using JsonToJsonCompareEngine.UI.Data;
using JsonToJsonCompareEngine.UI.Data.Models;
using System.IO;

namespace JsonToJsonCompareEngine.UI.Controllers
{
    public class HomeController : Controller
    {
        private List<StateViewModel> stateDb = new List<StateViewModel>()
        {
            
            new StateViewModel()
            {
                    StateName = "CA",
                    Id = 1
            },
            new StateViewModel()
            {
                    StateName = "TX",
                    Id = 2
            },
            new StateViewModel()
            {
                    StateName = "VA",
                    Id = 3
            },
        };

        private List<CountyViewModel> countyDb = new List<CountyViewModel>()
        {
            new CountyViewModel()
            {
                CountyName = "Placer",
                Id = 1,
                StateId = 1,
                Files = new List<string>(){@"C:\Users\wasee\Desktop\Repo\JsonToJson\JsonFiles\Pre\Test1.json",
                 @"C:\Users\wasee\Desktop\Repo\JsonToJson\JsonFiles\Post\Test1.json"}
            },
            new CountyViewModel()
            {
                CountyName = "Orange County",
                StateId = 1,
                Id = 2,
                Files = new List<string>(){@"C:\Users\wasee\Desktop\Repo\JsonToJson\JsonFiles\Pre\Test1.json",
                 @"C:\Users\wasee\Desktop\Repo\JsonToJson\JsonFiles\Post\Test1.json"}
            },
            new CountyViewModel()
            {
                CountyName = "Sacramento",
                StateId = 1,
                Id = 3,
                Files = new List<string>(){@"C:\Users\wasee\Desktop\Repo\JsonToJson\JsonFiles\Pre\Test1.json",
                 @"C:\Users\wasee\Desktop\Repo\JsonToJson\JsonFiles\Post\Test1.json"}
            }
        };
        private List<County> DBCounties;
        private List<State> DBStates;
        private readonly DataContext _context;

        private Engine _engine;
        public HomeController(DataContext context)
        {
            _context = context;
            DBStates = _context.States.ToList();
            DBCounties = _context.Counties.ToList();
        }
        
        public IActionResult Index()
        {
            var model = new ViewModel();
            //var list = stateDb.ToList();
            var list = DBStates.ToList();
            model.States = list;
            try
            {
                string path = "wwwroot/Exclusions.txt";
                using (StreamReader sr = new StreamReader(path))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    model.Exclusions = line.Split(",").ToList();
                    
                }
            }
            catch(Exception ex)
            {

            }
            return View(model);
        }
        public IActionResult Results()
        {
            var model = new ViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult GetCountyByStateId(int stateid)
        {
            //var counties = (from county in countyDb
            //                where county.StateId == stateid
            //                select county).ToList();

            var counties = (from county in DBCounties
                            where county.StateId == stateid
                            select county).ToList();

            var list = new SelectList(counties, "Id", "CountyName");
            return Json(list);
        }

        [HttpPost]
        public ActionResult GetFilesByCountyId(int countyid)
        {
            var matchedCounty = (from county in countyDb
                            where county.Id == countyid
                                 select county).SingleOrDefault();
            if(matchedCounty.Files.Count == 0)
            {
                return Json(null);
            }
            var list = new SelectList(matchedCounty.Files);
            return Json(list);
        }

        [HttpPost]
        public ActionResult GetFilesByStateAndCounty(int StateId, int CountyId)
        {
            
            if (!DBStates.Any(x => x.Id == StateId))
            {
                return Json(new { Status = "NA", Msg = "No State Found" });
            }
            if (!DBCounties.Any(x => x.StateId == StateId && x.Id == CountyId))
            {
                return Json(new { Status = "NA", Msg = "No County Found" });
            }
            var CountyName = DBCounties.Where(x => x.Id == CountyId).FirstOrDefault().CountyName;
            var PrevFiles = DBCounties.Where(x => x.StateId == StateId && x.CountyName == CountyName).Select(x => x.PreviousFileName).ToList();
            var CurrFiles = DBCounties.Where(x => x.StateId == StateId && x.CountyName == CountyName).Select(x => x.CurrentFileName).ToList();
            return Json(new { Status = "OK", PrevFiles = PrevFiles, CurrFiles = CurrFiles });
        }
        

        [HttpGet]
        public IActionResult OnGetCompareResults(string _previousFile, string _currentFile)
        {
            return ViewComponent("CompareResult", new { previousFile = _previousFile, currentFile = _currentFile });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
