using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    class LinkedListex : IEnumerator
    {
        class ListElement
        {
            public Wizards wizard;
            public ListElement next;
        }

        ListElement head;
        ListElement head_pointer;

        public void Insert(Wizards wizard)
        {
            if (head == null)
            {
                head = new ListElement();
                head.wizard = wizard;
            }
            else
            {
                ListElement current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new ListElement();
                current.next.wizard = wizard;
            }
        }
        public object Current
        {
            get { return head_pointer.wizard; }
        }
        public bool MoveNext()
        {
            if (head_pointer == null)
            {
                head_pointer = head;
                return true;
            }
            else if (head_pointer.next != null)
            {
                head_pointer = head_pointer.next;
                return true;
            }
            else
            {
                this.Reset();
                return false;
            }
        }

        public void Reset()
        {
            head_pointer = null;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public void TestCourage(int quality)
        {
            ListElement w = head;
            while (w != null)
            {
                if (w.wizard.Courage >= quality)
                    Process(w);
                w = w.next;
            }
        }
        public int CountCourage(int quality)
        {
            int sum = 0;
            ListElement w = head;
            while (w != null)
            {
                if (w.wizard.Courage >= quality)
                    sum++;
                w = w.next;
            }
            return sum;
        }

        public void TestIntelligence(int quality)
        {
            ListElement w = head;
            while (w != null)
            {
                if (w.wizard.Intelligence >= quality)
                    Process(w);
                w = w.next;
            }
        }
        public int CountIntelligence(int quality)
        {
            int sum = 0;
            ListElement w = head;
            while (w != null)
            {
                if (w.wizard.Intelligence >= quality)
                    sum++;
                w = w.next;
            }
            return sum;
        }
        public void TestPerseverance(int quality)
        {
            ListElement w = head;
            while (w != null)
            {
                if (w.wizard.Perseverance >= quality)
                    Process(w);
                w = w.next;
            }
        }
        public int CountPerseverance(int quality)
        {
            int sum = 0;
            ListElement w = head;
            while (w != null)
            {
                if (w.wizard.Perseverance >= quality)
                    sum++;
                w = w.next;
            }
            return sum;
        }
        public void TestCunning(int quality)
        {
            ListElement w = head;
            while (w != null)
            {
                if (w.wizard.Cunning >= quality)
                    Process(w);
                w = w.next;
            }
        }
        public int CountCunning(int quality)
        {
            int sum = 0;
            ListElement w = head;
            while (w != null)
            {
                if (w.wizard.Cunning >= quality)
                    sum++;
                w = w.next;
            }
            return sum;
        }
        private void Process(ListElement w)
        {
            Console.Write(w.wizard + " ");
        }
    }
}