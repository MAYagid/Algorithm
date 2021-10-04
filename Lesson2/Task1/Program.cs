using System;

namespace Task1
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("X_x");
        }
    }
    public class Node
{
    public int Value { get; set; }
    public Node NextNode { get; set; }
    public Node PrevNode { get; set; }
}

//Начальную и конечную ноду нужно хранить в самой реализации интерфейса
public interface ILinkedList
{
    int GetCount(); // возвращает количество элементов в списке
    void AddNode(int value);  // добавляет новый элемент списка

    void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
    void RemoveNode(int index); // удаляет элемент по порядковому номеру
    void RemoveNode(Node node); // удаляет указанный элемент
    Node FindNode(int searchValue); // ищет элемент по его значению
}
  
public class DLList : ILinkedList 
    {

        Node head = null;
        Node tail = null;
        int count = 0;
        int GetCount() 
        {
            return count;
        } // возвращает количество элементов в списке
        void AddNode(int value) 
        {
            Node node = new Node();

            if (head == null)
                head = node;
            else
            {
                tail.NextNode = node;
                node.PrevNode = tail;
            }
            tail = node;
            count++;
        }  // добавляет новый элемент списка

        void AddNodeAfter(Node node, int value)
        {
            int i = 0;
            Node cur_node = head;
            Node temp_node;
            while (i < value)
            {
                cur_node = cur_node.NextNode;
            }
            temp_node = cur_node.NextNode;
            cur_node.NextNode = node;
            node.NextNode = temp_node;
        }
        void RemoveNode(int index)
        {
            int i = 0;
            Node cur_node = head;
            
            while (i < index-1)
            {
                cur_node = cur_node.NextNode;
            }
            cur_node.NextNode = cur_node.NextNode.NextNode;
        }
        void RemoveNode(Node node)
        {
            Node cur_node = head;
            while (cur_node != node)
                cur_node = cur_node.NextNode;
            cur_node.PrevNode = cur_node.NextNode;
        }
        Node FindNode(int searchValue)
        {
            int i = 0;
            Node cur_node = head;

            while (i < searchValue)
            {
                cur_node = cur_node.NextNode;
            }
            return cur_node;
        }// ищет элемент по его значению

        int ILinkedList.GetCount()
        {
            throw new NotImplementedException();
        }

        void ILinkedList.AddNode(int value)
        {
            throw new NotImplementedException();
        }

        void ILinkedList.AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }

        void ILinkedList.RemoveNode(int index)
        {
            throw new NotImplementedException();
        }

        void ILinkedList.RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }

        Node ILinkedList.FindNode(int searchValue)
        {
            throw new NotImplementedException();
        }
    }

}



