namespace Vigenere
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtTextoDescriptografado = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDescriptSemChave = new System.Windows.Forms.Button();
            this.btnDescriptComChave = new System.Windows.Forms.Button();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.lblChave = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtTextoCriptografado = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtPossiveisResultados = new System.Windows.Forms.RichTextBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 265);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtTextoDescriptografado);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(657, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 265);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Texto descriptografado com chave conhecida";
            // 
            // rtTextoDescriptografado
            // 
            this.rtTextoDescriptografado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtTextoDescriptografado.Location = new System.Drawing.Point(3, 16);
            this.rtTextoDescriptografado.Name = "rtTextoDescriptografado";
            this.rtTextoDescriptografado.Size = new System.Drawing.Size(300, 246);
            this.rtTextoDescriptografado.TabIndex = 2;
            this.rtTextoDescriptografado.Text = "";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(654, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 265);
            this.splitter2.TabIndex = 15;
            this.splitter2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDescriptSemChave);
            this.groupBox3.Controls.Add(this.btnDescriptComChave);
            this.groupBox3.Controls.Add(this.txtChave);
            this.groupBox3.Controls.Add(this.lblChave);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(487, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 265);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acoes";
            // 
            // btnDescriptSemChave
            // 
            this.btnDescriptSemChave.Location = new System.Drawing.Point(6, 153);
            this.btnDescriptSemChave.Name = "btnDescriptSemChave";
            this.btnDescriptSemChave.Size = new System.Drawing.Size(155, 38);
            this.btnDescriptSemChave.TabIndex = 8;
            this.btnDescriptSemChave.Text = "Descriptografar sem Chave";
            this.btnDescriptSemChave.UseVisualStyleBackColor = true;
            this.btnDescriptSemChave.Click += new System.EventHandler(this.btnDescriptSemChave_Click);
            // 
            // btnDescriptComChave
            // 
            this.btnDescriptComChave.Location = new System.Drawing.Point(6, 84);
            this.btnDescriptComChave.Name = "btnDescriptComChave";
            this.btnDescriptComChave.Size = new System.Drawing.Size(155, 43);
            this.btnDescriptComChave.TabIndex = 7;
            this.btnDescriptComChave.Text = "Descriptografar com Chave";
            this.btnDescriptComChave.UseVisualStyleBackColor = true;
            this.btnDescriptComChave.Click += new System.EventHandler(this.btnDescriptComChave_Click);
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(6, 58);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(100, 20);
            this.txtChave.TabIndex = 6;
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(8, 42);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(38, 13);
            this.lblChave.TabIndex = 5;
            this.lblChave.Text = "Chave";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(484, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 265);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtTextoCriptografado);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 265);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Texto Criptografado";
            // 
            // rtTextoCriptografado
            // 
            this.rtTextoCriptografado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtTextoCriptografado.Location = new System.Drawing.Point(3, 16);
            this.rtTextoCriptografado.Name = "rtTextoCriptografado";
            this.rtTextoCriptografado.Size = new System.Drawing.Size(478, 246);
            this.rtTextoCriptografado.TabIndex = 1;
            this.rtTextoCriptografado.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 266);
            this.panel2.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtPossiveisResultados);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(963, 266);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultados";
            // 
            // rtPossiveisResultados
            // 
            this.rtPossiveisResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtPossiveisResultados.Location = new System.Drawing.Point(3, 16);
            this.rtPossiveisResultados.Name = "rtPossiveisResultados";
            this.rtPossiveisResultados.Size = new System.Drawing.Size(957, 247);
            this.rtPossiveisResultados.TabIndex = 15;
            this.rtPossiveisResultados.Text = "";
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 265);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(963, 3);
            this.splitter3.TabIndex = 8;
            this.splitter3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 531);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Vigenere";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.RichTextBox rtTextoDescriptografado;
        private System.Windows.Forms.Button btnDescriptSemChave;
        private System.Windows.Forms.Button btnDescriptComChave;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.RichTextBox rtTextoCriptografado;
        private System.Windows.Forms.RichTextBox rtPossiveisResultados;
    }
}

