using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriController : ControllerBase
    {
        IMusteriService _musteriService;

        public MusteriController(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }

        [HttpPost("add")]
        public void MusteriAdd(Musteri musteri) 
        {
           _musteriService.MusteriAdd(musteri);
        }

        [HttpGet("getall")]
        public List<Musteri> GetAll ()
        {

            return _musteriService.GetList();
        }


    }
}
