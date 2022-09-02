using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendLogic.Data.Entities;
using Moq;

namespace BackendLogic.Moq
{
    [TestClass]
    public class Shift_Test
    {
        [TestMethod]
        public void SignInHelper_HelperSouldBeEnrteredOnce()
        {
            //Arrange
            Mock<BackendLogic.Data.ValueObjects.Helper> helperMock = new Mock<Data.ValueObjects.Helper>(null, null, null, null, null);
            Mock<BackendLogic.Data.ValueObjects.ShiftType> shiftTypeMock = new Mock<Data.ValueObjects.ShiftType>(null, null);

            Shift shift = new Shift(null, 2, shiftTypeMock.Object, DateTime.Now, DateTime.Now);


            //Act
            var before = shift.Helpers.Clone();
            var after_first = shift.SignInHelper(helperMock.Object);
            var after_second = shift.SignInHelper(helperMock.Object);
            
            //Assert
            Assert.IsFalse(before == after_first);
            Assert.IsTrue(after_first == after_second);

        }

        [TestMethod]
        public void ResignHelper_ShouldAlterHelpers()
        {
            //Arrange
            Mock<BackendLogic.Data.ValueObjects.Helper> helperMock = new Mock<Data.ValueObjects.Helper>(null, null, null, null, null);
            Mock<BackendLogic.Data.ValueObjects.ShiftType> shiftTypeMock = new Mock<Data.ValueObjects.ShiftType>(null, null);
            Shift shift = new Shift(null, 2, shiftTypeMock.Object, DateTime.Now, DateTime.Now);
            shift.Helpers[0] = helperMock.Object;

            //Act
            var before = shift.Helpers.Clone();
            var after = shift.ResignHelper(helperMock.Object);

            //Assert
            Assert.IsFalse(before == after);
        }

        [TestMethod]
        public void ReinitializeHelpers_ShouldChangeAmountHelpersNeededAndKeepHelpers()
        {
            //Arrange
            Mock<BackendLogic.Data.ValueObjects.Helper> helperMock = new Mock<Data.ValueObjects.Helper>(null, null, null, null, null);
            Mock<BackendLogic.Data.ValueObjects.ShiftType> shiftTypeMock = new Mock<Data.ValueObjects.ShiftType>(null, null);
            Shift shift = new Shift(null, 2, shiftTypeMock.Object, DateTime.Now, DateTime.Now);
            shift.Helpers[0] = helperMock.Object;

            //Act
            shift.AmountHelpersNeeded = 1;
            
            //Assert
            Assert.AreEqual(1, shift.AmountHelpersNeeded);
            Assert.IsTrue(shift.Helpers[0] != null);
        }

    }
}
