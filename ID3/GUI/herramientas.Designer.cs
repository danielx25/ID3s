namespace ID3.GUI
{
    partial class herramientas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(herramientas));
            this.btnImportar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelVistaPrevia = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxId3 = new System.Windows.Forms.CheckBox();
            this.checkBoxC45 = new System.Windows.Forms.CheckBox();
            this.checkBoxLM = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.arbolesF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.White;
            this.btnImportar.Location = new System.Drawing.Point(26, 12);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(153, 44);
            this.btnImportar.TabIndex = 10;
            this.btnImportar.Text = "IMPORTAR ARCHIVO";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(322, 289);
            this.dataGridView.TabIndex = 11;
            // 
            // labelVistaPrevia
            // 
            this.labelVistaPrevia.AutoSize = true;
            this.labelVistaPrevia.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVistaPrevia.Location = new System.Drawing.Point(22, 384);
            this.labelVistaPrevia.Name = "labelVistaPrevia";
            this.labelVistaPrevia.Size = new System.Drawing.Size(197, 19);
            this.labelVistaPrevia.TabIndex = 12;
            this.labelVistaPrevia.Text = "Vista Previa No Disponible";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(23, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 296);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 221);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(376, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 488);
            this.panel3.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(404, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 48);
            this.button1.TabIndex = 17;
            this.button1.Text = "VER COMPARACION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(401, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(362, 228);
            this.panel4.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(404, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 44);
            this.button2.TabIndex = 19;
            this.button2.Text = "GENERAR INFORME";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(600, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 111);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxId3
            // 
            this.checkBoxId3.AutoSize = true;
            this.checkBoxId3.Location = new System.Drawing.Point(26, 425);
            this.checkBoxId3.Name = "checkBoxId3";
            this.checkBoxId3.Size = new System.Drawing.Size(43, 17);
            this.checkBoxId3.TabIndex = 21;
            this.checkBoxId3.Text = "ID3";
            this.checkBoxId3.UseVisualStyleBackColor = true;
            // 
            // checkBoxC45
            // 
            this.checkBoxC45.AutoSize = true;
            this.checkBoxC45.Location = new System.Drawing.Point(26, 449);
            this.checkBoxC45.Name = "checkBoxC45";
            this.checkBoxC45.Size = new System.Drawing.Size(45, 17);
            this.checkBoxC45.TabIndex = 22;
            this.checkBoxC45.Text = "C45";
            this.checkBoxC45.UseVisualStyleBackColor = true;
            // 
            // checkBoxLM
            // 
            this.checkBoxLM.AutoSize = true;
            this.checkBoxLM.Location = new System.Drawing.Point(26, 470);
            this.checkBoxLM.Name = "checkBoxLM";
            this.checkBoxLM.Size = new System.Drawing.Size(97, 17);
            this.checkBoxLM.TabIndex = 23;
            this.checkBoxLM.Text = "Lopez Mantara";
            this.checkBoxLM.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(195, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 44);
            this.button3.TabIndex = 24;
            this.button3.Text = "Iniciar ID3s";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // arbolesF
            // 
            this.arbolesF.BackColor = System.Drawing.Color.DarkCyan;
            this.arbolesF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arbolesF.Enabled = false;
            this.arbolesF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arbolesF.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arbolesF.ForeColor = System.Drawing.Color.White;
            this.arbolesF.Location = new System.Drawing.Point(404, 341);
            this.arbolesF.Name = "arbolesF";
            this.arbolesF.Size = new System.Drawing.Size(153, 44);
            this.arbolesF.TabIndex = 25;
            this.arbolesF.Text = "Guardar Arboles";
            this.arbolesF.UseVisualStyleBackColor = false;
            this.arbolesF.Click += new System.EventHandler(this.arbolesF_Click);
            // 
            // herramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 485);
            this.Controls.Add(this.arbolesF);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBoxLM);
            this.Controls.Add(this.checkBoxC45);
            this.Controls.Add(this.checkBoxId3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelVistaPrevia);
            this.Controls.Add(this.btnImportar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "herramientas";
            this.Text = "herramientas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label labelVistaPrevia;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxId3;
        private System.Windows.Forms.CheckBox checkBoxC45;
        private System.Windows.Forms.CheckBox checkBoxLM;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button arbolesF;
    }
}