﻿namespace OpenRetail.App.Transaksi
{
    partial class FrmListPembelianProduk
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gridList = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.filterRangeTanggal = new OpenRetail.App.UserControl.FilterRangeTanggal();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtNamaSupplier = new OpenRetail.App.UserControl.AdvancedTextbox();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(877, 4);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.gridList, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(789, 367);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // gridList
            // 
            this.gridList.BackColor = System.Drawing.SystemColors.Control;
            this.gridList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridList.ItemHeight = 17;
            this.gridList.Location = new System.Drawing.Point(3, 32);
            this.gridList.Name = "gridList";
            this.gridList.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridList.SelectedIndex = -1;
            this.gridList.Size = new System.Drawing.Size(783, 332);
            this.gridList.TabIndex = 1;
            this.gridList.TopIndex = 0;
            this.gridList.DoubleClick += new System.EventHandler(this.gridList_DoubleClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.72F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.28F));
            this.tableLayoutPanel4.Controls.Add(this.filterRangeTanggal, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(789, 29);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // filterRangeTanggal
            // 
            this.filterRangeTanggal.Location = new System.Drawing.Point(3, 3);
            this.filterRangeTanggal.Name = "filterRangeTanggal";
            this.filterRangeTanggal.Size = new System.Drawing.Size(469, 23);
            this.filterRangeTanggal.TabIndex = 2;
            this.filterRangeTanggal.BtnTampilkanClicked += new OpenRetail.App.UserControl.FilterRangeTanggal.EventHandler(this.filterRangeTanggal_BtnTampilkanClicked);
            this.filterRangeTanggal.ChkTampilkanSemuaDataClicked += new OpenRetail.App.UserControl.FilterRangeTanggal.EventHandler(this.filterRangeTanggal_ChkTampilkanSemuaDataClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCari);
            this.flowLayoutPanel1.Controls.Add(this.txtNamaSupplier);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(486, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(303, 29);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnCari
            // 
            this.btnCari.Image = global::OpenRetail.App.Properties.Resources.search16;
            this.btnCari.Location = new System.Drawing.Point(263, 3);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(37, 23);
            this.btnCari.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnCari, "Cari nama supplier");
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.AutoEnter = false;
            this.txtNamaSupplier.Conversion = OpenRetail.App.UserControl.EConversion.Normal;
            this.txtNamaSupplier.EnterFocusColor = System.Drawing.Color.White;
            this.txtNamaSupplier.LeaveFocusColor = System.Drawing.Color.White;
            this.txtNamaSupplier.LetterOnly = false;
            this.txtNamaSupplier.Location = new System.Drawing.Point(39, 3);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.NumericOnly = false;
            this.txtNamaSupplier.SelectionText = false;
            this.txtNamaSupplier.Size = new System.Drawing.Size(218, 20);
            this.txtNamaSupplier.TabIndex = 1;
            this.txtNamaSupplier.ThousandSeparator = false;
            this.txtNamaSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaSupplier_KeyPress);
            // 
            // FrmListPembelianProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 449);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "FrmListPembelianProduk";
            this.Text = "FrmListPembelianProduk";
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Syncfusion.Windows.Forms.Grid.GridListControl gridList;
        private UserControl.FilterRangeTanggal filterRangeTanggal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCari;
        private UserControl.AdvancedTextbox txtNamaSupplier;
    }
}