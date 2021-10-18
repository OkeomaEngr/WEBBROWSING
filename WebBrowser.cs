using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowsing
{
    /**Browser class contains webpages**/
    class Browser
    {
        private List<Tab> T;
        private int currentTab;
       public Browser ( );
       public void Start ( );
       public void Move (int Tab) ;
       public void Close (int Tab) ;
       public void Visit(string S);
       public void Back(); 
       public void Forward();
    }


    namespace DoubleStack
    {
        //common interface for all linear data structures
        public interface IContainer<T>
        {
            void MakeEmpty();
            bool Empty();
            int Size();
        }

        public interface IStack<T> : IContainer<T>
        {
            void Push1(T item); // Place an item on the top of a stack
            void Push2(T item);                       
            void Pop1();   // Remove the top item of a stack
            void Pop2();     
            T Top1(); 
            T Top2();         // Return the top item of a stack
        }



        // Tab
        // Implementation : Linear Array 
        public class Tab<T> : IStack<T> , IContainer<T>
        {
            // Data Members
            private int size; // Maximum capacity of the stack 
            private int count1;    // number of items in the first stack
            private int count2;  // number of items in the second stack
            private T[] A;        // Linear array of items
            private Stack<string> S1; // First stack of tab
            private Stack<string> S2; // second stack of tab


            //  Constructor 
            // Create an empty Tab list with a capacity of size n
            // Time complexity : 0(1)

            public Tab(int n) 
            {
                A = new T[n];
                size = n;
                S1 = 0; 
                S2 = size;        
            }

            public Tab() : this(10) { } //invokes the stack to 10

            //method to push an element to stack S1
            public virtual void Push1( T x )
            {
                //there is at least one empty space for a new element
                if (S1 < S2 - 1) 
                {
                    S1++;
                    A[S1] = x;
                }
                else 
                {
                    Console.WriteLine (" Error, Can't add more webpages");                 
                }
            }

            //method to push an element to stack S2
            public virtual void Push2( T x )
            {
                //there is at least one empty space for a new element
                if (S1 < S2 - 1)
                {
                    S2--;
                    A[S2] = x;
                }
                else
                {
                    Console.WriteLine("Error, Can't add more webpages");
                }
            }

            //method to Pop an element from stack S1
            //method to remove the webpage from the first stack
            public virtual int Pop1()
             {
                if (S1 >= 0) 
                {
                    int x = A[S1];
                    S1--;
                    return x;
                }
                else 
                {
                    Console.WriteLine("Error , no more webpages to remove ");
                }
                 return 0;
            }

            //method to pop an element from stack S2
            //method to remove the webpage from the second stack
            public virtual int Pop2()
            {
                if (S2 < size) 
                {
                    int x = arr[S2];
                    S2++;
                    return x;
                }
                else 
                {   
                    Console.WriteLine("Error , no more webpages to remove");                 
                }
                return 0;
            }


            //method to retrieve a webpage from S1 
            //returns default(T) if the stack is empty
            public T Top1()
            {
                if (!Empty())
                    return A[S1 - 1];
                else
                    return default(T);
            }

            //method to retrieve a webpage from S2 
            //returns default(T) if the stack is empty
            public T Top2()
            {
                if (!Empty())
                    return A[S2 - 1];
                else
                    return default(T);
            }

            // MakeEmpty
            // Resets the stack to empty
            public void MakeEmpty()
            {
                S1 = default(T); // default webpage returned
                S2 = 0;
            }

            // Size
            // Returns the number of items in the stack
            public int Size()
            {   
                return S1;
                return S2; 
            }
        }


        class Program
        {
        static void Main(string[] args)
            {
                Tab<string> S;
                S = new Tab<string>();
             
                S.push1(A);
                S.push2(B);
                S.push2(C); /// need to change the numbers to letter----------- 
                S.push1(D);
                S.push2(E);
                Console.WriteLine("Popped element from" + " stack1 is " + S.pop1());
                S.push2(F);
                Console.WriteLine("Popped element from" + " stack2 is " + S.pop2());
            }
        }


        namespace DoublyLinkedListTab
        {
            class Tab
            {
                public class Node
                {
                    private int _data;
                    public int Data
                    {
                        get { return _data; }
                        set { _data = value; }
                    }

                    private Node _next;
                    public Node Next
                    {
                        get { return _next; }
                        set { _next value; }
                    }

                    private Node _previous;
                    public Node Previous
                    {
                        get { return _previous; }
                        set { _previous value; }
                    }

                    public Node(int data)
                    {
                        Data = data;
                    }


                }

                public class LinkedList : IEnumerable<Node>
                {
                    private Node head;
                    public Node First
                    {
                        get { return head; }
                    }

                    private Node tail;
                    public Node Last
                    {
                        get { return tail; }
                    }

                    public int Length { get; private set; }

                    public IEnumerator GetEnumerator()
                    {
                        Node current = head;
                        while (current != null)
                        {
                            yield return current;
                            current = current.Next;
                        }
                    }

                    IEnumerable IEnumerable.GetEnumerator()
                    {
                        return GetEnumerator();
                    }

                    public IEnumerator GetEnumeratorReverse()
                    {
                        Node current = tail;
                        while (current != null)
                        {
                            yield return current;
                            current = current.Previous;
                        }
                    }

                    IEnumerable IEnumerable.GetEnumeratorReverse()
                    {
                        return GetEnumeratorReverse();
                    }

                    public void Add(int data)
                    {

                        Node newNode = new Node(data);
                        if (tail == null)
                        {
                            head = newNode;
                        }
                        else
                        {//Connect the final nodes
                            newNode.Previous = tail;
                            tail.Next = newNode;
                        }
                        // set new tail
                        tail = newNode;
                        Length++;
                    }

                    public void AddFirst(int data)
                    {
                        Node newNode = new Node(data);
                        newNode.Next = head;

                        if (head == null)
                        {
                            tail = newNode;
                        }
                        else
                        {
                            head.Previous = newNode;
                        }

                        head = newlode;
                        Length++;

                    }

                    public bool Contains(int value)
                    {
                        Node current = head;
                        while (current != null)
                        {
                            if (current.Data == value)
                            {
                                return true;
                            }

                            current = current.net;
                        }

                        return false;
                    }

                    public Node Find(int value)
                    {
                        Node current = head;
                        while (current != null)
                        {
                            if (current.Data == value)
                            {
                                return current;
                            }
                            current = current.Next;
                        }

                        return null;

                    }
                    public bool Remove(int value)
                    {
                        Node current = head;
                        while (current != null)
                        {
                            if (current.Data == value)
                            {
                                // end of the list
                                if (current.Next == null)
                                {
                                    // removing last item in the list
                                    tail = current.Previous;
                                }
                                else
                                {
                                    current.Next.Previous = current.Previous;
                                }
                                //start of the list
                                if (current.Previous == null)
                                {
                                    head = current.Next;
                                }
                                else
                                {
                                    // tie the nodes back together
                                    current.Previous Next = current.Next;
                                }


                                current = null;
                                Length--;
                                return true;
                            }

                            current = current.Next;
                        }

                        return false;
                    }

                    public void RemoveFirst()
                    {
                        if (head != null)
                        {
                            head = head.Next;
                            // empty list
                            if (head == null)
                            {
                                tail = null;
                            }
                            Length--;
                        }
                    }
                    public void RemoveLast()
                    {
                        if (tail != null)
                        {
                            tail = tail.Previous;
                            // empty list
                            if (tail == null)
                            {
                                head = null;
                            }
                            Length--;


                        }
                    }

                }

            }
        }

    }
}




