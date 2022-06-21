using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO_DobleLinkedList
{
    internal class Item
    {
        public Item _Prev { get; set; }
        public String Element { get; set; } 
        public Item _Next { get; set; }

        public Item()
        {
            this.Element = null;
            this._Prev = new Item(this, null, null);
            this._Next = this._Prev;
        }

        public Item(Item Prev, String Element, Item Next)
        {
            this._Prev = Prev;
            this.Element = Element;
            this._Next = Next;
        }
    }
}
