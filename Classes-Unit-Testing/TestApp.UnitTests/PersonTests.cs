using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PersonTests
{
    private Person _person;
    [SetUp]
    public void SetUp()
    {
        this._person = new Person();
    }

    // TODO: finish test
    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };
        List<Person> expectedPeopleList = new()
        {
            new Person
            {
                Name = "Alice",
                Id = "A001",
                Age = 35,
            },
            new Person
            { 
                Name = "Bob",
                Id = "B002",
                Age = 30
            }
        };

        // Act
        List<Person> resultPeopleList = this._person.AddPeople(peopleData);

        // Assert
       Assert.That(resultPeopleList, Has.Count.EqualTo(2));
        for (int i = 0; i < resultPeopleList.Count; i++)
        {
            Assert.That(resultPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
            Assert.That(resultPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
            Assert.That(resultPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        }
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
        List<Person> people = new()
        {
            new Person
            {
                Name = "John",
                Id = "10",
                Age = 22
            },
            new Person
            {
                Name = "Johnny",
                Id = "100",
                Age = 222
            },
            new Person
            {
                Name = "Ivan",
                Id = "101",
                Age = 32
            },
            new Person
            {
                Name = "Sins",
                Id = "1",
                Age = 52
            }
        };
        string expected = $"John with ID: 10 is 22 years old." +
            $"{Environment.NewLine}Ivan with ID: 101 is 32 years old." +
            $"{Environment.NewLine}Sins with ID: 1 is 52 years old." +
            $"{Environment.NewLine}Johnny with ID: 100 is 222 years old.";
            
        // Act
        string actual = this._person.GetByAgeAscending(people);
        // Assert 
        Assert.That(actual, Is.EqualTo(expected));
    }
}
