using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    class Houses
    {
        class BSTNode
        {
            public LinkedListex value;
            public int key;
            public BSTNode leftChild;
            public BSTNode rightChild;
        }

        BSTNode root;

        public delegate void TraversalHandler(LinkedListex value, int quality);
        public delegate bool Count(LinkedListex value, int quality);

        public void Traversal(TraversalHandler callback, int quality)
        {
            Traversal(root, callback, quality);
        }

        private void Traversal(BSTNode currentRoot, TraversalHandler callback, int key)
        {
            if (currentRoot != null)
            {
                Traversal(currentRoot.leftChild, callback, key);
                callback?.Invoke(currentRoot.value, key);
                Traversal(currentRoot.rightChild, callback, key);
            }
        }
        public int TraversalCheck(Count callback, int quality)
        {
            return TraversalCheck(root, callback, quality);
        }

        private int TraversalCheck(BSTNode currentRoot, Count callback, int key)
        {
            int sum = 0;
            if (currentRoot != null)
            {
                TraversalCheck(currentRoot.leftChild, callback, key);
                if ((bool)(callback?.Invoke(currentRoot.value, key)))
                {
                    sum++;
                }
                TraversalCheck(currentRoot.rightChild, callback, key);
            }
            return sum;
        }

        public void Insert(Wizards w, int quality)
        {
            BSTNode newNode = new BSTNode();
            LinkedListex listToInsert = new LinkedListex();
            listToInsert.Insert(w);
            newNode.value = listToInsert;
            newNode.key = quality;
            newNode.leftChild = null;
            newNode.rightChild = null;

            Insert(w, quality, ref root);
        }

        private void Insert(Wizards w, int key, ref BSTNode currentRoot)
        {
            if (currentRoot == null)
            {
                BSTNode newNode = new BSTNode();
                LinkedListex listToInsert = new LinkedListex();
                listToInsert.Insert(w);
                newNode.value = listToInsert;
                newNode.key = key;
                currentRoot = newNode;
            }
            else
            {
                if (currentRoot.key.CompareTo(key) == 0)
                {
                    currentRoot.value.Insert(w);
                }

                else
                {
                    if (currentRoot.key.CompareTo(key) < 0)
                    {
                        Insert(w, key, ref currentRoot.rightChild);
                    }
                    else if (currentRoot.key.CompareTo(key) > 0)
                    {
                        Insert(w, key, ref currentRoot.leftChild);
                    }
                    else
                    {
                        throw new KeyException();
                    }
                }
            }
        }
    }
}

