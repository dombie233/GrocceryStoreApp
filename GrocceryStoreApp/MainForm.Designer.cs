namespace GrocceryStoreApp
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbShoopingCost = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbUserMoney = new System.Windows.Forms.Label();
            this.btnPurchaseHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(544, 559);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Twoje Zakupy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(602, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Dodaj produkt";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(861, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 47);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Usuń Produkt";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "łączny koszt zakupów";
            // 
            // lbShoopingCost
            // 
            this.lbShoopingCost.AutoSize = true;
            this.lbShoopingCost.Location = new System.Drawing.Point(771, 383);
            this.lbShoopingCost.Name = "lbShoopingCost";
            this.lbShoopingCost.Size = new System.Drawing.Size(56, 20);
            this.lbShoopingCost.TabIndex = 5;
            this.lbShoopingCost.Text = "0.00 zł";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(841, 474);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(166, 47);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Zapłać";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Twój portfel: ";
            // 
            // lbUserMoney
            // 
            this.lbUserMoney.AutoSize = true;
            this.lbUserMoney.Location = new System.Drawing.Point(771, 268);
            this.lbUserMoney.Name = "lbUserMoney";
            this.lbUserMoney.Size = new System.Drawing.Size(40, 20);
            this.lbUserMoney.TabIndex = 8;
            this.lbUserMoney.Text = "0.00";
            // 
            // btnPurchaseHistory
            // 
            this.btnPurchaseHistory.Location = new System.Drawing.Point(593, 474);
            this.btnPurchaseHistory.Name = "btnPurchaseHistory";
            this.btnPurchaseHistory.Size = new System.Drawing.Size(190, 117);
            this.btnPurchaseHistory.TabIndex = 9;
            this.btnPurchaseHistory.Text = "Zobacz Historie Zakupów";
            this.btnPurchaseHistory.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 621);
            this.Controls.Add(this.btnPurchaseHistory);
            this.Controls.Add(this.lbUserMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lbShoopingCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbShoopingCost;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUserMoney;
        private System.Windows.Forms.Button btnPurchaseHistory;
    }
}

