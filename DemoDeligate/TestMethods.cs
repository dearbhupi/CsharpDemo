using System;
using DemoDeligate;

using NUnit.Framework;

namespace DelegateDemo.Tests
{
    public class CarTests
    {
        public void StartEngine_TriggersOnEngineStartedEvent()
        {
            // Arrange
            var car = new Car();
            bool eventTriggered = false;
            string receivedMessage = null;
            car.OnEngineStarted += message => { eventTriggered = true; receivedMessage = message; };

            // Act
            car.StartEngine();

            // Assert
            
            Assert.True(eventTriggered);
            //Assert.Equal("The car engine has started.", receivedMessage);
        }
    }
}