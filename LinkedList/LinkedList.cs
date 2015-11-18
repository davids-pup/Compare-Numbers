using System;

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

	public void Remove(Object data)
	{
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            if (head.data == data)
            {
                head = head.next;
                Console.WriteLine("{0} has been removed from list", data);
            }
            else
            {
                Node current = head;
                Node previous = null;
                while (current.data != data)
                {
                    previous = current;
                    current = current.next;
                }
                previous.next = current.next;
                current = null;
                Console.WriteLine("{0} has been removed from list", data);
            }
        }
	}

	public bool Search(Object data)
	{
		if(head == null)
		{
            Console.WriteLine("Head of list is null");
			return false;
		}
		else {
			Node current = head;
			while (current != null)
            {
                Console.WriteLine("Comparing {0} with {1}", current.data, data);
				if(String.Equals(current.data, data))
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
			return count;
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
        if (!(head == null || head.next == null))
        {
            Node current = head;
            Node previous = null;
            while (current != null)
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

        awesomeList.AddToHead("Batman");
        awesomeList.AddToHead("I'm");
        awesomeList.AddToHead("Hello");
        awesomeList.printAllNodes();

        Console.WriteLine();

        var numberOfNodes = awesomeList.Count();
        Console.WriteLine("Number of nodes in awesomeList is: {0}", numberOfNodes);

        var dataToFind = "Hello";
        if (awesomeList.Search(dataToFind))
        {
            Console.WriteLine("Found {0} in awesomeList", dataToFind);
        }
        else
        {
            Console.WriteLine("Couldn't find {0} in awesomeList", dataToFind);
        }

        awesomeList.Remove("Hello");
        dataToFind = "Hello";
        if (awesomeList.Search(dataToFind))
        {
            Console.WriteLine("Found {0} in awesomeList", dataToFind);
        }
        else
        {
            Console.WriteLine("Couldn't find {0} in awesomeList", dataToFind);
        }

        Console.WriteLine("Add To End:");
        LinkedList lameList = new LinkedList();

        lameList.AddToEnd("Morning");
        lameList.AddToEnd("Silly");
        lameList.AddToEnd("Head");
        lameList.printAllNodes();

        lameList.Reverse();
        lameList.printAllNodes();

        Console.ReadLine();
    }
}
