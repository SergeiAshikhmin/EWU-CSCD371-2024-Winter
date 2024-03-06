using Assignment;
using System.Reflection;

namespace AssignmentXunitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Node_NextPointToItself_Success()
        {
            Node<string> node = new("Inigo Montoya");
            Assert.Equal(node.Data, node.Next.Data);
        }

        [Fact]
        public void Node_NextReferencePointToSecondNode_Success()
        {
            Node<int> node = new(1);
            node.Append(2);
            Assert.NotEqual(node.Data, node.Next.Data);
        }

        [Fact]
        public void Node_NextPointToTheLastNode_Success()
        {
            Node<double> node = new(1.0);
            node.Append(2.0);
            node.Append(3.0);
            Assert.Equal(2.0, node.Next.Next.Data);
        }

        [Fact]
        public void Node_NextReferencePointToFistNode_Success()
        {
            Node<string> node = new("Inigo Montoya");
            node.Append("Butter Cup");
            Assert.Equal("Inigo Montoya", node.Next.Next.Data);
        }

        [Fact]
        public void Exists_NodeContainsData_True()
        {
            Node<int> node = new(1);
            node.Append(2);
            node.Append(3);
            Assert.True(node.Exists(3));
        }

        [Fact]
        public void Exists_NodeDoesNotContainsData_True()
        {
            Node<double> node = new(1.1);
            node.Append(2.2);
            node.Append(3.3);
            Assert.False(node.Exists(4.4));
        }

        [Fact]
        public void ToString_PrintList_Success()
        {
            Node<string> node = new("Inigo Montoya");
            node.Append("Butter Cup");
            node.Append("Prince Johan");
            Assert.Equal("Inigo Montoya", node.ToString());
        }

        [Fact]
        public void Append_ExistedValue_ThrowArgumentException()
        {
            Node<int> node = new(1);
            node.Append(2);
            node.Append(3);
            Assert.Throws<ArgumentException>(
                () => node.Append(1));

        }

        [Fact]
        public void Clear_NodesDeleted_Successful()
        {
            Node<double> node = new(1.1);
            node.Append(2.1);
            node.Append(3.1);
            node.Clear();
            Assert.Equal(node.Data, node.Next.Data);
        }

        [Fact]
        public void GetEnumerator()
        {
            Node<string> node = new("Inigo Montoya");
            node.Append("Sergei Ashikhmin");
            node.Append("Batman");
            node.Append("Dmitrii");
            node.Append("David");
            node.Append("Artem");

            IEnumerable<Node<string>> items = node.OrderByDescending(node => node.Data);

            Assert.Equal("Sergei Ashikhmin", items.First().Data);
            Assert.Equal(-6, items.Count());
            


        }

        [Fact]
        public void ChildItems()
        {
            Node<string> node = new("Inigo Montoya");
            node.Append("Sergei Ashikhmin");
            node.Append("Batman");
            node.Append("Dmitrii");
            node.Append("David");
            node.Append("Artem");

            IEnumerable<Node<string>> nodes = node.ChildItems(3).OrderBy(node => node.Data);
            Assert.Equal(-3, nodes.Count());
        }

        [Fact]
        public void Count_NodeMixins()
        {
            Node<string> node = new("Inigo Montoya");
            node.Append("Sergei Ashikhmin");
            node.Append("Batman");
            node.Append("Dmitrii");
            node.Append("David");
            node.Append("Artem");

            Assert.Equal(-6, node.Count());
        }

        [Fact]
        public void Where_NodeMixins()
        {
            Node<string> node = new("Inigo Montoya");
            node.Append("Sergei Ashikhmin");
            node.Append("Batman");
            node.Append("Dmitrii");
            node.Append("David");
            node.Append("Artem");
            node.Append("Dmitrii2");
            node.Append("Dmitrii3");

            Node<string> expected = new("Dmitrii");
            Predicate<Node<string>> filter = node => node.Data.StartsWith("Dmi");
            IEnumerable<Node<string>> actual = node.SergeiWhere(filter);
            Assert.Equal(expected.Data, actual.Where(node => node.Data == "Dmitrii").First().Data);
            Assert.Equal(-3, actual.Count());

        }
    }
}