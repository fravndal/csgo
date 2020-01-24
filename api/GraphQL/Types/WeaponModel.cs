using GraphQL.Types;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.GraphQL.Types
{
    public class WeaponModel : ObjectGraphType<Weapon>
    {
        public WeaponModel()
        {
            Field(t => t.Id);
            Field(t => t.WeaponName);
            Field(t => t.WeaponType);
            Field(t => t.Price);
            Field(t => t.KillAward);
            Field(t => t.Damage);
            Field(t => t.Bullets);
            Field(t => t.ArmorPenetration);
            Field(t => t.DamageFalloff);
            Field(t => t.FireRate);
            Field(t => t.PenetrationPower);
            Field(t => t.MagazineSize);
            Field(t => t.AmmoReserve);
            Field(t => t.Mobility);
            Field(t => t.TaggingPower);
            Field(t => t.BulletRange);
            Field(t => t.HoldToShoot);
            Field(t => t.Tracers);
        }
    }
}
