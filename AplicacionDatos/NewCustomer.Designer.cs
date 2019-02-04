namespace AplicacionDatos
{
    partial class NewCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAddAnotherAccount = new System.Windows.Forms.Button();
            this.btnAddFinish = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textCustomerID);
            this.groupBox1.Controls.Add(this.textCustomerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar cuenta";
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(141, 70);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.ReadOnly = true;
            this.textCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textCustomerID.TabIndex = 3;
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(120, 35);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(121, 20);
            this.textCustomerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificador del cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del cliente:";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(350, 99);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(103, 27);
            this.btnCreateAccount.TabIndex = 4;
            this.btnCreateAccount.Text = "Crear cuenta";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpOrderDate);
            this.groupBox2.Controls.Add(this.numOrderAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(21, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 105);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear pedido";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(138, 61);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(123, 20);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // numOrderAmount
            // 
            this.numOrderAmount.Location = new System.Drawing.Point(141, 27);
            this.numOrderAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numOrderAmount.Name = "numOrderAmount";
            this.numOrderAmount.Size = new System.Drawing.Size(120, 20);
            this.numOrderAmount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha de pedido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de pedido:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(350, 230);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(115, 26);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Realizar pedido";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnAddAnotherAccount
            // 
            this.btnAddAnotherAccount.Location = new System.Drawing.Point(317, 278);
            this.btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            this.btnAddAnotherAccount.Size = new System.Drawing.Size(148, 26);
            this.btnAddAnotherAccount.TabIndex = 5;
            this.btnAddAnotherAccount.Text = "Agregar otra cuenta";
            this.btnAddAnotherAccount.UseVisualStyleBackColor = true;
            this.btnAddAnotherAccount.Click += new System.EventHandler(this.btnAddAnotherAccount_Click);
            // 
            // btnAddFinish
            // 
            this.btnAddFinish.Location = new System.Drawing.Point(49, 278);
            this.btnAddFinish.Name = "btnAddFinish";
            this.btnAddFinish.Size = new System.Drawing.Size(86, 26);
            this.btnAddFinish.TabIndex = 6;
            this.btnAddFinish.Text = "Finalizar";
            this.btnAddFinish.UseVisualStyleBackColor = true;
            this.btnAddFinish.Click += new System.EventHandler(this.btnAddFinish_Click);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 326);
            this.Controls.Add(this.btnAddFinish);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnAddAnotherAccount);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewCustomer";
            this.Text = "Cuenta y pedido nuevos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.NumericUpDown numOrderAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnAddAnotherAccount;
        private System.Windows.Forms.Button btnAddFinish;
    }
}