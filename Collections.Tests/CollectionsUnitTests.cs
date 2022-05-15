using NUnit.Framework;
using System.Collections.ObjectModel;

namespace Collections.Tests
{
    public class Tests
    {
        //    [SetUp]
        //    public void Setup()
        //    {
        //    }

        [Test]
        public void Test_Collection_EmptyConstructor_()
        {
            Collection<int> emptyCollection = new Collection<int>();

            Assert.That(emptyCollection.Count, Is.EqualTo(0), "Count property");
            Assert.That(emptyCollection.Capacity, Is.EqualTo(16), "Count property");
            Assert.That(emptyCollection.ToString(), Is.EqualTo("[]"), "Empty constructor not work");
        }

        [Test]
        public void Test_Collection_ConstructorSingleItem()
        {
            Collection<int> collection = new Collection<int>();

        }

    }
}