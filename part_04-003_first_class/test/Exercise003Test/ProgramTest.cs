namespace ProgramTests
{
    using System;
    using Xunit;
    using Exercise003;
    using TestMyCode.CSharp.API.Attributes;
    using System.Reflection;
    [Points("4-3")]
    public partial class ProgramTest
    {

        [Fact]
        public void TestDogType()
        {
            Dog dog = new Dog();

            // Assert
            Assert.Equal(typeof(Dog), dog.GetType());
        }

        [Fact]
        public void TestDogAttributes()
        {
            Dog dog = new Dog();

            Type typ = typeof(Dog);
            FieldInfo name = typ.GetField("name", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            FieldInfo breed = typ.GetField("breed", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            FieldInfo age = typ.GetField("age", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            string actualName = name.GetValue(dog) as string;
            string actualBreed = breed.GetValue(dog) as string;
            var actualAge = age.GetValue(dog);
            // Assert
            Assert.True(String.IsNullOrEmpty(actualName));
            Assert.True(String.IsNullOrEmpty(actualBreed));
            Assert.Equal(0, actualAge);
        }

    }
}
