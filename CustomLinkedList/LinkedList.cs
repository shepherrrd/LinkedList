namespace CustomLinkedList;

public class LinkedList <T>
{
    public Node<T> First { get; private set; }
    public Node<T> Last { get; private set; }
    public int Count { get; private set; }

    public LinkedList()
    {
        First = null;
        Last = null;
    }

    public void AddFirst(Node<T> node)
    {
        if(First == null)
        {
            First = node;
            Last = node;
        }
        else
        {
            node.Next = First;
            First = node;
        }
        Count++;
    }
    public void AddLast(Node<T> node)
    {
        if(First == null)
        {
            First = node;
            Last = node;
        }
        else
        {
            Last.Next = node;
            Last = node;
        }
        Count++;
    }
    public void AddAfter(Node<T> newnode, Node<T> existingNode) {
    
    if(Last == existingNode)
        {
            Last = newnode;
        }
        newnode.Next = existingNode.Next;
        existingNode.Next = newnode;
        Count++;
    }
    public Node<T> Find(T target)
    {
        Node<T> node = First;
        while(node != null && !node.Data!.Equals(target)) {        
        node = node.Next;
        }
        return node;
    }
    public void RemoveFirst()
    {
        if(First is null || Count is 0)
        {
            return;
        }
        First = First.Next;
        Count--;
    }
    public void Remove(Node<T> removedNode)
    {
        if (First is null || Count is 0)
        {
            return;
        }
    }
}