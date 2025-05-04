using Laborat1.JSONWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat1.Tests
{
    public class FlushFixture : IDisposable
    {
        public void Dispose()
        {
            SaveData.FlushQueue();
        }
    }
}
