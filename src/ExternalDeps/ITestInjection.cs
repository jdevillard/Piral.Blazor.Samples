using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalDeps
{
    public interface ITestInjection
    {
        public string Text { get; }
    }

    public class TestInjection : ITestInjection
    {
        public string Text => "Hello World from DI";
    }
}
