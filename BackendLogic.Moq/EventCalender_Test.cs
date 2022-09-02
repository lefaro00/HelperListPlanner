
using Moq;
using BackendLogic.Data.Services;
using BackendLogic.Data.Model;

namespace BackendLogic.Moq
{
    [TestClass]
    public class EventCalender_Test
    {
 
        [TestMethod]
        public void ScheduleEvent_ShouldAddAnEventToEventsAttribute() 
        {
            //Arrange
            Mock<BackendLogic.Data.Entities.Event> eventMock = new Mock<Data.Entities.Event>(null, null, null, null, null, null, null);
            
            //Act
            EventCalender.ScheduleEvent(eventMock.Object);

            List<Data.Entities.Event> events = EventCalender.OpenEvents;
            events.AddRange(EventCalender.PassedEvents);

            //Assert
            Assert.IsTrue(EventCalender.OpenEvents.Contains(eventMock.Object) || EventCalender.PassedEvents.Contains(eventMock.Object));
        }

        [TestMethod]
        public void CancelEvent_ShouldRemoveTheEventFromEvents()
        {
            //Arrange
            Mock<BackendLogic.Data.Entities.Event> eventMock = new Mock<Data.Entities.Event>(null, null, null, null, null, null, null);
            EventCalender.OpenEvents.Add(eventMock.Object);

            //Act
            EventCalender.CancelEvent(eventMock.Object);
            
            //Assert
            Assert.IsFalse(EventCalender.OpenEvents.Contains(eventMock.Object));
        }

    }
}