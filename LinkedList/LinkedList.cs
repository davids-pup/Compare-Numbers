using System;
using System.Linq;
using System.Collections.Generic;

public class Node
{
    public Node next;
    public Object data;
}

public class LinkedList
{
    private Node head;
    
    LinkedList<int> numbers = new LinkedList<int>();
    
    public LinkedList(LinkedList<int> _numbers)
    {
        this.numbers = _numbers;
    }

    public void PrintAllNodes()
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }
    
    public void AddToHead(LinkedList<int> numbers, int data)
    {
        numbers.AddFirst(data);
    }
    
    public void AddToEnd(int data)
    {
        numbers.AddLast(data);
    }

	public void Remove(int data)
	{
        numbers.Remove(data);
	}
    
    public bool Search(int data)
	{
		if(numbers.Find(data) != null)
        {
            return true;
        }
        else {
            return false;
        }
	}
    
    public int Count()
	{
		return numbers.Count;
	}
    
    public void Reverse()
	{
        numbers.Reverse<int>();
	}


    static void Main(string[] args)
    {   
        Console.WriteLine("Add To Head:");
        LinkedList<int> awesomeList = new LinkedList<int>();

        awesomeList.AddToHead(12);
        awesomeList.AddToHead(99);
        awesomeList.AddToHead(86);

        awesomeList.TestFunctions(awesomeList);

        Console.WriteLine("Add To End:");
        LinkedList<int> lameList = new LinkedList<int>();

        lameList.AddToEnd(13);
        lameList.AddToEnd(42);
        lameList.AddToEnd(71);

        lameList.TestFunctions(lameList);

        Console.WriteLine("Finished Testing");

        Console.ReadLine();
    }
    
    
    public void TestFunctions(LinkedList<int> list)
    {
        // put tests here
        list.PrintAllNodes();
        Console.WriteLine();

        var numberOfNodes = list.Count();
        Console.WriteLine("Number of nodes in {0} is: {1}", list, numberOfNodes);

        var dataToFind = 7;
        if (list.Search(dataToFind))
        {
            Console.WriteLine("Found {0} in {1}", dataToFind, list);
        }
        else
        {
            Console.WriteLine("Couldn't find {0} in {1}", dataToFind, list);
        }

        list.Remove(7);
        dataToFind = 7;
        if (list.Search(dataToFind))
        {
            Console.WriteLine("Found {0} in {1}", dataToFind, list);
        }
        else
        {
            Console.WriteLine("Couldn't find {0} in {1}", dataToFind, list);
        }

        list.Reverse();

        numberOfNodes = list.Count();
        Console.WriteLine("Number of nodes in {0} is: {1}", list, numberOfNodes);

        list.PrintAllNodes();
    }
}
