namespace caso1
{
    partial class caso1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            txtResult = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Trebuchet MS", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(28, 107);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 18);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el precio del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 128);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Trebuchet MS", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(28, 180);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 18);
            label3.TabIndex = 2;
            label3.Text = "Ingrese la cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 200);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 22);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(130, 130);
            txtPrecio.Margin = new Padding(2, 1, 2, 1);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 23);
            txtPrecio.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(130, 202);
            txtCantidad.Margin = new Padding(2, 1, 2, 1);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(110, 23);
            txtCantidad.TabIndex = 5;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.ScrollBar;
            txtResult.Enabled = false;
            txtResult.Font = new Font("Times New Roman", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.ForeColor = SystemColors.ActiveCaptionText;
            txtResult.Location = new Point(6, 22);
            txtResult.Margin = new Padding(2, 1, 2, 1);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(359, 32);
            txtResult.TabIndex = 6;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.Menu;
            btnCalcular.Font = new Font("Times New Roman", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(153, 235);
            btnCalcular.Margin = new Padding(2, 1, 2, 1);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 30);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.TextAlign = ContentAlignment.BottomCenter;
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // caso1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(376, 275);
            Controls.Add(btnCalcular);
            Controls.Add(txtResult);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "caso1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private TextBox txtResult;
        private Button btnCalcular;
    }
}