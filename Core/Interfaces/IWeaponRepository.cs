using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IWeaponRepository
    {
        Weapon GetWeaponBySlug(string slug);
        IEnumerable<Weapon> GetWeapons();
    }
}
