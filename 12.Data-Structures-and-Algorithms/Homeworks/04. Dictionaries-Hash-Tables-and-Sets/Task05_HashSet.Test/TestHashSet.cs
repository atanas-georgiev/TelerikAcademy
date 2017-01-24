namespace Task05_HashSet.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Task05_Set;

    [TestClass]
    public class TestHashSet
    {
        [TestMethod]
        public void HashSetShouldCountElementsCOrrectly()
        {
            var set = new HashSet<int>();
            set.Add(0);
            set.Add(1);
            set.Add(2);
            set.Add(3);

            Assert.AreEqual(4, set.Count);
        }

        [TestMethod]
        public void HashSetShouldFindElementsCorrectly()
        {
            var set = new HashSet<int>();
            set.Add(0);
            set.Add(1);
            set.Add(2);
            set.Add(3);

            Assert.IsTrue(set.Find(0));
            Assert.IsTrue(set.Find(1));
            Assert.IsTrue(set.Find(2));
            Assert.IsTrue(set.Find(3));
            Assert.IsFalse(set.Find(4));
        }

        [TestMethod]
        public void HashSetShouldRemoveElementCorrectly()
        {
            var set = new HashSet<int>();
            set.Add(0);
            set.Remove(0);            

            Assert.IsFalse(set.Find(0));
            Assert.AreEqual(0, set.Count);
        }

        [TestMethod]
        public void HashSetShouldClearElementCorrectly()
        {
            var set = new HashSet<int>();
            set.Add(0);
            set.Clear();

            Assert.IsFalse(set.Find(0));
            Assert.AreEqual(0, set.Count);
        }

        [TestMethod]
        public void HashSetShouldIntersectElementCorrectly()
        {
            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);

            set2.Add(1);
            set2.Add(5);
            set2.Add(6);

            var intersect = set1.Intersect(set2);

            Assert.IsTrue(intersect.Find(1));
            Assert.AreEqual(1, intersect.Count);
        }

        [TestMethod]
        public void HashSetShouldUnionElementCorrectly()
        {
            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();
            set1.Add(1);
            set1.Add(2);

            set2.Add(2);
            set2.Add(3);
            set2.Add(4);            

            var union = set1.Union(set2);

            Assert.IsTrue(union.Find(1));
            Assert.IsTrue(union.Find(2));
            Assert.IsTrue(union.Find(3));
            Assert.IsTrue(union.Find(4));
            Assert.AreEqual(4, union.Count);
        }
    }
}
