
using Moq;
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
            Mock<BackendLogic.Data.Entities.Event> eventMock = new Mock<Data.Entities.Event>();

            //Act
            
            List<Data.Entities.Event> events = EventCalender.OpenEvents;
            events.AddRange(EventCalender.PassedEvents);


            //Assert
            Assert.AreEqual(EventCalender.Hosts.FindLast, eventMock.Object.Host);
            Assert.AreEqual(EventCalender.Hosts.FindLast, eventMock.Object.Host);
        }
    }
}