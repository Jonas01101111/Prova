namespace Prova
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbVenda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalDinheiros = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btAltQuantItem = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btGravaVenda = new System.Windows.Forms.Button();
            this.btCancelaVenda = new System.Windows.Forms.Button();
            this.btFechaTudo = new System.Windows.Forms.Button();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.tbQuant = new System.Windows.Forms.TextBox();
            this.tbValorU = new System.Windows.Forms.TextBox();
            this.tbAltQuantItem = new System.Windows.Forms.TextBox();
            this.DGVDados = new System.Windows.Forms.DataGridView();
            this.Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Unitário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 582);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alterar qtd. do item:";
            // 
            // lbVenda
            // 
            this.lbVenda.AutoSize = true;
            this.lbVenda.Font = new System.Drawing.Font("Roboto", 18F);
            this.lbVenda.ForeColor = System.Drawing.Color.Red;
            this.lbVenda.Location = new System.Drawing.Point(166, 20);
            this.lbVenda.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbVenda.Name = "lbVenda";
            this.lbVenda.Size = new System.Drawing.Size(27, 29);
            this.lbVenda.TabIndex = 2;
            this.lbVenda.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantidade:";
            // 
            // lbTotalDinheiros
            // 
            this.lbTotalDinheiros.AutoSize = true;
            this.lbTotalDinheiros.Font = new System.Drawing.Font("Roboto", 18F);
            this.lbTotalDinheiros.ForeColor = System.Drawing.Color.Blue;
            this.lbTotalDinheiros.Location = new System.Drawing.Point(181, 643);
            this.lbTotalDinheiros.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTotalDinheiros.Name = "lbTotalDinheiros";
            this.lbTotalDinheiros.Size = new System.Drawing.Size(95, 29);
            this.lbTotalDinheiros.TabIndex = 6;
            this.lbTotalDinheiros.Text = "R$ 0,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 651);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total da venda:";
            // 
            // btAltQuantItem
            // 
            this.btAltQuantItem.Location = new System.Drawing.Point(448, 579);
            this.btAltQuantItem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btAltQuantItem.Name = "btAltQuantItem";
            this.btAltQuantItem.Size = new System.Drawing.Size(198, 30);
            this.btAltQuantItem.TabIndex = 8;
            this.btAltQuantItem.Text = "Alterar Quantidade";
            this.btAltQuantItem.UseVisualStyleBackColor = true;
            this.btAltQuantItem.Click += new System.EventHandler(this.btAltQuantItem_Click);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(448, 184);
            this.btInserir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(137, 79);
            this.btInserir.TabIndex = 9;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(648, 184);
            this.btRemover.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(137, 79);
            this.btRemover.TabIndex = 10;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btGravaVenda
            // 
            this.btGravaVenda.Location = new System.Drawing.Point(202, 704);
            this.btGravaVenda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btGravaVenda.Name = "btGravaVenda";
            this.btGravaVenda.Size = new System.Drawing.Size(137, 79);
            this.btGravaVenda.TabIndex = 11;
            this.btGravaVenda.Text = "Gravar venda";
            this.btGravaVenda.UseVisualStyleBackColor = true;
            this.btGravaVenda.Click += new System.EventHandler(this.btGravaVenda_Click);
            // 
            // btCancelaVenda
            // 
            this.btCancelaVenda.Location = new System.Drawing.Point(376, 704);
            this.btCancelaVenda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btCancelaVenda.Name = "btCancelaVenda";
            this.btCancelaVenda.Size = new System.Drawing.Size(137, 79);
            this.btCancelaVenda.TabIndex = 12;
            this.btCancelaVenda.Text = "Cancelar venda";
            this.btCancelaVenda.UseVisualStyleBackColor = true;
            this.btCancelaVenda.Click += new System.EventHandler(this.btCancelaVenda_Click);
            // 
            // btFechaTudo
            // 
            this.btFechaTudo.Location = new System.Drawing.Point(549, 704);
            this.btFechaTudo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btFechaTudo.Name = "btFechaTudo";
            this.btFechaTudo.Size = new System.Drawing.Size(137, 79);
            this.btFechaTudo.TabIndex = 13;
            this.btFechaTudo.Text = "Finalizar venda";
            this.btFechaTudo.UseVisualStyleBackColor = true;
            this.btFechaTudo.Click += new System.EventHandler(this.btFechaTudo_Click);
            // 
            // tbProduto
            // 
            this.tbProduto.Location = new System.Drawing.Point(164, 92);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.Size = new System.Drawing.Size(681, 27);
            this.tbProduto.TabIndex = 14;
            // 
            // tbQuant
            // 
            this.tbQuant.Location = new System.Drawing.Point(164, 169);
            this.tbQuant.Name = "tbQuant";
            this.tbQuant.Size = new System.Drawing.Size(175, 27);
            this.tbQuant.TabIndex = 15;
            // 
            // tbValorU
            // 
            this.tbValorU.Location = new System.Drawing.Point(164, 236);
            this.tbValorU.Name = "tbValorU";
            this.tbValorU.Size = new System.Drawing.Size(175, 27);
            this.tbValorU.TabIndex = 16;
            // 
            // tbAltQuantItem
            // 
            this.tbAltQuantItem.Location = new System.Drawing.Point(186, 579);
            this.tbAltQuantItem.Name = "tbAltQuantItem";
            this.tbAltQuantItem.Size = new System.Drawing.Size(227, 27);
            this.tbAltQuantItem.TabIndex = 17;
            // 
            // DGVDados
            // 
            this.DGVDados.AllowUserToAddRows = false;
            this.DGVDados.AllowUserToDeleteRows = false;
            this.DGVDados.AllowUserToOrderColumns = true;
            this.DGVDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produtos,
            this.Quantidades,
            this.ValorU,
            this.Total});
            this.DGVDados.Location = new System.Drawing.Point(101, 307);
            this.DGVDados.Name = "DGVDados";
            this.DGVDados.ReadOnly = true;
            this.DGVDados.Size = new System.Drawing.Size(744, 231);
            this.DGVDados.TabIndex = 18;
            this.DGVDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDados_CellClick);
            // 
            // Produtos
            // 
            this.Produtos.HeaderText = "Produtos";
            this.Produtos.Name = "Produtos";
            this.Produtos.ReadOnly = true;
            // 
            // Quantidades
            // 
            this.Quantidades.HeaderText = "Quantidade";
            this.Quantidades.Name = "Quantidades";
            this.Quantidades.ReadOnly = true;
            // 
            // ValorU
            // 
            this.ValorU.HeaderText = "V.Unitário";
            this.ValorU.Name = "ValorU";
            this.ValorU.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "total :)";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 938);
            this.Controls.Add(this.DGVDados);
            this.Controls.Add(this.tbAltQuantItem);
            this.Controls.Add(this.tbValorU);
            this.Controls.Add(this.tbQuant);
            this.Controls.Add(this.tbProduto);
            this.Controls.Add(this.btFechaTudo);
            this.Controls.Add(this.btCancelaVenda);
            this.Controls.Add(this.btGravaVenda);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.btAltQuantItem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTotalDinheiros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalDinheiros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btAltQuantItem;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btGravaVenda;
        private System.Windows.Forms.Button btCancelaVenda;
        private System.Windows.Forms.Button btFechaTudo;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.TextBox tbQuant;
        private System.Windows.Forms.TextBox tbValorU;
        private System.Windows.Forms.TextBox tbAltQuantItem;
        private System.Windows.Forms.DataGridView DGVDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

