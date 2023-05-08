namespace Projeto_Locadora_Finalizado
{
    partial class FrmModelo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListarModelos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnAtivos = new System.Windows.Forms.Button();
            this.BtnInativos = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.PcbVoltar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarModelos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 62);
            this.panel1.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODELO";
            // 
            // DgvListarModelos
            // 
            this.DgvListarModelos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListarModelos.BackgroundColor = System.Drawing.Color.White;
            this.DgvListarModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListarModelos.Location = new System.Drawing.Point(31, 234);
            this.DgvListarModelos.Name = "DgvListarModelos";
            this.DgvListarModelos.Size = new System.Drawing.Size(585, 267);
            this.DgvListarModelos.TabIndex = 55;
            this.DgvListarModelos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListarModelos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CmbStatus);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(108, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 129);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS EXISTENTES";
            // 
            // CmbStatus
            // 
            this.CmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbStatus.BackColor = System.Drawing.Color.Black;
            this.CmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CmbStatus.ForeColor = System.Drawing.Color.White;
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.CmbStatus.Location = new System.Drawing.Point(87, 88);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(444, 28);
            this.CmbStatus.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 25);
            this.label15.TabIndex = 51;
            this.label15.Text = "Status:";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.BackColor = System.Drawing.Color.Black;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(125, 53);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(406, 29);
            this.txtDesc.TabIndex = 26;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.BackColor = System.Drawing.Color.Black;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(51, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(480, 29);
            this.txtId.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "ID:";
            // 
            // BtnAtivos
            // 
            this.BtnAtivos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAtivos.BackColor = System.Drawing.Color.Brown;
            this.BtnAtivos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtivos.ForeColor = System.Drawing.Color.White;
            this.BtnAtivos.Image = global::Projeto_Locadora_Finalizado.Properties.Resources.ativosIconBranco;
            this.BtnAtivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAtivos.Location = new System.Drawing.Point(157, 500);
            this.BtnAtivos.Name = "BtnAtivos";
            this.BtnAtivos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnAtivos.Size = new System.Drawing.Size(142, 36);
            this.BtnAtivos.TabIndex = 70;
            this.BtnAtivos.Text = "   Ativados";
            this.BtnAtivos.UseVisualStyleBackColor = false;
            this.BtnAtivos.Click += new System.EventHandler(this.BtnAtivos_Click);
            // 
            // BtnInativos
            // 
            this.BtnInativos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnInativos.BackColor = System.Drawing.Color.Brown;
            this.BtnInativos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInativos.ForeColor = System.Drawing.Color.White;
            this.BtnInativos.Image = global::Projeto_Locadora_Finalizado.Properties.Resources.inativadosIconBranco;
            this.BtnInativos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInativos.Location = new System.Drawing.Point(352, 500);
            this.BtnInativos.Name = "BtnInativos";
            this.BtnInativos.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnInativos.Size = new System.Drawing.Size(142, 36);
            this.BtnInativos.TabIndex = 69;
            this.BtnInativos.Text = "    Inativados";
            this.BtnInativos.UseVisualStyleBackColor = false;
            this.BtnInativos.Click += new System.EventHandler(this.BtnInativos_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastrar.BackColor = System.Drawing.Color.Brown;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Image = global::Projeto_Locadora_Finalizado.Properties.Resources.cadastrarIconBranco;
            this.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastrar.Location = new System.Drawing.Point(639, 380);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(149, 54);
            this.BtnCadastrar.TabIndex = 68;
            this.BtnCadastrar.Text = "         Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtualizar.BackColor = System.Drawing.Color.Brown;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Image = global::Projeto_Locadora_Finalizado.Properties.Resources.atualizarIconBranco;
            this.BtnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAtualizar.Location = new System.Drawing.Point(639, 300);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(149, 54);
            this.BtnAtualizar.TabIndex = 67;
            this.BtnAtualizar.Text = "        Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAtualizar_MouseClick);
            // 
            // PcbVoltar
            // 
            this.PcbVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PcbVoltar.Image = global::Projeto_Locadora_Finalizado.Properties.Resources.voltarIcon;
            this.PcbVoltar.Location = new System.Drawing.Point(746, 12);
            this.PcbVoltar.Name = "PcbVoltar";
            this.PcbVoltar.Size = new System.Drawing.Size(52, 51);
            this.PcbVoltar.TabIndex = 71;
            this.PcbVoltar.TabStop = false;
            this.PcbVoltar.Click += new System.EventHandler(this.PcbVoltar_Click_1);
            // 
            // FrmModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(810, 554);
            this.Controls.Add(this.PcbVoltar);
            this.Controls.Add(this.BtnAtivos);
            this.Controls.Add(this.BtnInativos);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvListarModelos);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmModelo";
            this.Text = "MODELO";
            this.Load += new System.EventHandler(this.FrmModelo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarModelos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbVoltar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvListarModelos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnAtivos;
        private System.Windows.Forms.Button BtnInativos;
        private System.Windows.Forms.PictureBox PcbVoltar;
    }
}