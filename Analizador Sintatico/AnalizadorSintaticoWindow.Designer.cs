namespace AnalyzerMain.Syntactic
{
    partial class Window
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
            this.goToLexiconAnalyzerButton = new System.Windows.Forms.Button();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.codeTextArea = new System.Windows.Forms.RichTextBox();
            this.codePanelAnalize = new System.Windows.Forms.Label();
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
            this.errorsTextAreaLabel = new System.Windows.Forms.Label();
            this.errorsTextArea = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainLayout.SuspendLayout();
            this.optionsLayout.SuspendLayout();
            this.runLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // goToLexiconAnalyzerButton
            // 
            this.goToLexiconAnalyzerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goToLexiconAnalyzerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToLexiconAnalyzerButton.Location = new System.Drawing.Point(3, 377);
            this.goToLexiconAnalyzerButton.Name = "goToLexiconAnalyzerButton";
            this.goToLexiconAnalyzerButton.Size = new System.Drawing.Size(284, 31);
            this.goToLexiconAnalyzerButton.TabIndex = 0;
            this.goToLexiconAnalyzerButton.Text = "Ir para o analizador lexico";
            this.goToLexiconAnalyzerButton.UseVisualStyleBackColor = true;
            this.goToLexiconAnalyzerButton.Click += new System.EventHandler(this.GoToLexiconAnalyzerButton_Click);
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainLayout.Controls.Add(this.codeTextArea, 0, 1);
            this.mainLayout.Controls.Add(this.codePanelAnalize, 0, 0);
            this.mainLayout.Controls.Add(this.optionPanelLabel, 2, 0);
            this.mainLayout.Controls.Add(this.optionsLayout, 2, 1);
            this.mainLayout.Controls.Add(this.errorsTextAreaLabel, 1, 0);
            this.mainLayout.Controls.Add(this.errorsTextArea, 1, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.743315F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.25668F));
            this.mainLayout.Size = new System.Drawing.Size(984, 561);
            this.mainLayout.TabIndex = 1;
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
            this.optionsLayout.Controls.Add(this.goToLexiconAnalyzerButton, 0, 2);
            this.optionsLayout.Controls.Add(this.runLayout, 0, 5);
            this.optionsLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.optionsLayout.Controls.Add(this.openProjectButton, 0, 3);
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
            // errorsTextAreaLabel
            // 
            this.errorsTextAreaLabel.AutoSize = true;
            this.errorsTextAreaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorsTextAreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorsTextAreaLabel.Location = new System.Drawing.Point(347, 0);
            this.errorsTextAreaLabel.Name = "errorsTextAreaLabel";
            this.errorsTextAreaLabel.Size = new System.Drawing.Size(338, 20);
            this.errorsTextAreaLabel.TabIndex = 7;
            this.errorsTextAreaLabel.Text = "Erros";
            this.errorsTextAreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorsTextArea
            // 
            this.errorsTextArea.AcceptsTab = true;
            this.errorsTextArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.errorsTextArea.Cursor = System.Windows.Forms.Cursors.No;
            this.errorsTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorsTextArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorsTextArea.Location = new System.Drawing.Point(347, 23);
            this.errorsTextArea.Name = "errorsTextArea";
            this.errorsTextArea.ReadOnly = true;
            this.errorsTextArea.Size = new System.Drawing.Size(338, 535);
            this.errorsTextArea.TabIndex = 8;
            this.errorsTextArea.Text = "Analize ainda não realizada";
            this.errorsTextArea.WordWrap = false;
            this.errorsTextArea.TextChanged += new System.EventHandler(this.ErrorsTextArea_TextChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Arquivos .txt (*.txt)|*.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Arquivos .txt (*.txt)|*.txt";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.mainLayout);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analizador sintatico";
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.optionsLayout.ResumeLayout(false);
            this.runLayout.ResumeLayout(false);
            this.runLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goToLexiconAnalyzerButton;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.RichTextBox codeTextArea;
        private System.Windows.Forms.Label codePanelAnalize;
        private System.Windows.Forms.Label optionPanelLabel;
        private System.Windows.Forms.TableLayoutPanel optionsLayout;
        private System.Windows.Forms.Button savePorjectButton;
        private System.Windows.Forms.TableLayoutPanel runLayout;
        private System.Windows.Forms.CheckBox autoAnalize;
        private System.Windows.Forms.Button buttonAnalize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openProjectButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label errorsTextAreaLabel;
        private System.Windows.Forms.RichTextBox errorsTextArea;
    }
}