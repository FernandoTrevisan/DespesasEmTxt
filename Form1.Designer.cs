namespace despesas
{
    partial class Form1
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
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.BtnMTodos = new System.Windows.Forms.Button();
            this.BtnDTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelecao = new System.Windows.Forms.Label();
            this.BtnBaixar = new System.Windows.Forms.Button();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Location = new System.Drawing.Point(11, 102);
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.Size = new System.Drawing.Size(380, 182);
            this.dgvDespesas.TabIndex = 4;
            this.dgvDespesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDespesas_CellClick);
            // 
            // BtnImportar
            // 
            this.BtnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImportar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImportar.Font = new System.Drawing.Font("MS Gothic", 17.25F, System.Drawing.FontStyle.Bold);
            this.BtnImportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnImportar.Location = new System.Drawing.Point(15, 22);
            this.BtnImportar.Name = "BtnImportar";
            this.BtnImportar.Size = new System.Drawing.Size(132, 37);
            this.BtnImportar.TabIndex = 0;
            this.BtnImportar.Text = "Importar";
            this.BtnImportar.UseVisualStyleBackColor = true;
            this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // BtnMTodos
            // 
            this.BtnMTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMTodos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMTodos.Font = new System.Drawing.Font("MS Gothic", 13.25F);
            this.BtnMTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMTodos.Location = new System.Drawing.Point(248, 22);
            this.BtnMTodos.Name = "BtnMTodos";
            this.BtnMTodos.Size = new System.Drawing.Size(144, 29);
            this.BtnMTodos.TabIndex = 1;
            this.BtnMTodos.Text = "Marcar todos";
            this.BtnMTodos.UseVisualStyleBackColor = true;
            this.BtnMTodos.Click += new System.EventHandler(this.BtnMTodos_Click);
            // 
            // BtnDTodos
            // 
            this.BtnDTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDTodos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDTodos.Font = new System.Drawing.Font("MS Gothic", 13.25F);
            this.BtnDTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDTodos.Location = new System.Drawing.Point(233, 57);
            this.BtnDTodos.Name = "BtnDTodos";
            this.BtnDTodos.Size = new System.Drawing.Size(159, 29);
            this.BtnDTodos.TabIndex = 2;
            this.BtnDTodos.Text = "Desmarcar todos";
            this.BtnDTodos.UseVisualStyleBackColor = true;
            this.BtnDTodos.Click += new System.EventHandler(this.BtnDTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 15.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(11, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("MS Gothic", 17.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(63, 299);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 23);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 13.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(181, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecionados:";
            // 
            // lblSelecao
            // 
            this.lblSelecao.AutoSize = true;
            this.lblSelecao.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecao.Font = new System.Drawing.Font("MS Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.lblSelecao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelecao.Location = new System.Drawing.Point(288, 301);
            this.lblSelecao.Name = "lblSelecao";
            this.lblSelecao.Size = new System.Drawing.Size(58, 21);
            this.lblSelecao.TabIndex = 7;
            this.lblSelecao.Text = "test";
            // 
            // BtnBaixar
            // 
            this.BtnBaixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBaixar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBaixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBaixar.Font = new System.Drawing.Font("MS Gothic", 17.25F, System.Drawing.FontStyle.Bold);
            this.BtnBaixar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBaixar.Location = new System.Drawing.Point(124, 351);
            this.BtnBaixar.Name = "BtnBaixar";
            this.BtnBaixar.Size = new System.Drawing.Size(268, 33);
            this.BtnBaixar.TabIndex = 3;
            this.BtnBaixar.Text = "Baixar selecionados";
            this.BtnBaixar.UseVisualStyleBackColor = true;
            this.BtnBaixar.Click += new System.EventHandler(this.BtnBaixar_Click);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(403, 406);
            this.Controls.Add(this.BtnBaixar);
            this.Controls.Add(this.lblSelecao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDTodos);
            this.Controls.Add(this.BtnMTodos);
            this.Controls.Add(this.BtnImportar);
            this.Controls.Add(this.dgvDespesas);
            this.Name = "Form1";
            this.Text = "Despezo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.Button BtnImportar;
        private System.Windows.Forms.Button BtnMTodos;
        private System.Windows.Forms.Button BtnDTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelecao;
        private System.Windows.Forms.Button BtnBaixar;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}

