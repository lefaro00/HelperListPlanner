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

        [TestMethod]
        public void AddShift_ShouldReturnTrueAndAddShiftToAttributeShifts()
        {
            //Arrange
            Event _event = new Event(null, null, null, DateTime.Now, DateTime.Now, new List<Shift>(), null);
            Mock<BackendLogic.Data.Entities.Shift> shiftMock = new Mock<Data.Entities.Shift>(null, null, null, null, null);

            //Act
            var success = _event.AddShift(shiftMock.Object);

            //Assert
            Assert.IsTrue(success);
            Assert.IsTrue(_event.Shifts.Contains(shiftMock.Object));
        }

        [TestMethod]
        public void RmoveShift_ShouldReturnTrueAndRemoveShiftFromAttributeShifts()
        {
            //Arrange
            Event _event = new Event(null, null, null, DateTime.Now, DateTime.Now, new List<Shift>(), null);
            Mock<BackendLogic.Data.Entities.Shift> shiftMock = new Mock<Data.Entities.Shift>(null, null, null, null, null);
            _event.Shifts.Add(shiftMock.Object);

            //Act
            var success = _event.RemoveShift(shiftMock.Object);

            //Assert
            Assert.IsTrue(success);
            Assert.IsFalse(_event.Shifts.Contains(shiftMock.Object));
        }

        [TestMethod]
        public void Passed_SchouldReturnTrueWhenStartTimeInThePast()
        {
            //Arrange
            Event passedEvent = new Event(null, null, null, new DateTime(2020, 01, 20, 20,0,0), new DateTime(2020, 01, 20, 23, 59, 0), null, null);
            Event openEvent = new Event(null, null, null, new DateTime(2023, 01, 20, 20, 0, 0), new DateTime(2023, 01, 20, 23, 59, 0), null, null);

            //Act
            var passedEvent_Passed = passedEvent.Passed;
            var openEvent_Passed = openEvent.Passed;
            
            //Assert
            Assert.IsTrue(passedEvent_Passed);
            Assert.IsFalse(openEvent_Passed);
        }

    }
}
