
namespace MCD_MSSQL_CRUD_Islemleri
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnUrunGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoolId = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnIDGore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1396, 490);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(53, 565);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(146, 44);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(205, 565);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(153, 44);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(364, 565);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(167, 44);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnUrunGetir
            // 
            this.btnUrunGetir.Location = new System.Drawing.Point(537, 565);
            this.btnUrunGetir.Name = "btnUrunGetir";
            this.btnUrunGetir.Size = new System.Drawing.Size(158, 44);
            this.btnUrunGetir.TabIndex = 1;
            this.btnUrunGetir.Text = "Ürün Getir";
            this.btnUrunGetir.UseVisualStyleBackColor = true;
            this.btnUrunGetir.Click += new System.EventHandler(this.btnUrunGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1163, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1163, 626);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1163, 701);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat :";
            // 
            // txtBoolId
            // 
            this.txtBoolId.Location = new System.Drawing.Point(732, 576);
            this.txtBoolId.Name = "txtBoolId";
            this.txtBoolId.Size = new System.Drawing.Size(145, 22);
            this.txtBoolId.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(1263, 562);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(155, 22);
            this.txtAd.TabIndex = 3;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(1263, 623);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(155, 22);
            this.txtStok.TabIndex = 3;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(1263, 698);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(155, 22);
            this.txtFiyat.TabIndex = 3;
            // 
            // btnIDGore
            // 
            this.btnIDGore.Location = new System.Drawing.Point(915, 565);
            this.btnIDGore.Name = "btnIDGore";
            this.btnIDGore.Size = new System.Drawing.Size(199, 44);
            this.btnIDGore.TabIndex = 4;
            this.btnIDGore.Text = "ID\'ye Göre Ürün Getir ";
            this.btnIDGore.UseVisualStyleBackColor = true;
            this.btnIDGore.Click += new System.EventHandler(this.btnIDGore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 755);
            this.Controls.Add(this.btnIDGore);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtBoolId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUrunGetir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnUrunGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoolId;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnIDGore;
    }
}

