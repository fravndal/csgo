using Api.GraphQL.Types;
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
        public CSGOQuery(IRepository repo)
        {
            Field<ListGraphType<WeaponModel>>(
                "weapons",
                resolve: context => repo.List<Weapon>()
            );
        }
    }
}
