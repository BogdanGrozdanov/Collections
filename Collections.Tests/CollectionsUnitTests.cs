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
            Collection<int> nums = new Collection<int>(7);
            Assert.That(nums.ToString(), Is.EqualTo("[7]"));
        }

        [Test]
        public void Test_Collection_ConstructorMultipleItems()
        {
            Collection<int> nums = new Collection<int>(7, 8, 9);
            Assert.That(nums.ToString(), Is.EqualTo("[7, 8, 9]"));
        }

        [Test]
        public void Test_Collection_Add()
        {
            Collection<int> nums = new Collection<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            Assert.That(nums.ToString(), Is.EqualTo("[1, 2, 3]"));
        }

        [Test]
        public void Test_Collection_AddWithGrow()
        {
            Collection<int> nums = new Collection<int>();
            var oldCapasity = nums.Capacity;

            for (int i = 0; i <= oldCapasity; i++)
            {
                nums.Add(i);
            }
            var newCapacity = nums.Capacity;

            Assert.IsTrue(newCapacity > oldCapasity, "Collection not grow - Capacity property");
        }

        [Test]
        public void Test_Collection_AddRange()
        {
            Collection<int> nums = new Collection<int>(1, 2, 3);
            nums.AddRange(4, 5, 6);
            var expected = nums.ToString();
            Assert.That(expected, Is.EqualTo("[1, 2, 3, 4, 5, 6]"));
        }
    }
}