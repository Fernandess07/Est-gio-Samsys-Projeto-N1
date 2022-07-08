namespace Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.produtosDataSet = new Main.ProdutosDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new Main.ProdutosDataSetTableAdapters.ProdutosTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialTextBox24 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox23 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            this.button1 = new System.Windows.Forms.Button();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tableAdapterManager = new Main.ProdutosDataSetTableAdapters.TableAdapterManager();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "stats.png");
            this.imageList1.Images.SetKeyName(1, "edit.png");
            // 
            // produtosDataSet
            // 
            this.produtosDataSet.DataSetName = "ProdutosDataSet";
            this.produtosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.produtosDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.produtosDataGridView);
            this.tabPage2.ImageKey = "stats.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(889, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualizar Dados";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialTextBox21);
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.materialTextBox22);
            this.tabPage1.Controls.Add(this.materialTextBox23);
            this.tabPage1.Controls.Add(this.materialTextBox24);
            this.tabPage1.ImageKey = "edit.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inserir Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialTextBox24
            // 
            this.materialTextBox24.AnimateReadOnly = false;
            this.materialTextBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox24.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox24.Depth = 0;
            this.materialTextBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox24.HideSelection = true;
            this.materialTextBox24.Hint = "Nome";
            this.materialTextBox24.LeadingIcon = null;
            this.materialTextBox24.Location = new System.Drawing.Point(433, 54);
            this.materialTextBox24.MaxLength = 32767;
            this.materialTextBox24.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox24.Name = "materialTextBox24";
            this.materialTextBox24.PasswordChar = '\0';
            this.materialTextBox24.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.materialTextBox24.PrefixSuffixText = null;
            this.materialTextBox24.ReadOnly = false;
            this.materialTextBox24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox24.SelectedText = "";
            this.materialTextBox24.SelectionLength = 0;
            this.materialTextBox24.SelectionStart = 0;
            this.materialTextBox24.ShortcutsEnabled = true;
            this.materialTextBox24.Size = new System.Drawing.Size(233, 48);
            this.materialTextBox24.TabIndex = 5;
            this.materialTextBox24.TabStop = false;
            this.materialTextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox24.TrailingIcon = null;
            this.materialTextBox24.UseSystemPasswordChar = false;
            // 
            // materialTextBox23
            // 
            this.materialTextBox23.AnimateReadOnly = false;
            this.materialTextBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox23.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox23.Depth = 0;
            this.materialTextBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox23.HideSelection = true;
            this.materialTextBox23.Hint = "Preço";
            this.materialTextBox23.LeadingIcon = null;
            this.materialTextBox23.Location = new System.Drawing.Point(58, 173);
            this.materialTextBox23.MaxLength = 32767;
            this.materialTextBox23.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox23.Name = "materialTextBox23";
            this.materialTextBox23.PasswordChar = '\0';
            this.materialTextBox23.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.materialTextBox23.PrefixSuffixText = null;
            this.materialTextBox23.ReadOnly = false;
            this.materialTextBox23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox23.SelectedText = "";
            this.materialTextBox23.SelectionLength = 0;
            this.materialTextBox23.SelectionStart = 0;
            this.materialTextBox23.ShortcutsEnabled = true;
            this.materialTextBox23.Size = new System.Drawing.Size(233, 48);
            this.materialTextBox23.TabIndex = 4;
            this.materialTextBox23.TabStop = false;
            this.materialTextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox23.TrailingIcon = null;
            this.materialTextBox23.UseSystemPasswordChar = false;
            // 
            // materialTextBox22
            // 
            this.materialTextBox22.AnimateReadOnly = false;
            this.materialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox22.Depth = 0;
            this.materialTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox22.HideSelection = true;
            this.materialTextBox22.Hint = "Marca";
            this.materialTextBox22.LeadingIcon = null;
            this.materialTextBox22.Location = new System.Drawing.Point(433, 173);
            this.materialTextBox22.MaxLength = 32767;
            this.materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox22.Name = "materialTextBox22";
            this.materialTextBox22.PasswordChar = '\0';
            this.materialTextBox22.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.materialTextBox22.PrefixSuffixText = null;
            this.materialTextBox22.ReadOnly = false;
            this.materialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox22.SelectedText = "";
            this.materialTextBox22.SelectionLength = 0;
            this.materialTextBox22.SelectionStart = 0;
            this.materialTextBox22.ShortcutsEnabled = true;
            this.materialTextBox22.Size = new System.Drawing.Size(233, 48);
            this.materialTextBox22.TabIndex = 3;
            this.materialTextBox22.TabStop = false;
            this.materialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox22.TrailingIcon = null;
            this.materialTextBox22.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Main.Properties.Resources.cancel_button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(618, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(484, 267);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(76, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Inserir";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.Hint = "ID";
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(58, 54);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(233, 48);
            this.materialTextBox21.TabIndex = 6;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            this.materialTextBox21.Click += new System.EventHandler(this.materialTextBox21_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(897, 485);
            this.materialTabControl1.TabIndex = 8;
            this.materialTabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.materialTabControl1_MouseClick);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Main.ProdutosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AllowUserToAddRows = false;
            this.produtosDataGridView.AllowUserToResizeColumns = false;
            this.produtosDataGridView.AllowUserToResizeRows = false;
            this.produtosDataGridView.AutoGenerateColumns = false;
            this.produtosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.produtosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.produtosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.produtosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.produtosDataGridView.DataSource = this.produtosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produtosDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.produtosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produtosDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.produtosDataGridView.Location = new System.Drawing.Point(3, 3);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.RowHeadersWidth = 51;
            this.produtosDataGridView.RowTemplate.Height = 24;
            this.produtosDataGridView.Size = new System.Drawing.Size(883, 436);
            this.produtosDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MARCA";
            this.dataGridViewTextBoxColumn3.HeaderText = "MARCA";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PRECO";
            this.dataGridViewTextBoxColumn4.HeaderText = "PRECO";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 552);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desafio 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private ProdutosDataSet produtosDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private ProdutosDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox23;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox24;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private ProdutosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

