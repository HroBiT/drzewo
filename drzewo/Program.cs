using System;
using System.Collections.Generic;

public class Heap
{
    private List<int> array;

    public Heap()
    {
        array = new List<int>();
    }

    private void HeapifyUp(int index)
    {
        int parent = (index - 1) / 2;
        while (index > 0 && array[parent] < array[index])
        {
            Swap(parent, index);
            index = parent;
            parent = (index - 1) / 2;
        }
    }

    private void Swap(int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    public void Insert(int value)
    {
        array.Add(value);
        HeapifyUp(array.Count - 1);
    }

    public void Print()
    {
        Console.WriteLine("Heap from 10 to 0:");
        for (int i = array.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Heap heap = new Heap();
        heap.Insert(10);
        heap.Insert(8);
        heap.Insert(9);
        heap.Insert(7);
        heap.Insert(5);
        heap.Insert(1);
        heap.Insert(3);
        heap.Insert(6);
        heap.Insert(4);
        heap.Insert(0);
        heap.Insert(2);

        heap.Print();
    }
}
