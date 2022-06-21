namespace FIFO_DobleLinkedList
{
    partial class FormFilaPilha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFila = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.btnPilha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFila
            // 
            this.btnFila.Location = new System.Drawing.Point(324, 136);
            this.btnFila.Name = "btnFila";
            this.btnFila.Size = new System.Drawing.Size(117, 27);
            this.btnFila.TabIndex = 0;
            this.btnFila.Text = "Fila";
            this.btnFila.UseVisualStyleBackColor = true;
            this.btnFila.Click += new System.EventHandler(this.btnFila_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(40, 79);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(220, 298);
            this.input.TabIndex = 1;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(506, 79);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(220, 298);
            this.output.TabIndex = 2;
            // 
            // btnPilha
            // 
            this.btnPilha.Location = new System.Drawing.Point(324, 256);
            this.btnPilha.Name = "btnPilha";
            this.btnPilha.Size = new System.Drawing.Size(117, 27);
            this.btnPilha.TabIndex = 3;
            this.btnPilha.Text = "Pilha";
            this.btnPilha.UseVisualStyleBackColor = true;
            this.btnPilha.Click += new System.EventHandler(this.btnPilha_Click);
            // 
            // FormFilaPilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPilha);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.btnFila);
            this.Name = "FormFilaPilha";
            this.Text = "Fila Pilha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFila;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button btnPilha;
    }
}

