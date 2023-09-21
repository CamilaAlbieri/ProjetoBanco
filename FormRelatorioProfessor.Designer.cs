namespace projeto4
{
    partial class FormRelatorioProfessor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAreaFormacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboTitulacao = new ReaLTaiizor.Controls.MaterialComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btmImprimir = new ReaLTaiizor.Controls.MaterialButton();
            this.btmVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAreaFormacao);
            this.groupBox1.Controls.Add(this.cboTitulacao);
            this.groupBox1.Location = new System.Drawing.Point(19, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtAreaFormacao
            // 
            this.txtAreaFormacao.AnimateReadOnly = false;
            this.txtAreaFormacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAreaFormacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAreaFormacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAreaFormacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAreaFormacao.Depth = 0;
            this.txtAreaFormacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAreaFormacao.HideSelection = true;
            this.txtAreaFormacao.Hint = "Área de Formação";
            this.txtAreaFormacao.LeadingIcon = null;
            this.txtAreaFormacao.Location = new System.Drawing.Point(17, 31);
            this.txtAreaFormacao.MaxLength = 32767;
            this.txtAreaFormacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtAreaFormacao.Name = "txtAreaFormacao";
            this.txtAreaFormacao.PasswordChar = '\0';
            this.txtAreaFormacao.PrefixSuffixText = null;
            this.txtAreaFormacao.ReadOnly = false;
            this.txtAreaFormacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAreaFormacao.SelectedText = "";
            this.txtAreaFormacao.SelectionLength = 0;
            this.txtAreaFormacao.SelectionStart = 0;
            this.txtAreaFormacao.ShortcutsEnabled = true;
            this.txtAreaFormacao.Size = new System.Drawing.Size(250, 48);
            this.txtAreaFormacao.TabIndex = 5;
            this.txtAreaFormacao.TabStop = false;
            this.txtAreaFormacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAreaFormacao.TrailingIcon = null;
            this.txtAreaFormacao.UseSystemPasswordChar = false;
            // 
            // cboTitulacao
            // 
            this.cboTitulacao.AutoResize = false;
            this.cboTitulacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTitulacao.Depth = 0;
            this.cboTitulacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTitulacao.DropDownHeight = 174;
            this.cboTitulacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitulacao.DropDownWidth = 121;
            this.cboTitulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTitulacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTitulacao.FormattingEnabled = true;
            this.cboTitulacao.Hint = "Titulação";
            this.cboTitulacao.IntegralHeight = false;
            this.cboTitulacao.ItemHeight = 43;
            this.cboTitulacao.Items.AddRange(new object[] {
            "",
            "Graduação",
            "Especialização",
            "Mestrado",
            "Doutorado"});
            this.cboTitulacao.Location = new System.Drawing.Point(286, 31);
            this.cboTitulacao.MaxDropDownItems = 4;
            this.cboTitulacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTitulacao.Name = "cboTitulacao";
            this.cboTitulacao.Size = new System.Drawing.Size(135, 49);
            this.cboTitulacao.StartIndex = 0;
            this.cboTitulacao.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(19, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agrupamento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboImpressora);
            this.groupBox3.Location = new System.Drawing.Point(19, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Impressora";
            // 
            // cboImpressora
            // 
            this.cboImpressora.AutoResize = false;
            this.cboImpressora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboImpressora.Depth = 0;
            this.cboImpressora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboImpressora.DropDownHeight = 174;
            this.cboImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpressora.DropDownWidth = 121;
            this.cboImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboImpressora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboImpressora.FormattingEnabled = true;
            this.cboImpressora.Hint = "Impressora";
            this.cboImpressora.IntegralHeight = false;
            this.cboImpressora.ItemHeight = 43;
            this.cboImpressora.Location = new System.Drawing.Point(45, 32);
            this.cboImpressora.MaxDropDownItems = 4;
            this.cboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboImpressora.Name = "cboImpressora";
            this.cboImpressora.Size = new System.Drawing.Size(376, 49);
            this.cboImpressora.StartIndex = 0;
            this.cboImpressora.TabIndex = 8;
            // 
            // btmImprimir
            // 
            this.btmImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btmImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btmImprimir.Depth = 0;
            this.btmImprimir.HighEmphasis = true;
            this.btmImprimir.Icon = null;
            this.btmImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btmImprimir.Location = new System.Drawing.Point(138, 447);
            this.btmImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btmImprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btmImprimir.Name = "btmImprimir";
            this.btmImprimir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btmImprimir.Size = new System.Drawing.Size(97, 36);
            this.btmImprimir.TabIndex = 3;
            this.btmImprimir.Text = "&IMPRIMIR";
            this.btmImprimir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btmImprimir.UseAccentColor = false;
            this.btmImprimir.UseVisualStyleBackColor = true;
            this.btmImprimir.Click += new System.EventHandler(this.btmImprimir_Click);
            // 
            // btmVisualizar
            // 
            this.btmVisualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btmVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btmVisualizar.Depth = 0;
            this.btmVisualizar.HighEmphasis = true;
            this.btmVisualizar.Icon = null;
            this.btmVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btmVisualizar.Location = new System.Drawing.Point(243, 447);
            this.btmVisualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btmVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btmVisualizar.Name = "btmVisualizar";
            this.btmVisualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btmVisualizar.Size = new System.Drawing.Size(112, 36);
            this.btmVisualizar.TabIndex = 4;
            this.btmVisualizar.Text = "&VISUALIZAR";
            this.btmVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btmVisualizar.UseAccentColor = false;
            this.btmVisualizar.UseVisualStyleBackColor = true;
            this.btmVisualizar.Click += new System.EventHandler(this.btmVisualizar_Click);
            // 
            // FormRelatorioProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 500);
            this.Controls.Add(this.btmVisualizar);
            this.Controls.Add(this.btmImprimir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRelatorioProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Professores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRelatorioProfessor_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ReaLTaiizor.Controls.MaterialButton btmImprimir;
        private ReaLTaiizor.Controls.MaterialButton btmVisualizar;
        private ReaLTaiizor.Controls.MaterialComboBox cboTitulacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAreaFormacao;
    }
}