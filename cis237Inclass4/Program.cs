using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            //define a new linked list to use
            MyLinkedList mylinkedlist = new MyLinkedList();

            //add a bunch of stuff in it
            mylinkedlist.Add("first");
            mylinkedlist.Add("second");
            mylinkedlist.Add("third");
            mylinkedlist.Add("fourth");

            //loop through with this differently looking for loop to output
            //In here, the first part is the initializaton: setting x to the head
            //the second part is the test: if x !=null keep going
            //the last part is: set the current x to x's next pointer.(the next in the list)
            for (Node x = mylinkedlist.Head; x!=null; x = x.Next)
            {
                Console.WriteLine(x.data);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Print out the 2nd one
            Node nodeINeed = mylinkedlist.Retrieve(2);
            Console.WriteLine(nodeINeed.data);

            //Print out the 2nd one again in one statement
            Console.WriteLine(mylinkedlist.Retrieve(2).data);

            Console.WriteLine();
            Console.WriteLine();

            //delete the 2nd element in the list
            mylinkedlist.Delete(2);
            //delete the new 2nd element in the list. Was the 3rd element before the previous delete
            mylinkedlist.Delete(2);

            for (Node x = mylinkedlist.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.data);
            }

            Console.WriteLine();
            Console.WriteLine();
            //Add two new ones in the list
            mylinkedlist.Add("fifth");
            mylinkedlist.Add("sixth");

            //Print the list one last time
            for (Node x = mylinkedlist.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.data);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");
            //A generic linked list that sends in the type that we would like to use
            //This one will behave exactly like the one used above since it is taking a string
            GenericLinkedList<string> myGenericLinkedList = new GenericLinkedList<string>();
            
            //some other linked lists thta can use the generic one. One of them is of type integer, 
            //and the other is of type object
            GenericLinkedList<int> myOtherGenericLinkedList = new GenericLinkedList<int>();
            GenericLinkedList<object> myObjectLinkedList = new GenericLinkedList<object>();

            Console.WriteLine();
            Console.WriteLine();

            //use the generic string one to do the same work as above
            //add a bunch of stuff in it
            mylinkedlist.Add("first");
            mylinkedlist.Add("second");
            mylinkedlist.Add("third");
            mylinkedlist.Add("fourth");

            //loop through with this differently looking for loop to output
            //In here, the first part is the initializaton: setting x to the head
            //the second part is the test: if x !=null keep going
            //the last part is: set the current x to x's next pointer.(the next in the list)
            for (Node x = mylinkedlist.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.data);
            }



            Console.ReadLine();
        }
    }
}
