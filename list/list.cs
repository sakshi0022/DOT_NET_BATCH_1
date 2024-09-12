// using System;

// namespace DataStructure
// {
//     internal class List
//     {
//         private Node headNode;

//         public List()
//         {
//             headNode = new Node();
//             headNode.Next = headNode;
//             headNode.Prev = headNode;
//         }
//         public void InsertAtBegin(int data)
//         {
//             Node newNode = new Node(data);
//             GenericInsert(headNode,newNode,headNode.Next);
//         }
//         public void InsertAtEnd(int data)
//         {
//             Node newNode = new Node(data);
//             GenericInsert(headNode.Prev,newNode,headNode);
//         }
//         public void InsertAtPos(int data,int pos)
//         {
//             Node newNode = new Node(data);
//             int counter = 0 ;
//             Node tempNode;

//             tempNode = headNode.Next;
//         }

        
//         GenericInsert(temp.Prev,newNode,temp);
//         }
//         public int removeAtBegin()
//         {
//             int removeData;
//             removeData = headNode.Next.Data;
//             GenericRemove(headNode.Next);
//             return removeData;
//         }
//         public static void GenericInsert(Node start,Node mid,Node end)
//         {
//             start.Next = mid;
//             mid.Next = end;
//             end.Prev = mid;
//             mid.Prev = start;
//         }
//         public static void  Generic Remove(Node deleteNode)
//         {
//             deleteNode.Prev.Next = deleteNode.Next;
//             deleteNode.Next.Prev = deleteNode.Prev;
//         }

//           public void RemoveEnd()
//     {
//         if (headNode == null) // List is empty
//         {
//             Console.WriteLine("List is empty.");
//             return;
//         }

//         // If there's only one node
//         if (headNode.Next == null)
//         {
//             headNode = null;
//             return;
//         }

//         // Use GenericRemove to remove the last node
//         GenericRemove(null, headNode);
//     }


//     public void RemoveData(int data)
//     {
//         if (headNode == null) // List is empty
//         {
//             Console.WriteLine("List is empty.");
//             return;
//         }

//         // Use GenericRemove to remove the node
//         GenericRemove(null, headNode, data);
//     }



// public int Length()
//     {
//         return GenericLength(headNode);
//     }

//     // GenericInsert method to handle insertion
//     private void GenericInsert(Node prevNode, Node newNode, Node nextNode)
//     {
//         if (prevNode == null) // Insert at the beginning
//         {
//             newNode.Next = nextNode;
//             headNode = newNode;
//         }
//         else
//         {
//             // Can be extended for other insertion scenarios
//         }
//     }

//     // GenericLength method to calculate the length of the list
//     private int GenericLength(Node currentNode)
//     {
//         if (currentNode == null)
//         {
//             return 0; // Base case: empty list
//         }
//         else
//         {
//             // Recursive case: 1 (current node) + length of the rest of the list
//             return 1 + GenericLength(currentNode.Next);
//         }
//     }
//         public void print ()
//         Node tempNode = headNode.Next;
//         while(tempNode != headNode)
//         {
//             Console.Write(tempNode.Data  + " ")
//             tempNode = tempNode.Next;
//         }
//         Console.WriteLine("End");

//     }



using System;

namespace DataStructure
{
    internal class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(int data = 0)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }

    internal class List
    {
        private Node headNode;

        public List()
        {
            headNode = new Node();
            headNode.Next = headNode;
            headNode.Prev = headNode;
        }

        public void InsertAtBegin(int data)
        {
            Node newNode = new Node(data);
            GenericInsert(headNode, newNode, headNode.Next);
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            GenericInsert(headNode.Prev, newNode, headNode);
        }

        public void InsertAtPos(int data, int pos)
        {
            Node newNode = new Node(data);
            Node tempNode = headNode.Next;
            int counter = 0;

            while (tempNode != headNode && counter < pos)
            {
                tempNode = tempNode.Next;
                counter++;
            }

            GenericInsert(tempNode.Prev, newNode, tempNode);
        }

        public int RemoveAtBegin()
        {
            if (headNode.Next == headNode)
            {
                throw new InvalidOperationException("List is empty.");
            }

            int removeData = headNode.Next.Data;
            GenericRemove(headNode.Next);
            return removeData;
        }

        public void RemoveEnd()
        {
            if (headNode.Next == headNode)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            GenericRemove(headNode.Prev);
        }

        public void RemoveData(int data)
        {
            Node tempNode = headNode.Next;
            while (tempNode != headNode)
            {
                if (tempNode.Data == data)
                {
                    GenericRemove(tempNode);
                    return;
                }
                tempNode = tempNode.Next;
            }
            Console.WriteLine("Data not found.");
        }

        public int Length()
        {
            return GenericLength(headNode.Next);
        }

        private void GenericInsert(Node prevNode, Node newNode, Node nextNode)
        {
            prevNode.Next = newNode;
            newNode.Prev = prevNode;
            newNode.Next = nextNode;
            nextNode.Prev = newNode;
        }

        private void GenericRemove(Node deleteNode)
        {
            if (deleteNode == headNode)
                throw new InvalidOperationException("Cannot remove the head node.");
            
            deleteNode.Prev.Next = deleteNode.Next;
            deleteNode.Next.Prev = deleteNode.Prev;
        }

        private int GenericLength(Node currentNode)
        {
            int length = 0;
            while (currentNode != headNode)
            {
                length++;
                currentNode = currentNode.Next;
            }
            return length;
        }

        public void Print()
        {
            Node tempNode = headNode.Next;
            while (tempNode != headNode)
            {
                Console.Write(tempNode.Data + " ");
                tempNode = tempNode.Next;
            }
            Console.WriteLine("End");
        }
    }
}
