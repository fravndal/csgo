namespace Api.Controllers
{
    using System.Linq;
    using Core.Entities;
    using Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/weapons")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {
        private IRepository _repo;
        public WeaponsController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("{id}")]
        public IActionResult GetWeapon(int id)
        {
            var weaponsFromRepo = _repo.GetById<Weapon>(id);
            return Ok(weaponsFromRepo);
        }

        [HttpGet]
        public IActionResult GetWeapons()
        {
            var weaponsFromRepo = _repo.List<Weapon>();
            return Ok(weaponsFromRepo);
        }

    }
}