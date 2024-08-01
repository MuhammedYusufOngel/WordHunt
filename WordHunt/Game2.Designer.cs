namespace WordHunt
{
    partial class Game2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game2));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.lblRekor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.barTime = new System.Windows.Forms.ProgressBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnPas = new System.Windows.Forms.Button();
            this.picTrueFalse = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTrueFalse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblTrueAnswer = new System.Windows.Forms.Label();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTrueFalse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(777, 279);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(140, 216);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Skor";
            this.columnHeader1.Width = 48;
            // 
            // lblRekor
            // 
            this.lblRekor.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblRekor.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRekor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblRekor.Location = new System.Drawing.Point(23, 131);
            this.lblRekor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRekor.Name = "lblRekor";
            this.lblRekor.Size = new System.Drawing.Size(68, 32);
            this.lblRekor.TabIndex = 35;
            this.lblRekor.Text = "0";
            this.lblRekor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 34;
            this.label6.Text = "Rekor";
            // 
            // barTime
            // 
            this.barTime.Location = new System.Drawing.Point(342, 45);
            this.barTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barTime.Name = "barTime";
            this.barTime.Size = new System.Drawing.Size(233, 27);
            this.barTime.TabIndex = 33;
            this.barTime.Value = 100;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTime.Location = new System.Drawing.Point(429, 7);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 36);
            this.lblTime.TabIndex = 32;
            this.lblTime.Text = "100";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPas
            // 
            this.btnPas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPas.Location = new System.Drawing.Point(414, 445);
            this.btnPas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPas.Name = "btnPas";
            this.btnPas.Size = new System.Drawing.Size(99, 51);
            this.btnPas.TabIndex = 31;
            this.btnPas.Text = "Pas";
            this.btnPas.UseVisualStyleBackColor = false;
            this.btnPas.Click += new System.EventHandler(this.btnPas_Click);
            // 
            // picTrueFalse
            // 
            this.picTrueFalse.Location = new System.Drawing.Point(414, 339);
            this.picTrueFalse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picTrueFalse.Name = "picTrueFalse";
            this.picTrueFalse.Size = new System.Drawing.Size(99, 88);
            this.picTrueFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrueFalse.TabIndex = 30;
            this.picTrueFalse.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(414, 339);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnTrueFalse
            // 
            this.btnTrueFalse.BackColor = System.Drawing.Color.White;
            this.btnTrueFalse.Location = new System.Drawing.Point(19, 223);
            this.btnTrueFalse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTrueFalse.Name = "btnTrueFalse";
            this.btnTrueFalse.Size = new System.Drawing.Size(88, 82);
            this.btnTrueFalse.TabIndex = 28;
            this.btnTrueFalse.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Puan:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPuan.Location = new System.Drawing.Point(82, 9);
            this.lblPuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(24, 28);
            this.lblPuan.TabIndex = 26;
            this.lblPuan.Text = "0";
            // 
            // lblTrueAnswer
            // 
            this.lblTrueAnswer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrueAnswer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTrueAnswer.Location = new System.Drawing.Point(13, 519);
            this.lblTrueAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrueAnswer.Name = "lblTrueAnswer";
            this.lblTrueAnswer.Size = new System.Drawing.Size(904, 36);
            this.lblTrueAnswer.TabIndex = 25;
            this.lblTrueAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtUserAnswer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserAnswer.Location = new System.Drawing.Point(342, 223);
            this.txtUserAnswer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(233, 29);
            this.txtUserAnswer.TabIndex = 24;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOk.Location = new System.Drawing.Point(414, 263);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 69);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "Tamam";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblWord
            // 
            this.lblWord.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblWord.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWord.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblWord.Location = new System.Drawing.Point(342, 183);
            this.lblWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(233, 36);
            this.lblWord.TabIndex = 22;
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(777, 7);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 36);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Başla";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.Font = new System.Drawing.Font("VCR OSD Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(777, 49);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 39);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Game2
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(929, 572);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblRekor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.barTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnPas);
            this.Controls.Add(this.picTrueFalse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTrueFalse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblTrueAnswer);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTrueFalse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Label lblRekor;
        private Label label6;
        private ProgressBar barTime;
        private Label lblTime;
        private Button btnPas;
        private PictureBox picTrueFalse;
        private PictureBox pictureBox1;
        private Button btnTrueFalse;
        private Label label4;
        private Label lblPuan;
        private Label lblTrueAnswer;
        private TextBox txtUserAnswer;
        private Button btnOk;
        private Label lblWord;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private Button btnBack;
    }
}