namespace FindValueCripto.Formularios
{
    partial class Frm_CalculoCripto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CalculoCripto));
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Lbl_Cripto = new System.Windows.Forms.Label();
            this.Lbl_ValorCripto = new System.Windows.Forms.Label();
            this.Lbl_ValorCalculado = new System.Windows.Forms.Label();
            this.Mtb_Quantidade = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Location = new System.Drawing.Point(105, 92);
            this.Btn_Calcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(146, 31);
            this.Btn_Calcular.TabIndex = 1;
            this.Btn_Calcular.Text = "Btn_Calcular";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(257, 92);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(86, 31);
            this.Btn_Sair.TabIndex = 2;
            this.Btn_Sair.Text = "Btn_Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Lbl_Cripto
            // 
            this.Lbl_Cripto.AutoSize = true;
            this.Lbl_Cripto.Location = new System.Drawing.Point(14, 9);
            this.Lbl_Cripto.Name = "Lbl_Cripto";
            this.Lbl_Cripto.Size = new System.Drawing.Size(69, 20);
            this.Lbl_Cripto.TabIndex = 3;
            this.Lbl_Cripto.Text = "Lbl_Cripto";
            // 
            // Lbl_ValorCripto
            // 
            this.Lbl_ValorCripto.AutoSize = true;
            this.Lbl_ValorCripto.Location = new System.Drawing.Point(17, 52);
            this.Lbl_ValorCripto.Name = "Lbl_ValorCripto";
            this.Lbl_ValorCripto.Size = new System.Drawing.Size(100, 20);
            this.Lbl_ValorCripto.TabIndex = 4;
            this.Lbl_ValorCripto.Text = "Lbl_ValorCripto";
            // 
            // Lbl_ValorCalculado
            // 
            this.Lbl_ValorCalculado.AutoSize = true;
            this.Lbl_ValorCalculado.Location = new System.Drawing.Point(105, 52);
            this.Lbl_ValorCalculado.Name = "Lbl_ValorCalculado";
            this.Lbl_ValorCalculado.Size = new System.Drawing.Size(124, 20);
            this.Lbl_ValorCalculado.TabIndex = 5;
            this.Lbl_ValorCalculado.Text = "Lbl_ValorCalculado";
            // 
            // Mtb_Quantidade
            // 
            this.Mtb_Quantidade.Location = new System.Drawing.Point(14, 94);
            this.Mtb_Quantidade.Mask = "000.0000000";
            this.Mtb_Quantidade.Name = "Mtb_Quantidade";
            this.Mtb_Quantidade.Size = new System.Drawing.Size(85, 26);
            this.Mtb_Quantidade.TabIndex = 6;
            this.Mtb_Quantidade.Text = "0000000000";
            this.Mtb_Quantidade.MouseHover += new System.EventHandler(this.Mtb_Quantidade_MouseHover);
            // 
            // Frm_CalculoCripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 139);
            this.Controls.Add(this.Mtb_Quantidade);
            this.Controls.Add(this.Lbl_ValorCalculado);
            this.Controls.Add(this.Lbl_ValorCripto);
            this.Controls.Add(this.Lbl_Cripto);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Calcular);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_CalculoCripto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CalculoCripto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Btn_Calcular;
        private Button Btn_Sair;
        private Label Lbl_Cripto;
        private Label Lbl_ValorCripto;
        private Label Lbl_ValorCalculado;
        private MaskedTextBox Mtb_Quantidade;
    }
}