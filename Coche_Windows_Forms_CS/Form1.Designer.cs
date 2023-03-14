namespace Coche_Windows_Forms_CS
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
            dgvListaAutos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            cbMotor = new ComboBox();
            cbColor = new ComboBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            btnEnviar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaAutos).BeginInit();
            SuspendLayout();
            // 
            // dgvListaAutos
            // 
            dgvListaAutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaAutos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvListaAutos.Location = new Point(545, 88);
            dgvListaAutos.Name = "dgvListaAutos";
            dgvListaAutos.RowHeadersVisible = false;
            dgvListaAutos.RowHeadersWidth = 51;
            dgvListaAutos.RowTemplate.Height = 29;
            dgvListaAutos.Size = new Size(653, 361);
            dgvListaAutos.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Marca";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Modelo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Motor";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Color";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // cbMotor
            // 
            cbMotor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMotor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMotor.FormattingEnabled = true;
            cbMotor.Items.AddRange(new object[] { "Motor de combustion interna", "Motor electrico", "Motor a reaccion", "Motor de combustion externa", "Motor de combustion de ciclo Striling" });
            cbMotor.Location = new Point(198, 196);
            cbMotor.Name = "cbMotor";
            cbMotor.Size = new Size(249, 31);
            cbMotor.TabIndex = 1;
            // 
            // cbColor
            // 
            cbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbColor.FormattingEnabled = true;
            cbColor.Items.AddRange(new object[] { "Azul", "Verde", "Morado", "Negro", "Rosa", "Rojo", "Blanco" });
            cbColor.Location = new Point(198, 254);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(249, 31);
            cbColor.TabIndex = 2;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(198, 81);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(249, 32);
            txtMarca.TabIndex = 3;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelo.Location = new Point(198, 137);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(249, 32);
            txtModelo.TabIndex = 4;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(198, 339);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(193, 63);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 93);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 6;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 146);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 7;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 204);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 8;
            label3.Text = "Motor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(80, 262);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 9;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(198, 27);
            label5.Name = "label5";
            label5.Size = new Size(819, 34);
            label5.TabIndex = 10;
            label5.Text = "Escoge las caracteristicas que deseas en tu nuevo modelo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 509);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEnviar);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(cbColor);
            Controls.Add(cbMotor);
            Controls.Add(dgvListaAutos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvListaAutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListaAutos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cbMotor;
        private ComboBox cbColor;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private Button btnEnviar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}