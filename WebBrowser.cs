using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowsing
{
    namespace TwostackTab
    {
        public class Tab
        {
            private Stack<string> S1;
            private Stack<string> S2;
        }

        public interface IContainer<T>
        {
            void MakeEmpty();
            bool Empty();
            int Size();
        }

        public interface ITwostackTab<T> : IContainer<T>
        {
            void Push(T item);
            void Pop();
            T Top();
        }





        public class TwostackTab<T> : ITwostackTab<T> // implementation Array
        {
            private int capacity;
            private int count;
            private T[] A;

            public TwostackTab<T>(int size) //Constructor
            {
                capacity = size;
                A = new T[size];
                count = 0;
                stack = -1; /// why is this -1
                stack = size;
            }


    }






    namespace DoublyLinkedListTab
    {
        class Tab
        {
            private class Node
            {

            }

        }
    }
}
public class Node<T>
{
    public T Item { get; set; }     // Read/write property
    public Node<T> Next { get; set; }     // Read/write property
    public Node<T> Prev { get; set; }     // Read/write property

    // Parameterless Constructor
    // Creates a single node initialized to default data members
    // Time complexity:  O(1)

    public Node()
    {
        Next = null;
    }

    // Constructor
    // Creates a single node initialized to the two parameters
    // Time complexity:  O(1)

    public Node(T item, Node<T> next = null, Node<T> prev = null)
    {
        Item = item;
        Next = next;
        Prev = prev;
    }
}
