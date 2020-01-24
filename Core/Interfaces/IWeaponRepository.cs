using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IWeaponRepository
    {
        Weapon GetWeaponById(int id);
        IEnumerable<Weapon> GetWeapons();
    }
}
