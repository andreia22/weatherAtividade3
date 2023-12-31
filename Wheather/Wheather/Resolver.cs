﻿
using System.ComponentModel;
using Autofac;

namespace Wheather
{
    public class Resolver
    {
        private static IContainer container;
        public static void Initialize(IContainer container)
        {
            Resolver.container = container;
        }
        public static T Resolve<T>()
        {
            return container.Resolve<T>();
        }
    }
}
