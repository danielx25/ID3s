namespace ID3.GUI
{
    partial class comparacion
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
            this.tablaComparacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaComparacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaComparacion
            // 
            this.tablaComparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaComparacion.Location = new System.Drawing.Point(12, 28);
            this.tablaComparacion.Name = "tablaComparacion";
            this.tablaComparacion.Size = new System.Drawing.Size(729, 373);
            this.tablaComparacion.TabIndex = 0;
            // 
            // comparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 428);
            this.Controls.Add(this.tablaComparacion);
            this.Name = "comparacion";
            this.Text = "comparacion";
            ((System.ComponentModel.ISupportInitialize)(this.tablaComparacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView tablaComparacion;
    }
}