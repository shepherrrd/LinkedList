namespace LinkedList1;
using CustomLinkedList;
class Program
{
    static void Main(string[] args)
    {
        CustomLinkedList<string> list = new CustomLinkedList<string>();
        Node<string> a = new Node<string>("A");
        Node<string> b = new Node<string>("B");
        Node<string> c = new Node<string>("C");
        Node<string> d = new Node<string>("D");
        list.AddFirst(a);
        list.AddFirst(b);
        list.AddFirst(c);
        list.AddFirst(d);
        list.Traverse();
    }
}