namespace AplicacionDatos
{
    partial class FillOrCancel
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
            this.btnFindByOrderID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textOrderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFillOrder = new System.Windows.Forms.Button();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appPedidosDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appPedidosDataSet = new AplicacionDatos.AppPedidosDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.appPedidosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new AplicacionDatos.AppPedidosDataSetTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appPedidosDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appPedidosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appPedidosDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindByOrderID
            // 
            this.btnFindByOrderID.Location = new System.Drawing.Point(258, 78);
            this.btnFindByOrderID.Name = "btnFindByOrderID";
            this.btnFindByOrderID.Size = new System.Drawing.Size(132, 23);
            this.btnFindByOrderID.TabIndex = 0;
            this.btnFindByOrderID.Text = "Buscar pedido";
            this.btnFindByOrderID.UseVisualStyleBackColor = true;
            this.btnFindByOrderID.Click += new System.EventHandler(this.btnFindByOrderID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificador de pedido:";
            // 
            // textOrderID
            // 
            this.textOrderID.Location = new System.Drawing.Point(146, 81);
            this.textOrderID.Name = "textOrderID";
            this.textOrderID.Size = new System.Drawing.Size(100, 20);
            this.textOrderID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Si está rellenando un pedido, especifique";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "la fecha rellenada";
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFillDate.Location = new System.Drawing.Point(249, 118);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(115, 20);
            this.dtpFillDate.TabIndex = 5;
            // 
            // dgvCustomerOrders
            // 
            this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOrders.Location = new System.Drawing.Point(27, 157);
            this.dgvCustomerOrders.Name = "dgvCustomerOrders";
            this.dgvCustomerOrders.ReadOnly = true;
            this.dgvCustomerOrders.RowHeadersVisible = false;
            this.dgvCustomerOrders.Size = new System.Drawing.Size(365, 88);
            this.dgvCustomerOrders.TabIndex = 6;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(28, 261);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(102, 26);
            this.btnCancelOrder.TabIndex = 7;
            this.btnCancelOrder.Text = "Cancelar pedido";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnFillOrder
            // 
            this.btnFillOrder.Location = new System.Drawing.Point(136, 261);
            this.btnFillOrder.Name = "btnFillOrder";
            this.btnFillOrder.Size = new System.Drawing.Size(98, 26);
            this.btnFillOrder.TabIndex = 8;
            this.btnFillOrder.Text = "Rellenar pedido";
            this.btnFillOrder.UseVisualStyleBackColor = true;
            this.btnFillOrder.Click += new System.EventHandler(this.btnFillOrder_Click);
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.Location = new System.Drawing.Point(318, 261);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(75, 26);
            this.btnFinishOrder.TabIndex = 9;
            this.btnFinishOrder.Text = "Finalizar";
            this.btnFinishOrder.UseVisualStyleBackColor = true;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.customerBindingSource;
            this.comboBox1.DisplayMember = "CustomerName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "CustomerID";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.appPedidosDataSetBindingSource1;
            // 
            // appPedidosDataSetBindingSource1
            // 
            this.appPedidosDataSetBindingSource1.DataSource = this.appPedidosDataSet;
            this.appPedidosDataSetBindingSource1.Position = 0;
            // 
            // appPedidosDataSet
            // 
            this.appPedidosDataSet.DataSetName = "AppPedidosDataSet";
            this.appPedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar por ID Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // appPedidosDataSetBindingSource
            // 
            this.appPedidosDataSetBindingSource.DataSource = this.appPedidosDataSet;
            this.appPedidosDataSetBindingSource.Position = 0;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // FillOrCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.btnFillOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.dgvCustomerOrders);
            this.Controls.Add(this.dtpFillDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindByOrderID);
            this.Name = "FillOrCancel";
            this.Text = "Rellenar o cancelar un pedido";
            this.Load += new System.EventHandler(this.FillOrCancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appPedidosDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appPedidosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appPedidosDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindByOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFillDate;
        private System.Windows.Forms.DataGridView dgvCustomerOrders;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnFillOrder;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource appPedidosDataSetBindingSource1;
        private AppPedidosDataSet appPedidosDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource appPedidosDataSetBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private AppPedidosDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}