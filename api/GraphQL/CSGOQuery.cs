using Api.GraphQL.Types;
using Api.Models;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.GraphQL
{
    public class CSGOQuery : ObjectGraphType
    {
        public CSGOQuery(IWeaponRepository repo, IMapper mapper)
        {
            Field<ListGraphType<WeaponType>>(
                "allWeapons",
                resolve: context =>
                {
                    var weaponsFromRepo = repo.GetWeapons();

                    var weapons = mapper.Map<IEnumerable<WeaponDto>>(weaponsFromRepo);

                    return weapons;
                }

            );

            Field<WeaponType>(
                "weapon",
                arguments: new QueryArguments(
                new QueryArgument<IntGraphType>() { Name = "id" }
            ),
                resolve: context =>
                {
                    int id = context.GetArgument<int>("id");

                    var weaponFromRepo = repo.GetWeaponById(id);

                    var weapon = mapper.Map<WeaponDto>(weaponFromRepo);

                    return weapon;
                }

            );
        }
    }
}
