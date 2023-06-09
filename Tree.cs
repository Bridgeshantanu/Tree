﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure2
{
    public interface INode<T>
    {
        T Key { get; set; }
        INode<T> Left { get; set; }
        INode<T> Right { get; set; }
    }

    public class BinaryNode<T> : INode<T> where T : IComparable<T>
    {
        public T Key { get; set; }
        public INode<T> Left { get; set; }
        public INode<T> Right { get; set; }

        public BinaryNode(T key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public INode<T> Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Add(T key)
        {
            Root = AddNode(Root, key);
        }

        public INode<T> AddNode(INode<T> node, T key)
        {
            if (node == null)
            {
                node = new BinaryNode<T>(key);
                return node;
            }

            if (key.CompareTo(node.Key) < 0)
                node.Left = AddNode(node.Left, key);
            else if (key.CompareTo(node.Key) > 0)
                node.Right = AddNode(node.Right, key);

            return node;
        }
        public int Size()
        {
            return CalculateSize(Root);
        }

        public int CalculateSize(INode<T> node)
        {
            if (node == null)
                return 0;

            return 1 + CalculateSize(node.Left) + CalculateSize(node.Right);
        }
        public bool Search(T key)
        {
            return SearchNode(Root, key);
        }

        public bool SearchNode(INode<T> node, T key)
        {
            if (node == null)
                return false;

            if (key.CompareTo(node.Key) == 0)
                return true;
            else if (key.CompareTo(node.Key) < 0)
                return SearchNode(node.Left, key);
            else
                return SearchNode(node.Right, key);
        }
        public void Display()
        {
            DisplayInOrder(Root);
        }
        public void DisplayInOrder(INode<T> node)
        {
            if (node == null)
                return;

            DisplayInOrder(node.Left);
            Console.Write(node.Key + " ");
            DisplayInOrder(node.Right);
        }
    }


}
