using Autofac.Core;
using Autofac.Extras.Moq;
using DevSkill.ProjectDeathStar.BattleEngine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class PlanetTests 
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreatePlanet_GivenProperNameOfPlanet_CreatesCorrectPlanet() 
        {
            using (var mock = AutoMock.GetLoose()) 
            {
                // Arrange

                // Act
                var pandora = Planet.CreatePlanet("Pandora");

                // Assert
                
                Assert.Multiple(() =>
                {
                    Assert.AreEqual("Pandora", pandora.Name, "Name mismatch.");
                });

            }
        }

        [Test]
        public void CreatePlanet_GivenInvalidShipname_ThrowsException()
        {
            using (var mock = AutoMock.GetLoose()) 
            {
                // Arrange

                // Act


                // Assert
                Assert.Multiple(() =>
                {
                    var ex = Assert.Throws<Exception>(() => Planet.CreatePlanet("Pandora2"),
                        "Expected exception is missing");
                    Assert.AreEqual("Invalid planet name", ex.Message, "Wrong error message");
                });

            }
        }

    }
}