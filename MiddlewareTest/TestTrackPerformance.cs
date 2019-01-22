using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Donnee;
using Couche_Middleware;
using System.Diagnostics;

namespace MiddlewareTest
{
    [TestFixture]
    public class TestTrackPerformance
    {
        private TrackPerformance trackPerformance;
        private MachineInformation machineInfo;

        //private PerformanceCounter counterDisk;
        //private PerformanceCounter counterCPU;
        //private PerformanceCounter counterRAM;

        [OneTimeSetUp]
        public void Objects()
        {
            this.trackPerformance = new TrackPerformance();
            this.machineInfo = new MachineInformation();
        }

        [Test]
        public void TestGetPerformance()
        {


            this.machineInfo = this.trackPerformance.getMachineInformation();
            NUnit.Framework.Assert.IsNotNull(this.machineInfo.infoRAM);
            NUnit.Framework.Assert.IsNotNull(this.machineInfo.infoCPU);
            NUnit.Framework.Assert.IsNotNull(this.machineInfo.infoDisk);


        }
    }
}
