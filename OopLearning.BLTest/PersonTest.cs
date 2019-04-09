using OopLearning.BL;
using System;
using System.Collections.Generic;
using Xunit;

namespace OopLearning.BLTest
{
    public class PersonTest
    {
        [Fact]
        public void ValidateName_ValidValuesShouldReturnTrue()
        {
            string validName = "Maren Gjesing";
            (bool isValid, string errMsg) = Person.ValidateName(validName);
            Assert.True(isValid, $"{validName} should be valid");
        }
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("\n")]
        [InlineData("a")]
        [InlineData("aaaaa")]
        public void ValidateName_InvalidValuesShouldReturnFalse(string invalidName)
        {
            (bool isValid, string errMsg) = Person.ValidateName(invalidName);
            Assert.False(isValid, $"{invalidName} should not be valid");
        }
        [Fact]
        public void SetName_ValidValuesShouldNotBeChanged()
        {
            string expectedName = "Maren Gjesing";
            Person person = new Person
            {
                Name = expectedName
            };
            string actualName = person.Name;
            Assert.Equal(expectedName, actualName);
        }
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("\n")]
        [InlineData("a")]
        [InlineData("aaaaa")]
        public void SetName_InvalidValuesShouldCastArgumentException(string invalidName)
        {
            Person person = new Person();
            Assert.Throws<ArgumentException>(() => person.Name = invalidName);
        }
        [Fact]
        public void GetBirthday_CprAlreadySetShouldReturnCorrectBirthday()
        {
            DateTime expectedBirthday = new DateTime(2003, 2, 1);
            Person person = new Person()
            {
                Cpr = "0102030405"
            };
            DateTime actualBirthday = person.Birthday;
            Assert.Equal(expectedBirthday, actualBirthday);
        }
        [Fact]
        public void GetBirthday_CprNotSetShouldCastException()
        {
            Person person = new Person();
            Assert.Throws<InvalidOperationException>(() => person.Birthday);
        }
        [Fact]
        public void ValidateCpr_ValidValuesShouldReturnTrue()
        {
            string validCpr = "0102030405";
            (bool isValid, string errMsg) = Person.ValidateCpr(validCpr);
            Assert.True(isValid, $"{validCpr} should be valid");
        }
        [Theory]
        [InlineData(null)]
        [InlineData("1")]
        [InlineData("010101010101")]
        [InlineData("9999999999")]
        [InlineData("2002200000")]
        public void ValidateCpr_InvalidValuesShouldReturnFalse(string invalidCpr)
        {
            (bool isValid, string errMsg) = Person.ValidateCpr(invalidCpr);
            Assert.False(isValid, $"{invalidCpr} should not be valid");
        }
        [Fact]
        public void SetCpr_ValidValuesShouldNotBeChanged()
        {
            string expectedCpr = "0102030405";
            Person person = new Person
            {
                Cpr = expectedCpr
            };
            string actualCpr = person.Cpr;
            Assert.Equal(expectedCpr, actualCpr);
        }
        [Theory]
        [InlineData(null)]
        [InlineData("1")]
        [InlineData("010101010101")]
        [InlineData("9999999999")]
        [InlineData("2002200000")]
        public void SetCpr_InvalidValuesShouldCastArgumentException(string invalidCpr)
        {
            Person person = new Person();
            Assert.Throws<ArgumentException>(() => person.Cpr = invalidCpr);
        }
        [Fact]
        public void GetIsWoman_CprEvenShouldReturnTrue()
        {
            string evenCpr = "0202020202";
            Person person = new Person
            {
                Cpr = evenCpr
            };
            Assert.True(person.IsWoman, $"{evenCpr} should return true");
        }
        [Fact]
        public void GetIsWoman_CprOddShouldReturnFalse()
        {
            string oddCpr = "0101010101";
            Person person = new Person
            {
                Cpr = oddCpr
            };
            Assert.False(person.IsWoman, $"{oddCpr} should return false");
        }
        [Fact]
        public void GetIsWoman_CprNotSetShouldCastException()
        {
            Person person = new Person();
            Assert.Throws<InvalidOperationException>(() => person.IsWoman);
        }
        [Fact]
        public void CreateIdentifier_CprShouldBeReturned()
        {
            Person person = new Person()
            {
                Cpr = "0101010101"
            };
            string expecedCpr = person.Cpr;
            string actualCpr = person.CreateIdentifier();
            Assert.Equal(expecedCpr, actualCpr);
        }
        [Fact]
        public void Sort_ListShouldBeSortedByNameAndBirthday()
        {
            Person person1 = new Person() { Name = "b b", Cpr = "0202020202" };
            Person person2 = new Person() { Name = "a a", Cpr = "0202020202" };
            Person person3 = new Person() { Name = "b b", Cpr = "0101010101" };
            List<Person> actualPeople = new List<Person>() { person1, person2, person3 };
            actualPeople.Sort();
            List<Person> expectedPeople = new List<Person>() { person2, person3, person1 };
            Assert.Equal(expectedPeople, actualPeople);
        }
    }
}
