using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using tls.demo.Queries.Container;
using System;

namespace tls.demo.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}