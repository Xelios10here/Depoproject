using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SatilanUrunController : ControllerBase
    {
        ISatilanUrunService _satilanUrunService;

        public SatilanUrunController(ISatilanUrunService satilanUrunService)
        {
            _satilanUrunService = satilanUrunService;
        }

        [HttpGet("getall")]
        public List<SatilanUrun> GetAll() 
        {
            return _satilanUrunService.GetList();
        }
    }
}
