namespace ID3.GUI
{
    partial class RecorrerArbol
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.clase = new System.Windows.Forms.Label();
            this.atributos = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.clase);
            this.flowLayoutPanel1.Controls.Add(this.atributos);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 394);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // clase
            // 
            this.clase.AutoSize = true;
            this.clase.Location = new System.Drawing.Point(3, 0);
            this.clase.Name = "clase";
            this.clase.Size = new System.Drawing.Size(35, 13);
            this.clase.TabIndex = 0;
            this.clase.Text = "label1";
            // 
            // atributos
            // 
            this.atributos.FormattingEnabled = true;
            this.atributos.Location = new System.Drawing.Point(3, 16);
            this.atributos.Name = "atributos";
            this.atributos.Size = new System.Drawing.Size(521, 21);
            this.atributos.TabIndex = 1;
            this.atributos.SelectedIndexChanged += new System.EventHandler(this.atributos_SelectedIndexChanged_1);
            // 
            // RecorrerArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 458);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RecorrerArbol";
            this.Text = "RecorrerArbol";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label clase;
        private System.Windows.Forms.ComboBox atributos;
    }
}