namespace Api.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Api.Models;
    using AutoMapper;
    using Core.Entities;
    using Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/weapons")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {
        private IWeaponRepository _repo;
        private readonly IMapper _mapper;

        public WeaponsController(IWeaponRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetWeapons()
        {
            var weaponsFromRepo = _repo.GetWeapons();

            var weapons = _mapper.Map<IEnumerable<WeaponDto>>(weaponsFromRepo);

            return Ok(weapons);
        }

        [HttpGet("{slug}")]
        public IActionResult GetWeapon(string slug)
        {
            var weaponFromRepo = _repo.GetWeaponBySlug(slug);

            var weapon = _mapper.Map<WeaponDto>(weaponFromRepo);

            return Ok(weapon);
        }

        

    }
}