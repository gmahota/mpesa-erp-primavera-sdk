namespace Primavera.Paymentsds.Mpesa.UI
{
    partial class FDU_PagMpesa
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
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtEntidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumdoc = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSerie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.bTSair = new System.Windows.Forms.ToolStripButton();
            this.bTPrint = new System.Windows.Forms.ToolStripButton();
            this.btProcessar = new System.Windows.Forms.ToolStripButton();
            this.bTRefresh = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TS = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumdoc)).BeginInit();
            this.TS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReferencia
            // 
            this.txtReferencia.Enabled = false;
            this.txtReferencia.Location = new System.Drawing.Point(90, 66);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(186, 20);
            this.txtReferencia.TabIndex = 5;
            // 
            // txtEntidade
            // 
            this.txtEntidade.Enabled = false;
            this.txtEntidade.Location = new System.Drawing.Point(90, 30);
            this.txtEntidade.Name = "txtEntidade";
            this.txtEntidade.Size = new System.Drawing.Size(186, 20);
            this.txtEntidade.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nr. Telefone:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReferencia);
            this.groupBox2.Controls.Add(this.txtEntidade);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(3, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 119);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pag. Mpesa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Referencia:";
            // 
            // txtNumdoc
            // 
            this.txtNumdoc.Location = new System.Drawing.Point(93, 80);
            this.txtNumdoc.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtNumdoc.Name = "txtNumdoc";
            this.txtNumdoc.Size = new System.Drawing.Size(183, 20);
            this.txtNumdoc.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(30, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Num Doc:";
            // 
            // cbSerie
            // 
            this.cbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerie.FormattingEnabled = true;
            this.cbSerie.Location = new System.Drawing.Point(94, 53);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(183, 21);
            this.cbSerie.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(48, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Serie:";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Location = new System.Drawing.Point(93, 26);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(183, 21);
            this.cbTipoDoc.TabIndex = 2;
            // 
            // bTSair
            // 
            this.bTSair.Image = global::Primavera.Paymentsds.Mpesa.Properties.Resources.cancelar32x32;
            this.bTSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bTSair.Name = "bTSair";
            this.bTSair.Size = new System.Drawing.Size(46, 22);
            this.bTSair.Text = "Sair";
            // 
            // bTPrint
            // 
            this.bTPrint.Image = global::Primavera.Paymentsds.Mpesa.Properties.Resources.bTPrint_Image;
            this.bTPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bTPrint.Name = "bTPrint";
            this.bTPrint.Size = new System.Drawing.Size(73, 22);
            this.bTPrint.Text = "Imprimir";
            this.bTPrint.ToolTipText = "Imprimir";
            // 
            // btProcessar
            // 
            this.btProcessar.Image = global::Primavera.Paymentsds.Mpesa.Properties.Resources.gravar32x32;
            this.btProcessar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btProcessar.Name = "btProcessar";
            this.btProcessar.Size = new System.Drawing.Size(77, 22);
            this.btProcessar.Text = "Processar";
            this.btProcessar.Click += new System.EventHandler(this.btProcessar_Click);
            // 
            // bTRefresh
            // 
            this.bTRefresh.Image = global::Primavera.Paymentsds.Mpesa.Properties.Resources.actualizar32x32;
            this.bTRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bTRefresh.Name = "bTRefresh";
            this.bTRefresh.Size = new System.Drawing.Size(73, 22);
            this.bTRefresh.Text = "Atualizar";
            this.bTRefresh.ToolTipText = "Atualizar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(31, 30);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo Doc:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TS
            // 
            this.TS.BackColor = System.Drawing.Color.White;
            this.TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bTRefresh,
            this.btProcessar,
            this.bTPrint,
            this.bTSair});
            this.TS.Location = new System.Drawing.Point(0, 0);
            this.TS.Name = "TS";
            this.TS.Size = new System.Drawing.Size(319, 25);
            this.TS.TabIndex = 100;
            this.TS.Text = "ToolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumdoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbSerie);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbTipoDoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 138);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(23, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Referencia:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(91, 106);
            this.txtTotal.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(183, 20);
            this.txtTotal.TabIndex = 45;
            // 
            // FDU_PagMpesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TS);
            this.Controls.Add(this.groupBox1);
            this.Name = "FDU_PagMpesa";
            this.Size = new System.Drawing.Size(319, 299);
            this.Text = "FDU_PagMpesa";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumdoc)).EndInit();
            this.TS.ResumeLayout(false);
            this.TS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtEntidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtNumdoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSerie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        internal System.Windows.Forms.ToolStripButton bTSair;
        internal System.Windows.Forms.ToolStripButton bTPrint;
        private System.Windows.Forms.ToolStripButton btProcessar;
        internal System.Windows.Forms.ToolStripButton bTRefresh;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ToolStrip TS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtTotal;
        private System.Windows.Forms.Label label1;
    }
}