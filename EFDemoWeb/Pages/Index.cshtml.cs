using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace EFDemoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MyDataAccess myDataAccess;
        private readonly object ViewBag;
        public List<Picture> Pictures = new List<Picture>();
        public List<Picture> PicturePaths = new List<Picture>();
        public string TestPath { get; set; }
        


        public IndexModel(ILogger<IndexModel> logger, MyDataAccess _myDataAccess)
        {
            _logger = logger;
            myDataAccess = _myDataAccess;
        }

        public void OnGet()
        {
            myRun();
            
        }
        public void myRun()
        {

            Pictures = myDataAccess.Cam1KeepTable.ToList();
            Debug.WriteLine($"Antal: {Pictures.Count()}");
            Debug.WriteLine($"Antal: {Pictures.GetType()}");
            foreach (Picture o in Pictures)
            {
                Debug.WriteLine(o.FileNameCurrent_TEXT);
            }


            string startupPath = System.IO.Directory.GetCurrentDirectory();
            string startupPath2 = Environment.CurrentDirectory;

            Debug.WriteLine($" {startupPath}");
            Debug.WriteLine($" {startupPath2}");

            //C:\Users\Jimmy\source\repos\EFDemoApp\EFDemoWeb\Cam1KeepPictures



        }
    }
}
