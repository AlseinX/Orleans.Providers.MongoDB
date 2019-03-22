﻿using System.Threading.Tasks;
using Orleans.Providers.MongoDB.Test.GrainInterfaces;

namespace Orleans.Providers.MongoDB.Test.Grains
{
    [StorageProvider(ProviderName = "MongoDBStore")]
    public sealed class HelloWorldGrain : Grain, IHelloWorldGrain
    {
        public Task<string> SayHello(string name)
        {
            return Task.FromResult($"hello {name}");
        }
    }
}