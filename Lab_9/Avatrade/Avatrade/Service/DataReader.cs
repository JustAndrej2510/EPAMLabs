using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avatrade.Model;
using Microsoft.Extensions.Configuration;

namespace Avatrade.Service
{
    internal class DataReader
    {
        public static TestSettings GetTestSettings()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName)
                .AddJsonFile("Avatrade/Data/avatradeTestData.json").Build();

            var section = config.GetSection(nameof(TestSettings));

            var testSettings = section.Get<TestSettings>();

            return testSettings;
        }
    }
}
