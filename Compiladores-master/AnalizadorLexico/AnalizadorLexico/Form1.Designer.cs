
namespace AnalizadorLexico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.basicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concatenacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerraduraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerraduraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eRAFNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertirAFNAAFDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaAnalizadorLexicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.análisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descensoRecursivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicoToolStripMenuItem,
            this.análisisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // basicoToolStripMenuItem
            // 
            this.basicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicaToolStripMenuItem,
            this.unionToolStripMenuItem,
            this.concatenacionToolStripMenuItem,
            this.cerraduraToolStripMenuItem,
            this.cerraduraToolStripMenuItem1,
            this.opcionalToolStripMenuItem,
            this.eRAFNToolStripMenuItem,
            this.convertirAFNAAFDToolStripMenuItem,
            this.pruebaAnalizadorLexicoToolStripMenuItem});
            this.basicoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.basicoToolStripMenuItem.Name = "basicoToolStripMenuItem";
            this.basicoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.basicoToolStripMenuItem.Text = "Acciones";
            this.basicoToolStripMenuItem.Click += new System.EventHandler(this.basicoToolStripMenuItem_Click);
            // 
            // basicaToolStripMenuItem
            // 
            this.basicaToolStripMenuItem.Name = "basicaToolStripMenuItem";
            this.basicaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.basicaToolStripMenuItem.Text = "Basica";
            this.basicaToolStripMenuItem.Click += new System.EventHandler(this.basicaToolStripMenuItem_Click);
            // 
            // unionToolStripMenuItem
            // 
            this.unionToolStripMenuItem.Name = "unionToolStripMenuItem";
            this.unionToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.unionToolStripMenuItem.Text = "Union";
            this.unionToolStripMenuItem.Click += new System.EventHandler(this.unionToolStripMenuItem_Click);
            // 
            // concatenacionToolStripMenuItem
            // 
            this.concatenacionToolStripMenuItem.Name = "concatenacionToolStripMenuItem";
            this.concatenacionToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.concatenacionToolStripMenuItem.Text = "Concatenacion";
            this.concatenacionToolStripMenuItem.Click += new System.EventHandler(this.concatenacionToolStripMenuItem_Click);
            // 
            // cerraduraToolStripMenuItem
            // 
            this.cerraduraToolStripMenuItem.Name = "cerraduraToolStripMenuItem";
            this.cerraduraToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cerraduraToolStripMenuItem.Text = "Cerradura +";
            this.cerraduraToolStripMenuItem.Click += new System.EventHandler(this.cerraduraToolStripMenuItem_Click);
            // 
            // cerraduraToolStripMenuItem1
            // 
            this.cerraduraToolStripMenuItem1.Name = "cerraduraToolStripMenuItem1";
            this.cerraduraToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.cerraduraToolStripMenuItem1.Text = "Cerradura *";
            this.cerraduraToolStripMenuItem1.Click += new System.EventHandler(this.cerraduraToolStripMenuItem1_Click);
            // 
            // opcionalToolStripMenuItem
            // 
            this.opcionalToolStripMenuItem.Name = "opcionalToolStripMenuItem";
            this.opcionalToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.opcionalToolStripMenuItem.Text = "Opcional";
            this.opcionalToolStripMenuItem.Click += new System.EventHandler(this.opcionalToolStripMenuItem_Click);
            // 
            // eRAFNToolStripMenuItem
            // 
            this.eRAFNToolStripMenuItem.Name = "eRAFNToolStripMenuItem";
            this.eRAFNToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.eRAFNToolStripMenuItem.Text = "ER -> AFN";
            this.eRAFNToolStripMenuItem.Click += new System.EventHandler(this.eRAFNToolStripMenuItem_Click);
            // 
            // convertirAFNAAFDToolStripMenuItem
            // 
            this.convertirAFNAAFDToolStripMenuItem.Name = "convertirAFNAAFDToolStripMenuItem";
            this.convertirAFNAAFDToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.convertirAFNAAFDToolStripMenuItem.Text = "Convertir AFN a AFD";
            this.convertirAFNAAFDToolStripMenuItem.Click += new System.EventHandler(this.convertirAFNAAFDToolStripMenuItem_Click);
            // 
            // pruebaAnalizadorLexicoToolStripMenuItem
            // 
            this.pruebaAnalizadorLexicoToolStripMenuItem.Name = "pruebaAnalizadorLexicoToolStripMenuItem";
            this.pruebaAnalizadorLexicoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.pruebaAnalizadorLexicoToolStripMenuItem.Text = "Prueba Analizador Lexico";
            this.pruebaAnalizadorLexicoToolStripMenuItem.Click += new System.EventHandler(this.pruebaAnalizadorLexicoToolStripMenuItem_Click);
            // 
            // análisisToolStripMenuItem
            // 
            this.análisisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descensoRecursivoToolStripMenuItem});
            this.análisisToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.análisisToolStripMenuItem.Name = "análisisToolStripMenuItem";
            this.análisisToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.análisisToolStripMenuItem.Text = " Análisis sintáctico";
            // 
            // descensoRecursivoToolStripMenuItem
            // 
            this.descensoRecursivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem});
            this.descensoRecursivoToolStripMenuItem.Name = "descensoRecursivoToolStripMenuItem";
            this.descensoRecursivoToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.descensoRecursivoToolStripMenuItem.Text = "Descenso Recursivo";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1519, 843);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1170, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Compiladores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem basicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concatenacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerraduraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerraduraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcionalToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem convertirAFNAAFDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebaAnalizadorLexicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem análisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descensoRecursivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eRAFNToolStripMenuItem;
    }
}

