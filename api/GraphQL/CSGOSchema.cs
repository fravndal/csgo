using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.GraphQL
{
    public class CSGOSchema : Schema
    {
        public CSGOSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<CSGOQuery>();
        }
    }
}
