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
    public class BattleshipTests   
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
                var reven = Battleship.CreateBattleship("Reven");  
                var cannon = Weapon.CreateWeapon("Cannon", WeaponType.Large);

                //Act
                reven.InstallWeapon(cannon, 3);
                Assert.AreEqual(cannon, reven.WeaponSlots[3]);    
            }
        }

        [Test]
        public void CreateBattleship_GivenProperNameOfShip_CreatesCorrectShip()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange

                // Act
                var raven = Battleship.CreateBattleship("Reven");

                // Assert
                Assert.Multiple(() =>
                {
                    Assert.AreEqual("Reven", raven.Name, "Name mismatch.");
                    Assert.AreEqual(8, raven.WeaponSlots.Length, "Weapon slot mismatch");
                });

            }
        }

       [Test]
        public void RemoveWeapon_RemoveWeaponFromSlot() 
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange 
                var reven = Battleship.CreateBattleship("Reven");

                //Act
                reven.RemoveWeapon(3);  
                Assert.IsNull(reven.WeaponSlots[3]);
                //shipMock.VerifyAll();
            }
        }

        [Test]
        public void CreateBattleship_GivenInvalidShipname_ThrowsException()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange

                // Act


                // Assert
                Assert.Multiple(() =>
                {
                    var ex = Assert.Throws<Exception>(() => Battleship.CreateBattleship("Reven2"),
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
                var reven = Battleship.CreateBattleship("Reven");
                mock.Mock<IWeapon>().Setup(x => x.KineticDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.ThermalDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.ElectromagneticDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.ExplosiveDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.Type).Returns(WeaponType.Large);

                var canon = mock.Create<IWeapon>();
                var canon2 = mock.Create<IWeapon>();

                reven.InstallWeapon(canon, 3);
                reven.InstallWeapon(canon2, 4);

                // Act
                uint result = reven.CalculateTotalDamage();

                // Assert
                Assert.AreEqual(4000, result);
            }
        }

    }
}