namespace Semana2
{
    partial class CasoPropuesto02
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
            this.DgListaPedidos = new System.Windows.Forms.DataGridView();
            this.DgListaProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgListaPedidos
            // 
            this.DgListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListaPedidos.Location = new System.Drawing.Point(44, 95);
            this.DgListaPedidos.Name = "DgListaPedidos";
            this.DgListaPedidos.RowHeadersWidth = 51;
            this.DgListaPedidos.RowTemplate.Height = 24;
            this.DgListaPedidos.Size = new System.Drawing.Size(930, 245);
            this.DgListaPedidos.TabIndex = 0;
            this.DgListaPedidos.DoubleClick += new System.EventHandler(this.DgListaPedidos_DoubleClick);
            // 
            // DgListaProductos
            // 
            this.DgListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListaProductos.Location = new System.Drawing.Point(44, 410);
            this.DgListaProductos.Name = "DgListaProductos";
            this.DgListaProductos.RowHeadersWidth = 51;
            this.DgListaProductos.RowTemplate.Height = 24;
            this.DgListaProductos.Size = new System.Drawing.Size(930, 159);
            this.DgListaProductos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Productos";
            // 
            // CasoPropuesto02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 656);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgListaProductos);
            this.Controls.Add(this.DgListaPedidos);
            this.Name = "CasoPropuesto02";
            this.Text = "CasoPropuesto02";
            this.Load += new System.EventHandler(this.CasoPropuesto02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgListaPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgListaPedidos;
        private System.Windows.Forms.DataGridView DgListaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}