namespace BaiTap.Net
{
    partial class frmMain
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
            tbBo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbCuu = new TextBox();
            label3 = new Label();
            tbDe = new TextBox();
            button1 = new Button();
            btnKeu = new Button();
            btnVatSua = new Button();
            BtnDeCon = new Button();
            btnInsertDB = new Button();
            SuspendLayout();
            // 
            // tbBo
            // 
            tbBo.Location = new Point(65, 50);
            tbBo.Name = "tbBo";
            tbBo.Size = new Size(195, 27);
            tbBo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 19);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập số lượng bò";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 96);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 3;
            label2.Text = "Nhập số lượng cừu";
            // 
            // tbCuu
            // 
            tbCuu.Location = new Point(65, 127);
            tbCuu.Name = "tbCuu";
            tbCuu.Size = new Size(195, 27);
            tbCuu.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 180);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 5;
            label3.Text = "Nhập số lượng dê";
            // 
            // tbDe
            // 
            tbDe.Location = new Point(65, 211);
            tbDe.Name = "tbDe";
            tbDe.Size = new Size(195, 27);
            tbDe.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(103, 260);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnKeu
            // 
            btnKeu.Location = new Point(19, 328);
            btnKeu.Name = "btnKeu";
            btnKeu.Size = new Size(94, 29);
            btnKeu.TabIndex = 7;
            btnKeu.Text = "Kêu";
            btnKeu.UseVisualStyleBackColor = true;
            btnKeu.Click += btnKeu_Click;
            // 
            // btnVatSua
            // 
            btnVatSua.Location = new Point(134, 328);
            btnVatSua.Name = "btnVatSua";
            btnVatSua.Size = new Size(94, 29);
            btnVatSua.TabIndex = 8;
            btnVatSua.Text = "Vắt sữa";
            btnVatSua.UseVisualStyleBackColor = true;
            btnVatSua.Click += btnVatSua_Click;
            // 
            // BtnDeCon
            // 
            BtnDeCon.Location = new Point(246, 328);
            BtnDeCon.Name = "BtnDeCon";
            BtnDeCon.Size = new Size(94, 29);
            BtnDeCon.TabIndex = 9;
            BtnDeCon.Text = "Đẻ con";
            BtnDeCon.UseVisualStyleBackColor = true;
            BtnDeCon.Click += BtnDeCon_Click;
            // 
            // btnInsertDB
            // 
            btnInsertDB.Location = new Point(88, 398);
            btnInsertDB.Name = "btnInsertDB";
            btnInsertDB.Size = new Size(156, 29);
            btnInsertDB.TabIndex = 10;
            btnInsertDB.Text = "Insert into Database";
            btnInsertDB.UseVisualStyleBackColor = true;
            btnInsertDB.Click += btnInsertDB_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 488);
            Controls.Add(btnInsertDB);
            Controls.Add(BtnDeCon);
            Controls.Add(btnVatSua);
            Controls.Add(btnKeu);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(tbDe);
            Controls.Add(label2);
            Controls.Add(tbCuu);
            Controls.Add(label1);
            Controls.Add(tbBo);
            Name = "frmMain";
            Text = "TrangTraiChanNuoi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbBo;
        private Label label1;
        private Label label2;
        private TextBox tbCuu;
        private Label label3;
        private TextBox tbDe;
        private Button button1;
        private Button btnKeu;
        private Button btnVatSua;
        private Button BtnDeCon;
        private Button btnInsertDB;
    }
}