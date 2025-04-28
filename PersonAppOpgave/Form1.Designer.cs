namespace PersonAppOpgave
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fornavn = new System.Windows.Forms.Label();
            this.fornavnTextBox = new System.Windows.Forms.TextBox();
            this.efternavnTextBox = new System.Windows.Forms.TextBox();
            this.efternavn = new System.Windows.Forms.Label();
            this.alderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addPersonBotten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(464, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(700, 443);
            this.dataGridView1.TabIndex = 0;
            // 
            // fornavn
            // 
            this.fornavn.AutoSize = true;
            this.fornavn.Location = new System.Drawing.Point(32, 113);
            this.fornavn.Name = "fornavn";
            this.fornavn.Size = new System.Drawing.Size(91, 25);
            this.fornavn.TabIndex = 1;
            this.fornavn.Text = "Fornavn";
            // 
            // fornavnTextBox
            // 
            this.fornavnTextBox.Location = new System.Drawing.Point(136, 110);
            this.fornavnTextBox.Name = "fornavnTextBox";
            this.fornavnTextBox.Size = new System.Drawing.Size(268, 31);
            this.fornavnTextBox.TabIndex = 2;
            this.fornavnTextBox.TextChanged += new System.EventHandler(this.fornavnTextBox_TextChanged);
            // 
            // efternavnTextBox
            // 
            this.efternavnTextBox.Location = new System.Drawing.Point(136, 170);
            this.efternavnTextBox.Name = "efternavnTextBox";
            this.efternavnTextBox.Size = new System.Drawing.Size(268, 31);
            this.efternavnTextBox.TabIndex = 4;
            this.efternavnTextBox.TextChanged += new System.EventHandler(this.efternavnTextBox_TextChanged);
            // 
            // efternavn
            // 
            this.efternavn.AutoSize = true;
            this.efternavn.Location = new System.Drawing.Point(32, 173);
            this.efternavn.Name = "efternavn";
            this.efternavn.Size = new System.Drawing.Size(104, 25);
            this.efternavn.TabIndex = 3;
            this.efternavn.Text = "Efternavn";
            // 
            // alderTextBox
            // 
            this.alderTextBox.Location = new System.Drawing.Point(136, 237);
            this.alderTextBox.Name = "alderTextBox";
            this.alderTextBox.Size = new System.Drawing.Size(268, 31);
            this.alderTextBox.TabIndex = 6;
            this.alderTextBox.TextChanged += new System.EventHandler(this.alderTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alder";
            // 
            // addPersonBotten
            // 
            this.addPersonBotten.Location = new System.Drawing.Point(136, 311);
            this.addPersonBotten.Name = "addPersonBotten";
            this.addPersonBotten.Size = new System.Drawing.Size(172, 54);
            this.addPersonBotten.TabIndex = 7;
            this.addPersonBotten.Text = "Tilføj Person";
            this.addPersonBotten.UseVisualStyleBackColor = true;
            this.addPersonBotten.Click += new System.EventHandler(this.addPersonBotten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 732);
            this.Controls.Add(this.addPersonBotten);
            this.Controls.Add(this.alderTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.efternavnTextBox);
            this.Controls.Add(this.efternavn);
            this.Controls.Add(this.fornavnTextBox);
            this.Controls.Add(this.fornavn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label fornavn;
        private System.Windows.Forms.TextBox fornavnTextBox;
        private System.Windows.Forms.TextBox efternavnTextBox;
        private System.Windows.Forms.Label efternavn;
        private System.Windows.Forms.TextBox alderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addPersonBotten;
    }
}

