using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass4
{
    class GenericLinkedList<T>
    {
        //privated variable to hold the current  position of where we are in the linked list
        private GenericNode<T> current;
        //private variable to hold the last position of the linked list
        private GenericNode<T> last;
        //A public property that still points to the head node (The first one in the list)
        public GenericNode<T> Head
        { get; set; }

        //Constructor. It will ser the head to null because there is nothing in this yet
        public GenericLinkedList()
        {
            Head = null;
        }

        public void Add(T content)
        {
            //Make a new node to add to the linked list
            GenericNode<T> node = new GenericNode<T>();
            //Set data to the passed in the content
            node.data = content;

            //This will add the first element to our list
            if (Head == null)
            {
                Head = node;                
            }

            //Not the first node, so set the new node to the current node's next variable
            else
            {
                last.Next = node;
            }
            //Move down the list. Set current to the new node we added
            last = node;
        }

        public bool Delete(int Position)
        {
            //ste current to head. Need to walk through it from the beginning
            current = Head;
            //if position is the very first node int the list
            if (Position == 1)
            {
                //set the head to the next node in the list. This will be the 2nd one. 
                Head = current.Next;
                //Delete the current.next pointer so there is no reference from the current to
                //another node
                current.Next = null;
                //current=null because we want the  garbage collector to come pick it up
                current = null;
                //it was successful so, return true;
                return true;
            }
            //check to make sure that at least a positive number was entered
            //should alseo check to make sure that the position is lesss than the
            //size of the array so that we aren't looking for something that doesn't
            //exist. Adding a size property will be more work.
            //TODO: Add property

            if (Position > 1)
            {
                //Make a temp node that starts at the Head. This way we don't need to actually
                //move the Head pointr. We can just use the temp node
                GenericNode<T> tempNode = Head;
                //set a last node to null. It will be used for the delete
                GenericNode<T> PrevioustempNode = null;
                //Start a counter to know if we have reached the position yet or not.
                int count = 0;

                //while the tempNode is not null, we can continue to walk through the
                //linked list. If it is null, then we have reached the end
                while(tempNode != null)
                {
                    //If the count is the same as the postion entered -1, the we have found
                    //the one we would like to delete
                    if (count == Position - 1)
                    {
                        //Set the previous tempNode's next property to the tempNode's next property
                        //Jumping over the tempnode. The previious node's next will now point 
                        //to the node after the tempnode
                        PrevioustempNode.Next = tempNode.Next;
                        //Remove the next pointer of the tempnode
                        if (tempNode.Next == null)
                        {
                            last = PrevioustempNode;
                        }
                        //Remove the next pointer of the tempnode
                        tempNode.Next = null;
                        //Return True because it was successful
                        return true;
                    }

                    //Increment the counter since we are going to move forward in the list
                    count++;
                    //Set the previous tempNode equal to the tempNode. Now both variables are pointing to
                    //the exact same node
                    PrevioustempNode = tempNode;
                    //Now set the tempNode to tempnode's Next node. This will move tempNode
                    //one more locaton forward in the list
                    tempNode = tempNode.Next;
                }
            }
            //tempNode became null, so apparently we did not find. Return false.
            return false;
        }

        public GenericNode<T> Retrieve(int position)
        {
            //set the temp node to the head so we are at the start of the list
            GenericNode<T> tempNode = Head;
            //A node that will be used toreturn the actual node we aree looking for
            GenericNode<T> returnNode = null;
            //Counter to see where we are in the list
            int count = 0;

            //While our tempnode is not at the end of the list
            while (tempNode != null)
            {
                //If the count matches the position that we are looking for, we have found it
                if (count == position - 1)
                {
                    //Set the returnNode var to the tempnode, which is the oone we were looking for
                    returnNode = tempNode;
                    //Break ou tof the loop. NO need to keep looking
                    break;
                }
                //Increase our counter since we haven't found it yet
                count++;
                //set the tempnod ewe are using for walking to next node in the list
                tempNode = tempNode.Next;
            }

            //return the returnNode
            return returnNode;
        }
    }
}
