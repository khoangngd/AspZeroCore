using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using kns.TourLand.Queries.Container;
using System;

namespace kns.TourLand.Schemas
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