namespace Core.Interfaces
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IWeaponRepository
    {
        T GetWeapon<T>(int id) where T : BaseEntity;
        List<T> GetWeapons<T>() where T : BaseEntity;
    }
}
