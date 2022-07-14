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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.produtosDataSet = new Main.ProdutosDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new Main.ProdutosDataSetTableAdapters.ProdutosTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eleminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Atualizar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtID = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMarca = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPreco = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNome = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tableAdapterManager = new Main.ProdutosDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
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
            this.tabPage2.Size = new System.Drawing.Size(1020, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualizar Dados";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produtosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.produtosDataGridView.ColumnHeadersHeight = 29;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Eleminar,
            this.Atualizar});
            this.produtosDataGridView.DataSource = this.produtosBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produtosDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.produtosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produtosDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.produtosDataGridView.Location = new System.Drawing.Point(3, 3);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.RowHeadersWidth = 51;
            this.produtosDataGridView.RowTemplate.Height = 24;
            this.produtosDataGridView.Size = new System.Drawing.Size(1014, 419);
            this.produtosDataGridView.TabIndex = 0;
            this.produtosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // Eleminar
            // 
            this.Eleminar.HeaderText = "Eliminar";
            this.Eleminar.Image = global::Main.Properties.Resources.trash_2_32;
            this.Eleminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eleminar.MinimumWidth = 6;
            this.Eleminar.Name = "Eleminar";
            this.Eleminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Atualizar
            // 
            this.Atualizar.HeaderText = "Atualizar";
            this.Atualizar.Image = global::Main.Properties.Resources.save_32;
            this.Atualizar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Atualizar.MinimumWidth = 6;
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtMarca);
            this.tabPage1.Controls.Add(this.txtPreco);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.ImageKey = "edit.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inserir Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.AnimateReadOnly = false;
            this.txtID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtID.Depth = 0;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.HideSelection = true;
            this.txtID.Hint = "ID";
            this.txtID.LeadingIcon = null;
            this.txtID.Location = new System.Drawing.Point(58, 54);
            this.txtID.MaxLength = 50;
            this.txtID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtID.PrefixSuffixText = null;
            this.txtID.ReadOnly = false;
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(233, 48);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID.TrailingIcon = null;
            this.txtID.UseSystemPasswordChar = false;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(566, 258);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(76, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Inserir";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.btnEnviar);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Main.Properties.Resources.cancel_button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(751, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnLimpar);
            // 
            // txtMarca
            // 
            this.txtMarca.AnimateReadOnly = false;
            this.txtMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMarca.Depth = 0;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMarca.HideSelection = true;
            this.txtMarca.Hint = "Marca";
            this.txtMarca.LeadingIcon = null;
            this.txtMarca.Location = new System.Drawing.Point(566, 173);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtMarca.PrefixSuffixText = null;
            this.txtMarca.ReadOnly = false;
            this.txtMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.ShortcutsEnabled = true;
            this.txtMarca.Size = new System.Drawing.Size(233, 48);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.TabStop = false;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMarca.TrailingIcon = null;
            this.txtMarca.UseSystemPasswordChar = false;
            // 
            // txtPreco
            // 
            this.txtPreco.AnimateReadOnly = false;
            this.txtPreco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPreco.Depth = 0;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPreco.HideSelection = true;
            this.txtPreco.Hint = "Preço";
            this.txtPreco.LeadingIcon = null;
            this.txtPreco.Location = new System.Drawing.Point(58, 173);
            this.txtPreco.MaxLength = 50;
            this.txtPreco.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtPreco.PrefixSuffixText = null;
            this.txtPreco.ReadOnly = false;
            this.txtPreco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPreco.SelectedText = "";
            this.txtPreco.SelectionLength = 0;
            this.txtPreco.SelectionStart = 0;
            this.txtPreco.ShortcutsEnabled = true;
            this.txtPreco.Size = new System.Drawing.Size(233, 48);
            this.txtPreco.TabIndex = 2;
            this.txtPreco.TabStop = false;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPreco.TrailingIcon = null;
            this.txtPreco.UseSystemPasswordChar = false;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(566, 54);
            this.txtNome.MaxLength = 50;
            this.txtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(233, 48);
            this.txtNome.TabIndex = 1;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
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
            this.materialTabControl1.Size = new System.Drawing.Size(1028, 468);
            this.materialTabControl1.TabIndex = 8;
            this.materialTabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.materialTabControl1_MouseClick);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Main.ProdutosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Main.Properties.Resources.delete;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 135;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::Main.Properties.Resources.edit;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1034, 535);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desafio 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private ProdutosDataSet produtosDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private ProdutosDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTextBox2 txtID;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialTextBox2 txtMarca;
        private MaterialSkin.Controls.MaterialTextBox2 txtPreco;
        private MaterialSkin.Controls.MaterialTextBox2 txtNome;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private ProdutosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn Eleminar;
        private System.Windows.Forms.DataGridViewImageColumn Atualizar;
    }
}

