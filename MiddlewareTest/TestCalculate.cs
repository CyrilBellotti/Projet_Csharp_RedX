using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Couche_Middleware;

namespace MiddlewareTest
{
    [TestClass]
    public class TestCalculate
    {
        private TrackPerformance trackPerformance;
        private MachineInformation machineInfo;
        private Calculate calculate;


        //private PerformanceCounter counterDisk;
        //private PerformanceCounter counterCPU;
        //private PerformanceCounter counterRAM;

        [OneTimeSetUp]
        public void Objects()
        {
            this.trackPerformance = new TrackPerformance();
            this.machineInfo = new MachineInformation();
            this.calculate = new Calculate();
        }

        [Test]
        public void TestGetPerformance()
        {
            this.machineInfo = this.trackPerformance.getMachineInformation();
            this.machineInfo = this.trackPerformance.getAveragePerformance();
            NUnit.Framework.Assert.IsNotNull(this.machineInfo.infoRAM);
            NUnit.Framework.Assert.IsNotNull(this.machineInfo.infoCPU);
            NUnit.Framework.Assert.IsNotNull(this.machineInfo.infoDisk);
        }
    }
}
