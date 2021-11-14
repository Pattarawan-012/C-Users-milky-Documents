﻿using System;

namespace HW3
{
    class Program
    {

        static void Main(string[] args)
        {

            Queue CPUQueue = new Queue();
            char instruction;
            char data;
            int count = 0;

            while (true)
            {
                instruction = char.Parse(Console.ReadLine());

                if (instruction == '?')
                {
                    break;
                }
                data = char.Parse(Console.ReadLine());
                Node CPU = new Node(instruction, data);
                CPUQueue.Push(CPU);

            }
            Node instQueue;
            while (true)
            {
                instQueue = CPUQueue.Pop();
                count++;
                if (instQueue == null)
                {
                    break;
                }

            }

            Console.WriteLine("CPU cycles needed:" + count);
        }
    }
    class Node
    {

        public char Data;
        public Node Next;
        public Node(char instructionValue, char dataValue)
        {

            Data = dataValue;
        }
        public override string ToString()
        {
            return String.Format("({0})", Data);


        }
        class Instruction
        {

            public char instruction;
            public Instruction(char instructionValue)
            {
                instruction = instructionValue;

            }
            public override string ToString()
            {
                return String.Format("({0})", instruction);
            }
        }
        class Queue
        {
            private Node Root;
            public void Push(Node node)
            {
                if (Root == null)
                {
                    Root = node;
                }
                else
                {
                    Node ptr = Root;
                    while (ptr.Next != null)
                    {
                        ptr = ptr.Next;
                    }
                    ptr.Next = node;
                }
            }
            public Node Pop()
            {
                if (Root == null)
                {
                    return null;
                }
                Node node = Root;
                Root = Root.Next;
                node.Next = null;
                return node;
            }

        }
    }
}