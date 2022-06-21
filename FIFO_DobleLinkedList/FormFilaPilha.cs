using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFO_DobleLinkedList
{
    public partial class FormFilaPilha : Form
    {
        public FormFilaPilha()
        {
            InitializeComponent();
        }

        private void btnFila_Click(object sender, EventArgs e)
        {
            Fila Fila = new Fila();
            String[] text = input.Text.Split(new String[] { "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in text)
            {
                Fila.AddItem(s);
            }

            output.Text = Fila.GetItems(Fila.Item);
        }
        
        private void btnPilha_Click(object sender, EventArgs e)
        {
            Pilha Pilha = new Pilha();
            String[] text = input.Text.Split(new String[] { "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in text)
            {
                Pilha.AddItem(s);
            }

            output.Text = Pilha.GetItems(Pilha.Item);
        }
    }
}
