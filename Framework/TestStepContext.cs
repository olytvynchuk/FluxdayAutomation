using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public abstract class TestStepContext<T> where T : class, new()
    {

        private static Lazy<T> _instance = new Lazy<T>(() => new T());

        public static T Instance 
        {
            get => _instance.Value;
            set => _instance = null;
        }

        public P DoAction<P>(Action action) where P : class, new()
        {
            action();
            return TestStepContext<P>.Instance;
        }
    }
}
