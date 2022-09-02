using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendLogic.Data.Entities;
using Moq;

namespace BackendLogic.Moq
{
    [TestClass]
    public class Event_Test
    {
        [TestMethod]
        public void Reschedule_SchouldChangeStartAndEndTime()
        {
            //Arrange
            Mock<BackendLogic.Data.Entities.Shift> shiftMock = new Mock<Data.Entities.Shift>(null, null, null, null, null);
            
            var startTime_old = new DateTime(2023, 1, 20, 14, 0, 0);
            var endTime_old = new DateTime(2023, 1, 20, 20, 0, 0);
            Event testEvent = new Event(null,null, null, startTime_old, endTime_old, new List<Shift>() { shiftMock.Object }, null);
            var startTime_new = new DateTime(2023, 2, 20, 14, 0, 0);
            var endTime_new = new DateTime(2023, 2, 20, 20, 0, 0);

            //Act
            testEvent.Reschedule(startTime_new, endTime_new);

            //Assert
            Assert.AreEqual(startTime_new, testEvent.StartTime);
            Assert.AreEqual(endTime_new, testEvent.EndTime);

        }
    }
}
