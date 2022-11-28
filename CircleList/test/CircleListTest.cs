using CircleList;
namespace test
{
    public class CircleListTest
    {
        [Fact]
        public void AddAfter_Empty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            CircleList<int> AppendableTestCircleList = new CircleList<int>();
            bool Actual = TestCircleList.AddAfter(TestCircleList.First, AppendableTestCircleList.First);

            Assert.False(Actual);
        }
        [Fact]
        public void AddAfter()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddFirst(1);
            CircleList<int> AppendableTestCircleList = new CircleList<int>();
            AppendableTestCircleList.AddFirst(0);

            TestCircleList.AddAfter(TestCircleList.First, AppendableTestCircleList.First);

            var Expected = TestCircleList.ToArray();
            int[] TempActual = new int[2] { 1, 0 };
            var Actual = TempActual.ToArray();
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void AddBefore_Empty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            CircleList<int> AppendableTestCircleList = new CircleList<int>();
            bool Actual = TestCircleList.AddBefore(TestCircleList.First, AppendableTestCircleList.First);

            Assert.False(Actual);
        }
        [Fact]
        public void AddBefore()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddFirst(1);
            CircleList<int> AppendableTestCircleList = new CircleList<int>();
            AppendableTestCircleList.AddFirst(0);

            TestCircleList.AddBefore(TestCircleList.First, AppendableTestCircleList.First);

            var Expected = TestCircleList.ToArray();
            int[] TempActual = new int[2] { 0, 1 };
            var Actual = TempActual.ToArray();
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void AddFirst_Empty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            CircleList<int> AppendableTestCircleList = new CircleList<int>();

            bool Actual = TestCircleList.AddFirst(AppendableTestCircleList.First);

            Assert.False(Actual);
        }
        [Fact]
        public void AddFirst()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            CircleList<int> AppendableTestCircleList = new CircleList<int>();

            AppendableTestCircleList.AddFirst(5);
            TestCircleList.AddFirst(AppendableTestCircleList.First);

            var Actual = TestCircleList.ToArray();
            int[] TempExpected = new int[1] { 5 };
            var Expected = TempExpected.ToArray();
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void AddLast_Empty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            CircleList<int> AppendableTestCircleList = new CircleList<int>();

            bool Actual = TestCircleList.AddLast(AppendableTestCircleList.First);
            Assert.False(Actual);
        }
        [Fact]
        public void AddLast()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            CircleList<int> AppendableTestCircleList = new CircleList<int>(new List<int>() { 5, 6, 7, 8 });

            CircleListNode<int> CurrentNode = AppendableTestCircleList.First;
            int cnt = 0;
            do
            {
                TestCircleList.AddLast(CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                cnt++;
            } while (CurrentNode != AppendableTestCircleList.First);

            var Actual = TestCircleList.ToArray();
            int[] TempExpected = new int[4] { 5, 6, 7, 8 };
            var Expected = TempExpected.ToArray();
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void Contains_Empty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();

            bool Actual = TestCircleList.Contains(4);

            Assert.False(Actual);
        }
        [Fact]
        public void Contains()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddLast(4);

            bool Actual = TestCircleList.Contains(4);

            Assert.True(Actual);
        }
        [Fact]
        public void Equals_BothEmpty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            CircleList<int> TestCircleList2 = new CircleList<int>();

            bool Actual = TestCircleList.Equals(TestCircleList2);

            Assert.True(Actual);
        }
        [Fact]
        public void Equals_OneEmpty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddFirst(4);
            CircleList<int> TestCircleList2 = new CircleList<int>();

            bool Actual = TestCircleList.Equals(TestCircleList2);

            Assert.False(Actual);
        }
        [Fact]
        public void EqualsTest_BAD()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddLast(4);
            CircleList<int> TestCircleList2 = new CircleList<int>();
            TestCircleList2.AddLast(5);

            bool Actual = TestCircleList.Equals(TestCircleList2);

            Assert.False(Actual);
        }
        [Fact]
        public void EqualsTest_GOOD()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddLast(4);
            CircleList<int> TestCircleList2 = new CircleList<int>();
            TestCircleList2.AddLast(4);

            bool Actual = TestCircleList.Equals(TestCircleList2);

            Assert.True(Actual);
        }
        [Fact]
        public void Find_Empty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();

            Assert.Throws<NullReferenceException>(() => TestCircleList.Find(4).Data);
        }
        [Fact]
        public void Find_NonExistent()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddFirst(5);

            Assert.Throws<NullReferenceException>(() => TestCircleList.Find(4).Data);
        }
        [Fact]
        public void Find()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddLast(4);

            int Actual = TestCircleList.Find(4).Data;

            Assert.Equal(4, Actual);
        }
        [Fact]
        public void FindLast_Empty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();

            Assert.Throws<NullReferenceException>(() => TestCircleList.FindLast(4).Data);
        }
        [Fact]
        public void FindLast_NonExistent()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddFirst(5);

            Assert.Throws<NullReferenceException>(() => TestCircleList.FindLast(4).Data);
        }
        [Fact]
        public void FindLast()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddLast(4);

            int Actual = TestCircleList.FindLast(4).Data;

            Assert.Equal(4, Actual);
        }
        [Fact]
        public void RemoveValue_Empty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();

            bool Actual = TestCircleList.Remove(4);
            Assert.False(Actual);
        }
        [Fact]
        public void RemoveValue_NonExistent()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddLast(4);

            bool Actual = TestCircleList.Remove(5);
            Assert.False(Actual);
        }
        [Fact]
        public void RemoveValue()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddFirst(4);
            TestCircleList.AddLast(5);
            TestCircleList.AddLast(6);
            TestCircleList.AddLast(7);

            TestCircleList.Remove(6);

            var Actual = TestCircleList.ToArray();
            int[] TempExpected = new int[3] { 4, 5, 7 };
            var Expected = TempExpected.ToArray();
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void RemoveNode_Empty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            var randomnode = new CircleListNode<int>(5);

            bool Actual = TestCircleList.Remove(randomnode);
            Assert.False(Actual);
        }
        [Fact]
        public void RemoveNode_NonExistent()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddLast(4);
            var randomnode = new CircleListNode<int>(5);

            bool Actual = TestCircleList.Remove(randomnode);
            Assert.False(Actual);
        }
        [Fact]
        public void RemoveNode()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddFirst(4);
            TestCircleList.AddLast(5);
            TestCircleList.AddLast(6);

            TestCircleList.Remove(TestCircleList.First.Next);

            var Actual = TestCircleList.ToArray();
            int[] TempExpected = new int[2] { 4, 6 };
            var Expected = TempExpected.ToArray();
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void RemoveFirst_Empty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            var randomnode = new CircleListNode<int>(5);

            bool Actual = TestCircleList.RemoveFirst();
            Assert.False(Actual);
        }
        [Fact]
        public void RemoveFirst()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddLast(5);
            TestCircleList.AddLast(4);
            TestCircleList.AddLast(3);

            TestCircleList.RemoveFirst();

            var Actual = TestCircleList.ToArray();
            int[] TempExpected = new int[2] { 4, 3 };
            var Expected = TempExpected.ToArray();
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void RemoveLast_Empty()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            var randomnode = new CircleListNode<int>(5);

            bool Actual = TestCircleList.RemoveLast();
            Assert.False(Actual);
        }
        [Fact]
        public void RemoveLast()
        {
            CircleList<int> TestCircleList = new CircleList<int>();
            TestCircleList.AddLast(4);
            TestCircleList.AddLast(5);

            TestCircleList.RemoveLast();

            var Actual = TestCircleList.ToArray();
            int[] TempExpected = new int[1] { 4 };
            var Expected = TempExpected.ToArray();
            Assert.Equal(Expected, Actual);
        }
    }
}