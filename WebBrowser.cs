using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowsing
{
    namespace stack
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
             T Top();           // Return the top item of a stack
        }



        // Tabs
        // Implementation : Linear Array 

        public class Tabs<T> : IStack<T> 
        {
            // Data Members
            private int capacity; // Maximum capacity of the list 
            private int count;    // number of items in the list 
            private T[] A;        // Linear array of items
            private Stack<string> S1;
            private Stack<string> S2;


            //  Constructor 
            // Create an empty list with a capacity of size 
            // Time complexity : 0(1)

            public Tabs(int n) 
            {
                A = new T[n];
                capacity = n;
                count = 0;
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
                    Console.WriteLine (" Stack is full ");
                    /** need a another word for - Environment.exit(1); **/
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
                    Console.WriteLine("Stack is full");
                    /** need a another word for - Environment.exit(1); **/
                }
            }

            //method to Pop an element from stack S1
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
                    Console.WriteLine("Stack empty");
                    /** need a another word for - Environment.exit(1); **/
                }
                 return 0;
            }

            //method to pop an element from stack S2
            public virtual int pop2()
            {
                if (top2 < size) 
                {
                    int x = arr[top2];
                    top2++;
                    return x;
                }
                else 
                {   
                    Console.WriteLine("Stack Underflow");
                    /** need a another word for - Environment.exit(1); **/
                }
                return 0;
            }

        }
        class Program
        {
        static void Main(string[] args)
            {
                Tabs<string> S;
                S = new Tabs<string>(5);

             
                S.push1(5);
                S.push2(10);
                S.push2(15); /// need to change the numbers to letter----------- 
                S.push1(11);
                S.push2(7);
                Console.WriteLine("Popped element from" + " stack1 is " + ts.pop1());
                ts.push2(40);
                Console.WriteLine("Popped element from" + " stack2 is " + ts.pop2());
            }
        }


   /**Browser class contains webpages**/
        class Browser
        {
            private List<Tabs> T;
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




