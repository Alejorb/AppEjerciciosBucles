namespace AppEjerciciosBucles
{
    partial class frmBucleFor
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
            this.btnLlenarLista = new System.Windows.Forms.Button();
            this.btnOrdenarLista = new System.Windows.Forms.Button();
            this.LstNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLlenarLista
            // 
            this.btnLlenarLista.Location = new System.Drawing.Point(81, 39);
            this.btnLlenarLista.Name = "btnLlenarLista";
            this.btnLlenarLista.Size = new System.Drawing.Size(171, 35);
            this.btnLlenarLista.TabIndex = 0;
            this.btnLlenarLista.Text = "LLenar la lista de número";
            this.btnLlenarLista.UseVisualStyleBackColor = true;
            this.btnLlenarLista.Click += new System.EventHandler(this.btnLlenarLista_Click);
            // 
            // btnOrdenarLista
            // 
            this.btnOrdenarLista.Location = new System.Drawing.Point(354, 39);
            this.btnOrdenarLista.Name = "btnOrdenarLista";
            this.btnOrdenarLista.Size = new System.Drawing.Size(171, 35);
            this.btnOrdenarLista.TabIndex = 1;
            this.btnOrdenarLista.Text = "Ordenar lista";
            this.btnOrdenarLista.UseVisualStyleBackColor = true;
            this.btnOrdenarLista.Click += new System.EventHandler(this.btnOrdenarLista_Click);
            // 
            // LstNumeros
            // 
            this.LstNumeros.FormattingEnabled = true;
            this.LstNumeros.Location = new System.Drawing.Point(224, 123);
            this.LstNumeros.Name = "LstNumeros";
            this.LstNumeros.Size = new System.Drawing.Size(171, 134);
            this.LstNumeros.TabIndex = 2;
            // 
            // frmBucleFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstNumeros);
            this.Controls.Add(this.btnOrdenarLista);
            this.Controls.Add(this.btnLlenarLista);
            this.Name = "frmBucleFor";
            this.Text = "Ejemplo bucle For";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlenarLista;
        private System.Windows.Forms.Button btnOrdenarLista;
        private System.Windows.Forms.ListBox LstNumeros;
    }
}