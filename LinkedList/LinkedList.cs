public class Node
{
    public Node next;
    public Object data;
}

public class LinkedList
{
    private Node head;

    public void printAllNodes()
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }

    public void AddToHead(Object data)
    {
        Node toAdd = new Node();

        toAdd.data = data;
        toAdd.next = head;

        head = toAdd;
    }

    public void AddToEnd(Object data)
    {
        if (head == null)
        {
            head = new Node();

            head.data = data;
            head.next = null;
        }
        else
        {
            Node toAdd = new Node();
            toAdd.data = data;

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = toAdd;
        }
    }

	public void Remove(Node nodeToRemove)
	{
		Node current = head;
		while (current.next != nodeToRemove)
		{
			current = current.next;
		}
		current = nodeToRemove.next;
		nodeToRemove = null;
	}

	public bool Search(Object data)
	{
		if(head == null)
		{
			return false;
		}
		else {
			Node current = head;
			while (current.next != null)
            {
				if(current.data == data)
				{
					return true;
				}
                current = current.next;
            }
		}
		return false;
	}

	public int Count()
	{
		var count = 0;
		if (head == null) {
			break;
		}
		else {
			Node current = head;
			count = 1;
			while (current.next != null)
            {
				count += 1;
                current = current.next;
            }
		}
		return count;
	}

	public void Reverse()
	{
		if(head == null || head.next == null) {
			break;
		}
		else {
			Node current = head;
			Node previous = null;
			while(current != null)
			{
				Node temp = current.next;
				current.next = previous;
				previous = current;
				current = temp;
			}
			head = previous;
		}
	}
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Add To Head:");
        LinkedList awesomeList = new LinkedList();

        awesomeList.AddToHead("Hello");
        awesomeList.AddToHead("I'm");
        awesomeList.AddToHead("Batman");
        awesomeList.printAllNodes();

        Console.WriteLine();

        Console.WriteLine("Add To End:");
        LinkedList lameList = new LinkedList();

        lameList.AddToEnd("Morning");
        lameList.AddToEnd("Silly");
        lameList.AddToEnd("Head");
        lameList.printAllNodes();

        Console.ReadLine();
    }
}
