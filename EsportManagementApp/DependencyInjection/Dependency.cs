using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsportManagementApp.DependencyInjection
{
    public class Dependency
    {
        public Dependency(Type t, DependencyLifetime l)
        {
            Type = t;
            LifeTime = l;
        }

        public Type Type { get; set; }

        public DependencyLifetime LifeTime { get; set; }

        public object Implementation { get; set; }

        public bool Implemented { get; set; }

        public void AddImplementation(object obj)
        {
            Implementation = obj;
            Implemented = true;
        }
    }
}
