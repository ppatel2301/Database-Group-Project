namespace ProjectPart2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cs3380DataSet = new ProjectPart2.cs3380DataSet();
            this.cs3380DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cs3380DataSet1 = new ProjectPart2.cs3380DataSet();
            this.GetAllInfo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Query1Info = new System.Windows.Forms.Button();
            this.Query2Info = new System.Windows.Forms.Button();
            this.Query3Info = new System.Windows.Forms.Button();
            this.Query4Info = new System.Windows.Forms.Button();
            this.Query5Info = new System.Windows.Forms.Button();
            this.QueryInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3380DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3380DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3380DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(272, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(980, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO THE SCHOOL BOARD DATABASE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1172, 743);
            this.dataGridView1.TabIndex = 1;
            // 
            // cs3380DataSet
            // 
            this.cs3380DataSet.DataSetName = "cs3380DataSet";
            this.cs3380DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cs3380DataSetBindingSource
            // 
            this.cs3380DataSetBindingSource.DataSource = this.cs3380DataSet;
            this.cs3380DataSetBindingSource.Position = 0;
            // 
            // cs3380DataSet1
            // 
            this.cs3380DataSet1.DataSetName = "cs3380DataSet";
            this.cs3380DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GetAllInfo
            // 
            this.GetAllInfo.Location = new System.Drawing.Point(57, 202);
            this.GetAllInfo.Name = "GetAllInfo";
            this.GetAllInfo.Size = new System.Drawing.Size(230, 52);
            this.GetAllInfo.TabIndex = 2;
            this.GetAllInfo.Text = "Query 2";
            this.GetAllInfo.UseVisualStyleBackColor = true;
            this.GetAllInfo.Click += new System.EventHandler(this.GetAllInfo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Query 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "Query 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(57, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 53);
            this.button4.TabIndex = 5;
            this.button4.Text = "Query 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(57, 411);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 53);
            this.button5.TabIndex = 6;
            this.button5.Text = "Query 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Query1Info
            // 
            this.Query1Info.Location = new System.Drawing.Point(12, 141);
            this.Query1Info.Name = "Query1Info";
            this.Query1Info.Size = new System.Drawing.Size(39, 37);
            this.Query1Info.TabIndex = 8;
            this.Query1Info.Text = "i";
            this.Query1Info.UseVisualStyleBackColor = true;
            this.Query1Info.Click += new System.EventHandler(this.Query1Info_Click);
            // 
            // Query2Info
            // 
            this.Query2Info.Location = new System.Drawing.Point(12, 210);
            this.Query2Info.Name = "Query2Info";
            this.Query2Info.Size = new System.Drawing.Size(39, 37);
            this.Query2Info.TabIndex = 9;
            this.Query2Info.Text = "i";
            this.Query2Info.UseVisualStyleBackColor = true;
            this.Query2Info.Click += new System.EventHandler(this.Query2Info_Click);
            // 
            // Query3Info
            // 
            this.Query3Info.Location = new System.Drawing.Point(12, 277);
            this.Query3Info.Name = "Query3Info";
            this.Query3Info.Size = new System.Drawing.Size(39, 37);
            this.Query3Info.TabIndex = 10;
            this.Query3Info.Text = "i";
            this.Query3Info.UseVisualStyleBackColor = true;
            this.Query3Info.Click += new System.EventHandler(this.Query3Info_Click);
            // 
            // Query4Info
            // 
            this.Query4Info.Location = new System.Drawing.Point(12, 346);
            this.Query4Info.Name = "Query4Info";
            this.Query4Info.Size = new System.Drawing.Size(39, 37);
            this.Query4Info.TabIndex = 11;
            this.Query4Info.Text = "i";
            this.Query4Info.UseVisualStyleBackColor = true;
            this.Query4Info.Click += new System.EventHandler(this.Query4Info_Click);
            // 
            // Query5Info
            // 
            this.Query5Info.Location = new System.Drawing.Point(12, 419);
            this.Query5Info.Name = "Query5Info";
            this.Query5Info.Size = new System.Drawing.Size(39, 37);
            this.Query5Info.TabIndex = 12;
            this.Query5Info.Text = "i";
            this.Query5Info.UseVisualStyleBackColor = true;
            this.Query5Info.Click += new System.EventHandler(this.Query5Info_Click);
            // 
            // QueryInfo
            // 
            this.QueryInfo.Location = new System.Drawing.Point(57, 483);
            this.QueryInfo.Name = "QueryInfo";
            this.QueryInfo.Size = new System.Drawing.Size(230, 50);
            this.QueryInfo.TabIndex = 13;
            this.QueryInfo.Text = "Query Overview";
            this.QueryInfo.UseVisualStyleBackColor = true;
            this.QueryInfo.Click += new System.EventHandler(this.QueryInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1477, 889);
            this.Controls.Add(this.QueryInfo);
            this.Controls.Add(this.Query5Info);
            this.Controls.Add(this.Query4Info);
            this.Controls.Add(this.Query3Info);
            this.Controls.Add(this.Query2Info);
            this.Controls.Add(this.Query1Info);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GetAllInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3380DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3380DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3380DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cs3380DataSetBindingSource;
        private cs3380DataSet cs3380DataSet;
        private cs3380DataSet cs3380DataSet1;
        private System.Windows.Forms.Button GetAllInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Query1Info;
        private System.Windows.Forms.Button Query2Info;
        private System.Windows.Forms.Button Query3Info;
        private System.Windows.Forms.Button Query4Info;
        private System.Windows.Forms.Button Query5Info;
        private System.Windows.Forms.Button QueryInfo;
    }
}

