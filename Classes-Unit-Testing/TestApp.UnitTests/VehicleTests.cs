using NUnit.Framework;

using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    private Vehicles _vehicle;

    [SetUp]
    public void SetUp()
    {
        this._vehicle = new Vehicles();
    }

    // TODO: finish test
    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        string[] input =
        {
            "Car/Ford/Focus/120",
            "Car/Toyota/Camry/150",
            "Truck/Volvo/VNL/500",
        };
        // Arrange
        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}" +
        $"Toyota: Camry - 150hp{Environment.NewLine}" +
        $"Trucks:{Environment.NewLine}Volvo: VNL - 500kg";

        // Act
        string result = this._vehicle.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        string[] input = { };
        // Arrange
        string expected = $"Cars:{Environment.NewLine}Trucks:";

        // Act
        string result = this._vehicle.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
