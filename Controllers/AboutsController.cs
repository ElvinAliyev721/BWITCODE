using BWITCODE.Models.Domain;
using BWITCODE.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BWITCODE.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutRepository _aboutRepository;
        public AboutsController(IAboutRepository aboutRepository)
        {
            _aboutRepository= aboutRepository;
        }
        [HttpGet]
        public IActionResult GetAbout()
        {
            var about= _aboutRepository.GetFirst();
            return Ok(about);
        }
    }
}
