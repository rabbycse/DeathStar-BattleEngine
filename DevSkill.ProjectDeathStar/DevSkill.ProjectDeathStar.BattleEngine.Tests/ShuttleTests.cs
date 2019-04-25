using Autofac.Core;
using Autofac.Extras.Moq;
using DevSkill.ProjectDeathStar.BattleEngine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Moq;

namespace Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class ShuttleTests 
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InstallWeapon_SetweaponInSlot_SetsweaponInCorrectSlot()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange 
                var comet = Shuttle.CreateShuttle("Comet");
                var cannon = Weapon.CreateWeapon("Cannon", WeaponType.Small);

                //Act
                comet.InstallWeapon(cannon, 0);
                Assert.AreEqual(cannon, comet.WeaponSlots[0]);
            }
        }

        [Test]
        public void CreateShuttle_GivenProperNameOfShip_CreatesCorrectShip() 
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange

                // Act
                var comet = Shuttle.CreateShuttle("Comet"); 

                // Assert
                Assert.Multiple(() =>
                {
                    Assert.AreEqual("Comet", comet.Name, "Name mismatch.");
                    Assert.AreEqual(1, comet.WeaponSlots.Length, "Weapon slot mismatch");
                });

            }
        }

        [Test]
        public void RemoveWeapon_RemoveWeaponFromSlot()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange 
                var comet = Shuttle.CreateShuttle("Comet");

                //Act
                comet.RemoveWeapon(0);
                Assert.IsNull(comet.WeaponSlots[0]);
                //shipMock.VerifyAll();
            }
        }

        [Test]
        public void CreateShuttle_GivenInvalidShipname_ThrowsException() 
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange

                // Act


                // Assert
                Assert.Multiple(() =>
                {
                    var ex = Assert.Throws<Exception>(() => Shuttle.CreateShuttle("Comet2"),
                        "Expected exception is missing");
                    Assert.AreEqual("Invalid ship name", ex.Message, "Wrong error message");
                });

            }
        }

        [Test]
        public void CalculateTotalDamage_SetTwoWeaponsInDifferentSlots_GivenSummationOfWeaponsDamagePower()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange
                var comet = Shuttle.CreateShuttle("Comet");
                mock.Mock<IWeapon>().Setup(x => x.KineticDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.ThermalDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.ElectromagneticDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.ExplosiveDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.Type).Returns(WeaponType.Small);

                var canon = mock.Create<IWeapon>();
                var canon2 = mock.Create<IWeapon>();

                comet.InstallWeapon(canon, 0);

                // Act
                uint result = comet.CalculateTotalDamage();

                // Assert
                Assert.AreEqual(2000, result);
            }
        }

    }
}