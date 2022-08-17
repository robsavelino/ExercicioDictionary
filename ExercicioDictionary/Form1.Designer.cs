namespace ExercicioDictionary
{
    partial class GetVowels
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
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRunScript = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnunciado.Location = new System.Drawing.Point(265, 50);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(270, 25);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Digite a frase na caixa abaixo";
            // 
            // txbInput
            // 
            this.txbInput.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbInput.Location = new System.Drawing.Point(190, 127);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(420, 23);
            this.txbInput.TabIndex = 1;
            this.txbInput.TextChanged += new System.EventHandler(this.txbInput_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(190, 318);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRunScript
            // 
            this.btnRunScript.Location = new System.Drawing.Point(502, 318);
            this.btnRunScript.Name = "btnRunScript";
            this.btnRunScript.Size = new System.Drawing.Size(108, 30);
            this.btnRunScript.TabIndex = 3;
            this.btnRunScript.Text = "Pegar Vogais";
            this.btnRunScript.UseVisualStyleBackColor = true;
            this.btnRunScript.Click += new System.EventHandler(this.btnRunScript_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(346, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(190, 192);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 15);
            this.lblOutput.TabIndex = 5;
            // 
            // GetVowels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRunScript);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.lblEnunciado);
            this.Name = "GetVowels";
            this.Text = "Vogais";
            this.Load += new System.EventHandler(this.GetVowels_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEnunciado;
        private TextBox txbInput;
        private Button btnClear;
        private Button btnRunScript;
        private Button btnClose;
        private Label lblOutput;
    }
}