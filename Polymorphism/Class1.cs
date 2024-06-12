namespace Polymorphism
{
    public abstract class DynamicParser
    {
        public void Traverse(Node node)
        {
            if(node is not null)
            {
                DoSomeCustomWork();
                Traverse(node.Left);
                Traverse(node.Right);
            }
        }

        public abstract void DoSomeCustomWork();
    }

    public class MyParserA : DynamicParser
    {
        public override void DoSomeCustomWork()
        {
            var x = 1 + 1;
        }
    }

    public class StaticParser<T> where T : IStaticParser, new()
    {
        private readonly T _worker = new T();

        public void Traverse(Node node)
        {
            if (node is not null)
            {
                _worker.DoSomeCustomWork();
                Traverse(node.Left);
                Traverse(node.Right);
            }
        }
    }

    public interface IStaticParser
    {
        public void DoSomeCustomWork();
    }

    public class StaticParserA : IStaticParser
    {
        public void DoSomeCustomWork()
        {
            var x = 1 + 1;
        }
    }

    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
    }
}