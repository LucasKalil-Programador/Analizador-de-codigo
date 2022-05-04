namespace AnalyzerMain.Lexicon
{
    partial class Window
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.codeTextArea = new System.Windows.Forms.RichTextBox();
            this.codePanelAnalize = new System.Windows.Forms.Label();
            this.tokensLayout = new System.Windows.Forms.TableLayoutPanel();
            this.errorTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorLabel = new System.Windows.Forms.Label();
            this.tokensTable = new System.Windows.Forms.DataGridView();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePanelLabel = new System.Windows.Forms.Label();
            this.optionPanelLabel = new System.Windows.Forms.Label();
            this.optionsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.savePorjectButton = new System.Windows.Forms.Button();
            this.runLayout = new System.Windows.Forms.TableLayoutPanel();
            this.autoAnalize = new System.Windows.Forms.CheckBox();
            this.buttonAnalize = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.openProjectButton = new System.Windows.Forms.Button();
            this.goToAyntacticAnalyzerButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainLayout.SuspendLayout();
            this.tokensLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokensTable)).BeginInit();
            this.optionsLayout.SuspendLayout();
            this.runLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainLayout.Controls.Add(this.codeTextArea, 0, 1);
            this.mainLayout.Controls.Add(this.codePanelAnalize, 0, 0);
            this.mainLayout.Controls.Add(this.tokensLayout, 1, 1);
            this.mainLayout.Controls.Add(this.tablePanelLabel, 1, 0);
            this.mainLayout.Controls.Add(this.optionPanelLabel, 2, 0);
            this.mainLayout.Controls.Add(this.optionsLayout, 2, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.743315F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.25668F));
            this.mainLayout.Size = new System.Drawing.Size(984, 561);
            this.mainLayout.TabIndex = 0;
            // 
            // codeTextArea
            // 
            this.codeTextArea.AcceptsTab = true;
            this.codeTextArea.BackColor = System.Drawing.Color.Silver;
            this.codeTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeTextArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextArea.Location = new System.Drawing.Point(5, 25);
            this.codeTextArea.Margin = new System.Windows.Forms.Padding(5);
            this.codeTextArea.Name = "codeTextArea";
            this.codeTextArea.Size = new System.Drawing.Size(334, 531);
            this.codeTextArea.TabIndex = 0;
            this.codeTextArea.Text = "";
            this.codeTextArea.WordWrap = false;
            this.codeTextArea.TextChanged += new System.EventHandler(this.CodeTextArea_TextChanged);
            // 
            // codePanelAnalize
            // 
            this.codePanelAnalize.AutoSize = true;
            this.codePanelAnalize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codePanelAnalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codePanelAnalize.Location = new System.Drawing.Point(3, 0);
            this.codePanelAnalize.Name = "codePanelAnalize";
            this.codePanelAnalize.Size = new System.Drawing.Size(338, 20);
            this.codePanelAnalize.TabIndex = 3;
            this.codePanelAnalize.Text = "Codigo a ser analizado";
            this.codePanelAnalize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tokensLayout
            // 
            this.tokensLayout.ColumnCount = 1;
            this.tokensLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tokensLayout.Controls.Add(this.errorTable, 0, 2);
            this.tokensLayout.Controls.Add(this.errorLabel, 0, 1);
            this.tokensLayout.Controls.Add(this.tokensTable, 0, 0);
            this.tokensLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tokensLayout.Location = new System.Drawing.Point(347, 23);
            this.tokensLayout.Name = "tokensLayout";
            this.tokensLayout.RowCount = 3;
            this.tokensLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.14049F));
            this.tokensLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tokensLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.85952F));
            this.tokensLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tokensLayout.Size = new System.Drawing.Size(338, 535);
            this.tokensLayout.TabIndex = 3;
            // 
            // errorTable
            // 
            this.errorTable.AllowUserToAddRows = false;
            this.errorTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.errorTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.errorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.errorTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.error});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.errorTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.errorTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorTable.Location = new System.Drawing.Point(5, 360);
            this.errorTable.Margin = new System.Windows.Forms.Padding(5);
            this.errorTable.Name = "errorTable";
            this.errorTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.errorTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.errorTable.Size = new System.Drawing.Size(328, 170);
            this.errorTable.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nº Linha";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Linha onde esse Token foi encontrado";
            // 
            // error
            // 
            this.error.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.error.HeaderText = "Erro encontrado";
            this.error.MinimumWidth = 200;
            this.error.Name = "error";
            this.error.ReadOnly = true;
            this.error.ToolTipText = "Detalhes do Erro";
            this.error.Width = 200;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(3, 335);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(332, 20);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "Erros";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tokensTable
            // 
            this.tokensTable.AllowUserToAddRows = false;
            this.tokensTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tokensTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tokensTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tokensTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Line,
            this.number,
            this.Lexema,
            this.Token});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tokensTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.tokensTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tokensTable.Location = new System.Drawing.Point(5, 2);
            this.tokensTable.Margin = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.tokensTable.Name = "tokensTable";
            this.tokensTable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tokensTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tokensTable.Size = new System.Drawing.Size(328, 328);
            this.tokensTable.TabIndex = 1;
            // 
            // Line
            // 
            this.Line.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Line.HeaderText = "Nº Linha";
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.ToolTipText = "Linha onde esse Token foi encontrado";
            this.Line.Width = 94;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.number.HeaderText = "Nº";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.ToolTipText = "Numero do Token para indentificação";
            this.number.Width = 51;
            // 
            // Lexema
            // 
            this.Lexema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            this.Lexema.ReadOnly = true;
            this.Lexema.ToolTipText = "Lexema encontrado";
            this.Lexema.Width = 90;
            // 
            // Token
            // 
            this.Token.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            this.Token.ToolTipText = "Descrição do lexema";
            this.Token.Width = 78;
            // 
            // tablePanelLabel
            // 
            this.tablePanelLabel.AutoSize = true;
            this.tablePanelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablePanelLabel.Location = new System.Drawing.Point(347, 0);
            this.tablePanelLabel.Name = "tablePanelLabel";
            this.tablePanelLabel.Size = new System.Drawing.Size(338, 20);
            this.tablePanelLabel.TabIndex = 4;
            this.tablePanelLabel.Text = "Tabela de Tokens";
            this.tablePanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionPanelLabel
            // 
            this.optionPanelLabel.AutoSize = true;
            this.optionPanelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionPanelLabel.Location = new System.Drawing.Point(691, 0);
            this.optionPanelLabel.Name = "optionPanelLabel";
            this.optionPanelLabel.Size = new System.Drawing.Size(290, 20);
            this.optionPanelLabel.TabIndex = 5;
            this.optionPanelLabel.Text = "Opções";
            this.optionPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsLayout
            // 
            this.optionsLayout.ColumnCount = 1;
            this.optionsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsLayout.Controls.Add(this.savePorjectButton, 0, 4);
            this.optionsLayout.Controls.Add(this.runLayout, 0, 5);
            this.optionsLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.optionsLayout.Controls.Add(this.openProjectButton, 0, 3);
            this.optionsLayout.Controls.Add(this.goToAyntacticAnalyzerButton, 0, 2);
            this.optionsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsLayout.Location = new System.Drawing.Point(691, 23);
            this.optionsLayout.Name = "optionsLayout";
            this.optionsLayout.RowCount = 6;
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.optionsLayout.Size = new System.Drawing.Size(290, 535);
            this.optionsLayout.TabIndex = 6;
            this.optionsLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.OptionsLayout_Paint);
            // 
            // savePorjectButton
            // 
            this.savePorjectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savePorjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePorjectButton.Location = new System.Drawing.Point(3, 451);
            this.savePorjectButton.Name = "savePorjectButton";
            this.savePorjectButton.Size = new System.Drawing.Size(284, 31);
            this.savePorjectButton.TabIndex = 1;
            this.savePorjectButton.Text = "Salvar projeto";
            this.savePorjectButton.UseVisualStyleBackColor = true;
            this.savePorjectButton.Click += new System.EventHandler(this.SaveProjectButton_Click);
            // 
            // runLayout
            // 
            this.runLayout.ColumnCount = 2;
            this.runLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.runLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.runLayout.Controls.Add(this.autoAnalize, 1, 0);
            this.runLayout.Controls.Add(this.buttonAnalize, 0, 0);
            this.runLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runLayout.Location = new System.Drawing.Point(3, 488);
            this.runLayout.Name = "runLayout";
            this.runLayout.RowCount = 1;
            this.runLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.runLayout.Size = new System.Drawing.Size(284, 44);
            this.runLayout.TabIndex = 3;
            // 
            // autoAnalize
            // 
            this.autoAnalize.AutoSize = true;
            this.autoAnalize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoAnalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoAnalize.Location = new System.Drawing.Point(145, 3);
            this.autoAnalize.Name = "autoAnalize";
            this.autoAnalize.Size = new System.Drawing.Size(136, 38);
            this.autoAnalize.TabIndex = 2;
            this.autoAnalize.Text = "Analizar enquanto digito";
            this.autoAnalize.UseVisualStyleBackColor = true;
            // 
            // buttonAnalize
            // 
            this.buttonAnalize.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAnalize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalize.Location = new System.Drawing.Point(3, 3);
            this.buttonAnalize.Name = "buttonAnalize";
            this.buttonAnalize.Size = new System.Drawing.Size(136, 38);
            this.buttonAnalize.TabIndex = 0;
            this.buttonAnalize.Text = "Analizar codigo";
            this.buttonAnalize.UseVisualStyleBackColor = false;
            this.buttonAnalize.Click += new System.EventHandler(this.ButtonAnalize_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.14085F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.85915F));
            this.tableLayoutPanel1.Controls.Add(this.fontSize, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 31);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // fontSize
            // 
            this.fontSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSize.Location = new System.Drawing.Point(188, 3);
            this.fontSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(93, 26);
            this.fontSize.TabIndex = 4;
            this.fontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fontSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fontSize.ValueChanged += new System.EventHandler(this.FontSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tamanho da fonte";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openProjectButton
            // 
            this.openProjectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openProjectButton.Location = new System.Drawing.Point(3, 414);
            this.openProjectButton.Name = "openProjectButton";
            this.openProjectButton.Size = new System.Drawing.Size(284, 31);
            this.openProjectButton.TabIndex = 6;
            this.openProjectButton.Text = "Abrir projeto";
            this.openProjectButton.UseVisualStyleBackColor = true;
            this.openProjectButton.Click += new System.EventHandler(this.OpenProjectButton_Click);
            // 
            // goToAyntacticAnalyzerButton
            // 
            this.goToAyntacticAnalyzerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goToAyntacticAnalyzerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToAyntacticAnalyzerButton.Location = new System.Drawing.Point(3, 377);
            this.goToAyntacticAnalyzerButton.Name = "goToAyntacticAnalyzerButton";
            this.goToAyntacticAnalyzerButton.Size = new System.Drawing.Size(284, 31);
            this.goToAyntacticAnalyzerButton.TabIndex = 7;
            this.goToAyntacticAnalyzerButton.Text = "Ir para o analizador sintatico";
            this.goToAyntacticAnalyzerButton.UseVisualStyleBackColor = true;
            this.goToAyntacticAnalyzerButton.Click += new System.EventHandler(this.GoToSyntacticAnalyzer_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Arquivos .txt (*.txt)|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Arquivos .txt (*.txt)|*.txt";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.mainLayout);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analizador Lexico";
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.tokensLayout.ResumeLayout(false);
            this.tokensLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokensTable)).EndInit();
            this.optionsLayout.ResumeLayout(false);
            this.runLayout.ResumeLayout(false);
            this.runLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.RichTextBox codeTextArea;
        private System.Windows.Forms.DataGridView tokensTable;
        private System.Windows.Forms.Label codePanelAnalize;
        private System.Windows.Forms.Label tablePanelLabel;
        private System.Windows.Forms.Label optionPanelLabel;
        private System.Windows.Forms.TableLayoutPanel tokensLayout;
        private System.Windows.Forms.DataGridView errorTable;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TableLayoutPanel optionsLayout;
        private System.Windows.Forms.TableLayoutPanel runLayout;
        private System.Windows.Forms.CheckBox autoAnalize;
        private System.Windows.Forms.Button buttonAnalize;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.Button openProjectButton;
        private System.Windows.Forms.Button savePorjectButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button goToAyntacticAnalyzerButton;
    }
}

