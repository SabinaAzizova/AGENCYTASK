using AgencyWeb.DAL;
using AgencyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.Manage.Controllers
{
        [Area("Manage")]
    public class PortofolioController : Controller 
    { 
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public PortofolioController(AppDbContext context,IWebHostEnvironment environment)
        {
            _context = context;

            _environment = environment;
        }

        public IActionResult Index()
        {
            return View(_context.Portofolios.ToList());
        }
        public IActionResult Create() 
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Portofolio portofolio) 
        {
            string path = _environment.WebRootPath + @"\Upload\Portofolio\";
            string filename = portofolio.ImgFile!.FileName;
            using(FileStream fileStream=new FileStream(path+filename, FileMode.Create))
            {
                portofolio.ImgFile.CopyTo(fileStream);
            }
            portofolio.ImgUrl = filename;
            _context.Portofolios.Add(portofolio);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
