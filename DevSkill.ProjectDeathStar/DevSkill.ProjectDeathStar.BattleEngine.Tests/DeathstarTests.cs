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
    public class DeathstarTests
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
                var astero = Deathstar.CreateDeathstar("Astero");
                var doomsday = Weapon.CreateWeapon("DoomsdayBeam",WeaponType.Doomsday); 

                //Act
                astero.InstallWeapon(doomsday, 2);
                Assert.AreEqual(doomsday, astero.WeaponSlots[2]);
            }
        }

        [Test]
        public void CreateDeathstar_GivenProperNameOfShip_CreatesCorrectShip() 
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange

                // Act
                var astero = Deathstar.CreateDeathstar("Astero");

                // Assert
                Assert.Multiple(() =>
                {
                    Assert.AreEqual("Astero", astero.Name, "Name mismatch.");
                    Assert.AreEqual(3, astero.WeaponSlots.Length, "Weapon slot mismatch");
                });

            }
        }

        [Test]
        public void RemoveWeapon_RemoveWeaponFromSlot()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange 
                var astero = Deathstar.CreateDeathstar("Astero");

                //Act
                astero.RemoveWeapon(2);
                Assert.IsNull(astero.WeaponSlots[2]);
                //shipMock.VerifyAll();
            }
        }

        [Test]
        public void CreateDeathstar_GivenInvalidShipname_ThrowsException() 
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange

                // Act


                // Assert
                Assert.Multiple(() =>
                {
                    var ex = Assert.Throws<Exception>(() => Deathstar.CreateDeathstar("Astero2"),
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
                var astero = Deathstar.CreateDeathstar("Astero");
                mock.Mock<IWeapon>().Setup(x => x.KineticDamage).Returns(5000);
                mock.Mock<IWeapon>().Setup(x => x.ThermalDamage).Returns(5000);
                mock.Mock<IWeapon>().Setup(x => x.ElectromagneticDamage).Returns(5000);
                mock.Mock<IWeapon>().Setup(x => x.ExplosiveDamage).Returns(5000);
                mock.Mock<IWeapon>().Setup(x => x.Type).Returns(WeaponType.Doomsday);

                var doomsdayBeam = mock.Create<IWeapon>();
                var doomsdayBeam2 = mock.Create<IWeapon>();

                astero.InstallWeapon(doomsdayBeam, 1);
                astero.InstallWeapon(doomsdayBeam2, 2); 

                // Act
                uint result = astero.CalculateTotalDamage();

                // Assert
                Assert.AreEqual(40000, result);
            }
        }

    }
}