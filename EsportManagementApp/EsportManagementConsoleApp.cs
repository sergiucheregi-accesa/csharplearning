using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsportManagementApp
{
    public class EsportManagementConsoleApp : CommandLineApplication
    {
        private ITestService _testService;

        public EsportManagementConsoleApp(ITestService testService)
        {
            _testService = testService;
        }

        public void Run()
        {
            _testService.DoSomething();
        }
    }
}
