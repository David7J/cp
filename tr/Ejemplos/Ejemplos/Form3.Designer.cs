namespace Ejemplos
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.Ejemplo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inssLaboralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ejemplo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ejemplo
            // 
            this.Ejemplo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inssLaboralToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.Ejemplo.Name = "contextMenuStrip1";
            this.Ejemplo.Size = new System.Drawing.Size(181, 70);
            // 
            // inssLaboralToolStripMenuItem
            // 
            this.inssLaboralToolStripMenuItem.Name = "inssLaboralToolStripMenuItem";
            this.inssLaboralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inssLaboralToolStripMenuItem.Text = "Inss Laboral";
            this.inssLaboralToolStripMenuItem.Click += new System.EventHandler(this.inssLaboralToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form3";
            this.Text = "MDI";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Ejemplo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip Ejemplo;
        private ToolStripMenuItem inssLaboralToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem;
    }
}