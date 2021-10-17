using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowsing
{
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
            void Push(T item); // Place an item on the top of a stack
            void Pop();        // Remove the top item of a stack
             T Top();          // Return the top item of a stack
        }



        // Tabs
        // Implementation : Linear Array 

        public class Tab<T> : IStack<T> 
        {
            // Data Members
            private int capacity; // Maximum capacity of the list 
            private int count;    // number of items in the list 
            private T[] A;        // Linear array of items
            private Stack<string> S1; // First stack of tabs
            private Stack<string> S2; // second stack of tabs


            //  Constructor 
            // Create an empty Tab list with a capacity of size n
            // Time complexity : 0(1)

            public Tab(int n) 
            {
                A = new T[n];
                size = n;
                S1 = -1; 
                S2 = size;        
            }

            //method to push an element to stack S1
            public virtual void push1( T x )
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
            public virtual void push2( T x )
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
            public virtual int pop1()
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
            public virtual int pop2()
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
                S = new Tab<string>(5);

             
                S.push1(A);
                S.push2(B);
                S.push2(C); /// need to change the numbers to letter----------- 
                S.push1(D);
                S.push2(E);
                Console.WriteLine("Popped element from" + " stack1 is " + ts.pop1());
                ts.push2(F);
                Console.WriteLine("Popped element from" + " stack2 is " + ts.pop2());
            }
        }


   /**Browser class contains webpages**/
        class Browser
        {
            private List<Tab> T;
            private int currentTab;
        }

        //list with header node ------------------------------------ Amber do you need this ?
        public class List<T> : IList<T> 
        {
        //data members
        private Node<T> head ; //reference to the head of the list 
        private int count;  //number of items in the list
        //Constructor
        //creates an empty list with a header node
        public List()
        {
            head = new Node<T>();
            count = 0;
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
}




