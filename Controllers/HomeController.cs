using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SharpCifs.Smb;

namespace ShareMount.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View(new FormModel() {Url="smb://UserName:Password@ServerIP/ShareName/FolderName/"});
        }

        [HttpPost]
        public IActionResult List(FormModel model)
        {
            try
            {
                var folder = new SmbFile(model.Url);
                model.Files = folder.ListFiles().Select(x => x.GetName()).ToList();
            }
            catch (Exception e)
            {
                model.Exception = e.ToString();
            }
            
            return View("Index", model);
        }
        
    }
}