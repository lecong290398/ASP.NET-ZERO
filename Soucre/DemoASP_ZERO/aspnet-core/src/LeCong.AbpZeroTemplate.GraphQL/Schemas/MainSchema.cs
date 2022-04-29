using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using LeCong.AbpZeroTemplate.Queries.Container;
using System;

namespace LeCong.AbpZeroTemplate.Schemas
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