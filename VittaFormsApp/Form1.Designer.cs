namespace VittaFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            paymentsGridView = new DataGridView();
            headerLabel = new Label();
            payBtn = new Button();
            enterSumLable = new Label();
            sumNumericUpDown = new NumericUpDown();
            refreshBtn = new Button();
            receiptGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ordersGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)paymentsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sumNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)receiptGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersGridView).BeginInit();
            SuspendLayout();
            // 
            // paymentsGridView
            // 
            paymentsGridView.AllowUserToAddRows = false;
            paymentsGridView.AllowUserToDeleteRows = false;
            paymentsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            paymentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentsGridView.Location = new Point(41, 130);
            paymentsGridView.MaximumSize = new Size(624, 776);
            paymentsGridView.MinimumSize = new Size(624, 776);
            paymentsGridView.MultiSelect = false;
            paymentsGridView.Name = "paymentsGridView";
            paymentsGridView.ReadOnly = true;
            paymentsGridView.RowHeadersWidth = 51;
            paymentsGridView.RowTemplate.Height = 29;
            paymentsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            paymentsGridView.Size = new Size(624, 776);
            paymentsGridView.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(466, 46);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(133, 40);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Платежи";
            // 
            // payBtn
            // 
            payBtn.BackColor = Color.FromArgb(192, 255, 192);
            payBtn.Location = new Point(703, 856);
            payBtn.Name = "payBtn";
            payBtn.Size = new Size(308, 50);
            payBtn.TabIndex = 6;
            payBtn.Text = "Оплатить";
            payBtn.UseVisualStyleBackColor = false;
            payBtn.Click += payBtn_Click;
            // 
            // enterSumLable
            // 
            enterSumLable.AutoSize = true;
            enterSumLable.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            enterSumLable.Location = new Point(703, 798);
            enterSumLable.Name = "enterSumLable";
            enterSumLable.Size = new Size(165, 22);
            enterSumLable.TabIndex = 8;
            enterSumLable.Text = "Ввести сумму к оплате";
            // 
            // sumNumericUpDown
            // 
            sumNumericUpDown.DecimalPlaces = 2;
            sumNumericUpDown.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            sumNumericUpDown.Location = new Point(703, 823);
            sumNumericUpDown.Maximum = new decimal(new int[] { -1593835520, 466537709, 54210, 0 });
            sumNumericUpDown.Name = "sumNumericUpDown";
            sumNumericUpDown.Size = new Size(308, 28);
            sumNumericUpDown.TabIndex = 9;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(1134, 87);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(94, 29);
            refreshBtn.TabIndex = 11;
            refreshBtn.Text = "Обновить";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // receiptGridView
            // 
            receiptGridView.AllowUserToAddRows = false;
            receiptGridView.AllowUserToDeleteRows = false;
            receiptGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            receiptGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            receiptGridView.Location = new Point(694, 155);
            receiptGridView.MultiSelect = false;
            receiptGridView.Name = "receiptGridView";
            receiptGridView.ReadOnly = true;
            receiptGridView.RowHeadersWidth = 51;
            receiptGridView.RowTemplate.Height = 29;
            receiptGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            receiptGridView.Size = new Size(534, 287);
            receiptGridView.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(694, 130);
            label1.Name = "label1";
            label1.Size = new Size(164, 22);
            label1.TabIndex = 13;
            label1.Text = "Выбрать приход денег";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(694, 452);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 15;
            label2.Text = "Выбрать заказ";
            // 
            // ordersGridView
            // 
            ordersGridView.AllowUserToAddRows = false;
            ordersGridView.AllowUserToDeleteRows = false;
            ordersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGridView.Location = new Point(694, 477);
            ordersGridView.MultiSelect = false;
            ordersGridView.Name = "ordersGridView";
            ordersGridView.ReadOnly = true;
            ordersGridView.RowHeadersWidth = 51;
            ordersGridView.RowTemplate.Height = 29;
            ordersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersGridView.Size = new Size(534, 287);
            ordersGridView.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1252, 931);
            Controls.Add(label2);
            Controls.Add(ordersGridView);
            Controls.Add(label1);
            Controls.Add(receiptGridView);
            Controls.Add(refreshBtn);
            Controls.Add(sumNumericUpDown);
            Controls.Add(enterSumLable);
            Controls.Add(payBtn);
            Controls.Add(headerLabel);
            Controls.Add(paymentsGridView);
            MinimumSize = new Size(1068, 978);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)paymentsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)sumNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)receiptGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView paymentsGridView;
        private Label headerLabel;
        private Button payBtn;
        private Label enterSumLable;
        private NumericUpDown sumNumericUpDown;
        private Button refreshBtn;
        private DataGridView receiptGridView;
        private Label label1;
        private Label label2;
        private DataGridView ordersGridView;
    }
}