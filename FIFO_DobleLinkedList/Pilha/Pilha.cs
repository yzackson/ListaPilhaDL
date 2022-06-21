using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO_DobleLinkedList
{
    internal class Pilha
    {
        public Item Item { get; set; }
        private String Text;

        public void AddItem(String Item)
        {
            if (this.Item == null)
            {
                this.Item = new Item();

                var NewElement = new Item(this.Item, Item, this.Item._Prev);

                this.Item._Next = NewElement; // altera o _Next do head
                this.Item._Prev._Prev = NewElement; // altera o _Prev da tail
            }
            else
            {
                var Head = this.Item;
                var FirstItem = Head._Next;


                FirstItem._Prev = new Item(Head, Item, FirstItem);
                Head._Next = FirstItem._Prev;
            }
        }

        public String GetItems(Item Item)
        {
            this.Text = null;
            while (Item._Next != null)
            {
                this.Text += Item.Element == null ? Item.Element : Item.Element + "\r\n";
                Item = Item._Next;
            }
            return this.Text;
        }
    }
}
