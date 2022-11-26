using AdminPanel.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class PicturesController : Controller, IPicturesCRUDable
    {
        public Task<IActionResult> Create(string NewsName, string newsDescription, IFormFileCollection uploadedFiles)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Create()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            return View();
        }

        public Task<IActionResult> SetMainPictire(int IsMain)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IPicturesCRUDable.Index()
        {
            throw new NotImplementedException();
        }
    }
}
