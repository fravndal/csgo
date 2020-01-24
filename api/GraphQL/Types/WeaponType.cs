using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;

namespace Api.GraphQL.Types
{
    public class WeaponType : ObjectGraphType<WeaponDto>
    {
        public WeaponType()
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
            Field(t => t.WeaponImageName);
        }
    }
}
