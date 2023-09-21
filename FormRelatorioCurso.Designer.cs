namespace projeto4
{
    partial class FormRelatorioCurso
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
            this.txtNomeCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboTipoCurso = new ReaLTaiizor.Controls.MaterialComboBox();
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
            this.groupBox1.Controls.Add(this.txtNomeCurso);
            this.groupBox1.Controls.Add(this.cboTipoCurso);
            this.groupBox1.Location = new System.Drawing.Point(21, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.AnimateReadOnly = false;
            this.txtNomeCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomeCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomeCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNomeCurso.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomeCurso.Depth = 0;
            this.txtNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeCurso.HideSelection = true;
            this.txtNomeCurso.Hint = "Nome Curso";
            this.txtNomeCurso.LeadingIcon = null;
            this.txtNomeCurso.Location = new System.Drawing.Point(16, 32);
            this.txtNomeCurso.MaxLength = 32767;
            this.txtNomeCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.PasswordChar = '\0';
            this.txtNomeCurso.PrefixSuffixText = null;
            this.txtNomeCurso.ReadOnly = false;
            this.txtNomeCurso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNomeCurso.SelectedText = "";
            this.txtNomeCurso.SelectionLength = 0;
            this.txtNomeCurso.SelectionStart = 0;
            this.txtNomeCurso.ShortcutsEnabled = true;
            this.txtNomeCurso.Size = new System.Drawing.Size(202, 48);
            this.txtNomeCurso.TabIndex = 0;
            this.txtNomeCurso.TabStop = false;
            this.txtNomeCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNomeCurso.TrailingIcon = null;
            this.txtNomeCurso.UseSystemPasswordChar = false;
            // 
            // cboTipoCurso
            // 
            this.cboTipoCurso.AutoResize = false;
            this.cboTipoCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTipoCurso.Depth = 0;
            this.cboTipoCurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTipoCurso.DropDownHeight = 174;
            this.cboTipoCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCurso.DropDownWidth = 121;
            this.cboTipoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTipoCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTipoCurso.FormattingEnabled = true;
            this.cboTipoCurso.Hint = "Tipo";
            this.cboTipoCurso.IntegralHeight = false;
            this.cboTipoCurso.ItemHeight = 43;
            this.cboTipoCurso.Items.AddRange(new object[] {
            "",
            "Técnico",
            "Tecnólogo",
            "Bacharelado",
            "Licenciatura"});
            this.cboTipoCurso.Location = new System.Drawing.Point(226, 32);
            this.cboTipoCurso.MaxDropDownItems = 4;
            this.cboTipoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTipoCurso.Name = "cboTipoCurso";
            this.cboTipoCurso.Size = new System.Drawing.Size(225, 49);
            this.cboTipoCurso.StartIndex = 0;
            this.cboTipoCurso.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(21, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agrupamento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboImpressora);
            this.groupBox3.Location = new System.Drawing.Point(21, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 100);
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
            this.cboImpressora.Location = new System.Drawing.Point(37, 33);
            this.cboImpressora.MaxDropDownItems = 4;
            this.cboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboImpressora.Name = "cboImpressora";
            this.cboImpressora.Size = new System.Drawing.Size(376, 49);
            this.cboImpressora.StartIndex = 0;
            this.cboImpressora.TabIndex = 0;
            // 
            // btmImprimir
            // 
            this.btmImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btmImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btmImprimir.Depth = 0;
            this.btmImprimir.HighEmphasis = true;
            this.btmImprimir.Icon = null;
            this.btmImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btmImprimir.Location = new System.Drawing.Point(142, 434);
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
            this.btmVisualizar.Location = new System.Drawing.Point(247, 434);
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
            // FormRelatorioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 500);
            this.Controls.Add(this.btmVisualizar);
            this.Controls.Add(this.btmImprimir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRelatorioCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Curso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRelatorioCurso_FormClosed);
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
        private ReaLTaiizor.Controls.MaterialComboBox cboTipoCurso;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeCurso;
    }
}