namespace IB_3
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
            this.btn_hashing = new System.Windows.Forms.Button();
            this.txtbx_hash = new System.Windows.Forms.TextBox();
            this.txtbx_msg = new System.Windows.Forms.TextBox();
            this.cmbbx_hash_algs = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtbx_sym_decr = new System.Windows.Forms.TextBox();
            this.txtbx_sym_encr = new System.Windows.Forms.TextBox();
            this.btn_sym_read_iv = new System.Windows.Forms.Button();
            this.btn_sym_gen_iv = new System.Windows.Forms.Button();
            this.btn_sym_read_key = new System.Windows.Forms.Button();
            this.btn_sym_data_decr = new System.Windows.Forms.Button();
            this.btn_sym_read_data_decr = new System.Windows.Forms.Button();
            this.btn_sym_data_encr = new System.Windows.Forms.Button();
            this.btn_sym_read_data_enc = new System.Windows.Forms.Button();
            this.btn_sym_gen_key = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtbx_asym_decr = new System.Windows.Forms.TextBox();
            this.txtbx_asym_encr = new System.Windows.Forms.TextBox();
            this.btn_read_rsa_priv_key = new System.Windows.Forms.Button();
            this.btn_read_rsa_publ_key = new System.Windows.Forms.Button();
            this.btn_rsa_data_decr = new System.Windows.Forms.Button();
            this.btn_asym_data_decr = new System.Windows.Forms.Button();
            this.btn_rsa_data_encr = new System.Windows.Forms.Button();
            this.btn_asym_read_data = new System.Windows.Forms.Button();
            this.btn_gen_rsa_keys = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_hashing
            // 
            this.btn_hashing.Location = new System.Drawing.Point(63, 169);
            this.btn_hashing.Name = "btn_hashing";
            this.btn_hashing.Size = new System.Drawing.Size(75, 23);
            this.btn_hashing.TabIndex = 1;
            this.btn_hashing.Text = "hashing";
            this.btn_hashing.UseVisualStyleBackColor = true;
            this.btn_hashing.Click += new System.EventHandler(this.btn_hashing_Click);
            // 
            // txtbx_hash
            // 
            this.txtbx_hash.Location = new System.Drawing.Point(266, 169);
            this.txtbx_hash.Multiline = true;
            this.txtbx_hash.Name = "txtbx_hash";
            this.txtbx_hash.ReadOnly = true;
            this.txtbx_hash.Size = new System.Drawing.Size(373, 126);
            this.txtbx_hash.TabIndex = 2;
            // 
            // txtbx_msg
            // 
            this.txtbx_msg.Location = new System.Drawing.Point(266, 3);
            this.txtbx_msg.Multiline = true;
            this.txtbx_msg.Name = "txtbx_msg";
            this.txtbx_msg.Size = new System.Drawing.Size(373, 160);
            this.txtbx_msg.TabIndex = 2;
            // 
            // cmbbx_hash_algs
            // 
            this.cmbbx_hash_algs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_hash_algs.FormattingEnabled = true;
            this.cmbbx_hash_algs.Items.AddRange(new object[] {
            "MD5",
            "SHA512",
            "SHA1",
            "SHA256",
            "SHA384"});
            this.cmbbx_hash_algs.Location = new System.Drawing.Point(44, 49);
            this.cmbbx_hash_algs.Name = "cmbbx_hash_algs";
            this.cmbbx_hash_algs.Size = new System.Drawing.Size(121, 21);
            this.cmbbx_hash_algs.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 329);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtbx_hash);
            this.tabPage1.Controls.Add(this.btn_hashing);
            this.tabPage1.Controls.Add(this.cmbbx_hash_algs);
            this.tabPage1.Controls.Add(this.txtbx_msg);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hash";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtbx_sym_decr);
            this.tabPage2.Controls.Add(this.txtbx_sym_encr);
            this.tabPage2.Controls.Add(this.btn_sym_read_iv);
            this.tabPage2.Controls.Add(this.btn_sym_gen_iv);
            this.tabPage2.Controls.Add(this.btn_sym_read_key);
            this.tabPage2.Controls.Add(this.btn_sym_data_decr);
            this.tabPage2.Controls.Add(this.btn_sym_read_data_decr);
            this.tabPage2.Controls.Add(this.btn_sym_data_encr);
            this.tabPage2.Controls.Add(this.btn_sym_read_data_enc);
            this.tabPage2.Controls.Add(this.btn_sym_gen_key);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Symmetric";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtbx_sym_decr
            // 
            this.txtbx_sym_decr.Location = new System.Drawing.Point(266, 160);
            this.txtbx_sym_decr.Multiline = true;
            this.txtbx_sym_decr.Name = "txtbx_sym_decr";
            this.txtbx_sym_decr.ReadOnly = true;
            this.txtbx_sym_decr.Size = new System.Drawing.Size(323, 80);
            this.txtbx_sym_decr.TabIndex = 1;
            // 
            // txtbx_sym_encr
            // 
            this.txtbx_sym_encr.Location = new System.Drawing.Point(266, 37);
            this.txtbx_sym_encr.Multiline = true;
            this.txtbx_sym_encr.Name = "txtbx_sym_encr";
            this.txtbx_sym_encr.ReadOnly = true;
            this.txtbx_sym_encr.Size = new System.Drawing.Size(323, 80);
            this.txtbx_sym_encr.TabIndex = 1;
            // 
            // btn_sym_read_iv
            // 
            this.btn_sym_read_iv.Location = new System.Drawing.Point(9, 203);
            this.btn_sym_read_iv.Name = "btn_sym_read_iv";
            this.btn_sym_read_iv.Size = new System.Drawing.Size(126, 37);
            this.btn_sym_read_iv.TabIndex = 0;
            this.btn_sym_read_iv.Text = "Записать вектор";
            this.btn_sym_read_iv.UseVisualStyleBackColor = true;
            this.btn_sym_read_iv.Click += new System.EventHandler(this.btn_sym_read_iv_Click);
            // 
            // btn_sym_gen_iv
            // 
            this.btn_sym_gen_iv.Location = new System.Drawing.Point(9, 80);
            this.btn_sym_gen_iv.Name = "btn_sym_gen_iv";
            this.btn_sym_gen_iv.Size = new System.Drawing.Size(126, 37);
            this.btn_sym_gen_iv.TabIndex = 0;
            this.btn_sym_gen_iv.Text = "Сгенерировать вектор";
            this.btn_sym_gen_iv.UseVisualStyleBackColor = true;
            this.btn_sym_gen_iv.Click += new System.EventHandler(this.btn_sym_gen_iv_Click);
            // 
            // btn_sym_read_key
            // 
            this.btn_sym_read_key.Location = new System.Drawing.Point(9, 160);
            this.btn_sym_read_key.Name = "btn_sym_read_key";
            this.btn_sym_read_key.Size = new System.Drawing.Size(126, 37);
            this.btn_sym_read_key.TabIndex = 0;
            this.btn_sym_read_key.Text = "Записать ключ";
            this.btn_sym_read_key.UseVisualStyleBackColor = true;
            this.btn_sym_read_key.Click += new System.EventHandler(this.btn_sym_read_key_Click);
            // 
            // btn_sym_data_decr
            // 
            this.btn_sym_data_decr.Location = new System.Drawing.Point(141, 203);
            this.btn_sym_data_decr.Name = "btn_sym_data_decr";
            this.btn_sym_data_decr.Size = new System.Drawing.Size(96, 37);
            this.btn_sym_data_decr.TabIndex = 0;
            this.btn_sym_data_decr.Text = "Дешифровать";
            this.btn_sym_data_decr.UseVisualStyleBackColor = true;
            this.btn_sym_data_decr.Click += new System.EventHandler(this.btn_sym_data_decr_Click_1);
            // 
            // btn_sym_read_data_decr
            // 
            this.btn_sym_read_data_decr.Location = new System.Drawing.Point(141, 160);
            this.btn_sym_read_data_decr.Name = "btn_sym_read_data_decr";
            this.btn_sym_read_data_decr.Size = new System.Drawing.Size(96, 37);
            this.btn_sym_read_data_decr.TabIndex = 0;
            this.btn_sym_read_data_decr.Text = "Файл для дешифрования";
            this.btn_sym_read_data_decr.UseVisualStyleBackColor = true;
            this.btn_sym_read_data_decr.Click += new System.EventHandler(this.btn_sym_data_decr_Click);
            // 
            // btn_sym_data_encr
            // 
            this.btn_sym_data_encr.Location = new System.Drawing.Point(141, 80);
            this.btn_sym_data_encr.Name = "btn_sym_data_encr";
            this.btn_sym_data_encr.Size = new System.Drawing.Size(96, 37);
            this.btn_sym_data_encr.TabIndex = 0;
            this.btn_sym_data_encr.Text = "Зашифровать файл";
            this.btn_sym_data_encr.UseVisualStyleBackColor = true;
            this.btn_sym_data_encr.Click += new System.EventHandler(this.btn_sym_data_encr_Click_1);
            // 
            // btn_sym_read_data_enc
            // 
            this.btn_sym_read_data_enc.Location = new System.Drawing.Point(141, 37);
            this.btn_sym_read_data_enc.Name = "btn_sym_read_data_enc";
            this.btn_sym_read_data_enc.Size = new System.Drawing.Size(96, 37);
            this.btn_sym_read_data_enc.TabIndex = 0;
            this.btn_sym_read_data_enc.Text = "Файл для шифрования";
            this.btn_sym_read_data_enc.UseVisualStyleBackColor = true;
            this.btn_sym_read_data_enc.Click += new System.EventHandler(this.btn_sym_data_encr_Click);
            // 
            // btn_sym_gen_key
            // 
            this.btn_sym_gen_key.Location = new System.Drawing.Point(9, 37);
            this.btn_sym_gen_key.Name = "btn_sym_gen_key";
            this.btn_sym_gen_key.Size = new System.Drawing.Size(126, 37);
            this.btn_sym_gen_key.TabIndex = 0;
            this.btn_sym_gen_key.Text = "Сгенерировать ключ";
            this.btn_sym_gen_key.UseVisualStyleBackColor = true;
            this.btn_sym_gen_key.Click += new System.EventHandler(this.btn_sym_gen_key_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtbx_asym_decr);
            this.tabPage3.Controls.Add(this.txtbx_asym_encr);
            this.tabPage3.Controls.Add(this.btn_read_rsa_priv_key);
            this.tabPage3.Controls.Add(this.btn_read_rsa_publ_key);
            this.tabPage3.Controls.Add(this.btn_rsa_data_decr);
            this.tabPage3.Controls.Add(this.btn_asym_data_decr);
            this.tabPage3.Controls.Add(this.btn_rsa_data_encr);
            this.tabPage3.Controls.Add(this.btn_asym_read_data);
            this.tabPage3.Controls.Add(this.btn_gen_rsa_keys);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(647, 303);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asymmetric";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtbx_asym_decr
            // 
            this.txtbx_asym_decr.Location = new System.Drawing.Point(266, 160);
            this.txtbx_asym_decr.Multiline = true;
            this.txtbx_asym_decr.Name = "txtbx_asym_decr";
            this.txtbx_asym_decr.ReadOnly = true;
            this.txtbx_asym_decr.Size = new System.Drawing.Size(323, 80);
            this.txtbx_asym_decr.TabIndex = 8;
            // 
            // txtbx_asym_encr
            // 
            this.txtbx_asym_encr.Location = new System.Drawing.Point(266, 37);
            this.txtbx_asym_encr.Multiline = true;
            this.txtbx_asym_encr.Name = "txtbx_asym_encr";
            this.txtbx_asym_encr.ReadOnly = true;
            this.txtbx_asym_encr.Size = new System.Drawing.Size(323, 80);
            this.txtbx_asym_encr.TabIndex = 9;
            // 
            // btn_read_rsa_priv_key
            // 
            this.btn_read_rsa_priv_key.Location = new System.Drawing.Point(9, 184);
            this.btn_read_rsa_priv_key.Name = "btn_read_rsa_priv_key";
            this.btn_read_rsa_priv_key.Size = new System.Drawing.Size(126, 37);
            this.btn_read_rsa_priv_key.TabIndex = 2;
            this.btn_read_rsa_priv_key.Text = "Ввести закрытый ключ";
            this.btn_read_rsa_priv_key.UseVisualStyleBackColor = true;
            this.btn_read_rsa_priv_key.Click += new System.EventHandler(this.btn_read_rsa_priv_key_Click);
            // 
            // btn_read_rsa_publ_key
            // 
            this.btn_read_rsa_publ_key.Location = new System.Drawing.Point(9, 62);
            this.btn_read_rsa_publ_key.Name = "btn_read_rsa_publ_key";
            this.btn_read_rsa_publ_key.Size = new System.Drawing.Size(126, 37);
            this.btn_read_rsa_publ_key.TabIndex = 4;
            this.btn_read_rsa_publ_key.Text = "Ввести открытый ключ";
            this.btn_read_rsa_publ_key.UseVisualStyleBackColor = true;
            this.btn_read_rsa_publ_key.Click += new System.EventHandler(this.btn_read_rsa_publ_key_Click);
            // 
            // btn_rsa_data_decr
            // 
            this.btn_rsa_data_decr.Location = new System.Drawing.Point(76, 227);
            this.btn_rsa_data_decr.Name = "btn_rsa_data_decr";
            this.btn_rsa_data_decr.Size = new System.Drawing.Size(96, 37);
            this.btn_rsa_data_decr.TabIndex = 5;
            this.btn_rsa_data_decr.Text = "Расшифровать";
            this.btn_rsa_data_decr.UseVisualStyleBackColor = true;
            this.btn_rsa_data_decr.Click += new System.EventHandler(this.btn_rsa_data_decr_Click);
            // 
            // btn_asym_data_decr
            // 
            this.btn_asym_data_decr.Location = new System.Drawing.Point(141, 184);
            this.btn_asym_data_decr.Name = "btn_asym_data_decr";
            this.btn_asym_data_decr.Size = new System.Drawing.Size(96, 37);
            this.btn_asym_data_decr.TabIndex = 5;
            this.btn_asym_data_decr.Text = "Файл для дешифрования";
            this.btn_asym_data_decr.UseVisualStyleBackColor = true;
            this.btn_asym_data_decr.Click += new System.EventHandler(this.btn_asym_data_decr_Click);
            // 
            // btn_rsa_data_encr
            // 
            this.btn_rsa_data_encr.Location = new System.Drawing.Point(76, 118);
            this.btn_rsa_data_encr.Name = "btn_rsa_data_encr";
            this.btn_rsa_data_encr.Size = new System.Drawing.Size(96, 37);
            this.btn_rsa_data_encr.TabIndex = 6;
            this.btn_rsa_data_encr.Text = "Зашифровать";
            this.btn_rsa_data_encr.UseVisualStyleBackColor = true;
            this.btn_rsa_data_encr.Click += new System.EventHandler(this.btn_asym_data_encr_Click);
            // 
            // btn_asym_read_data
            // 
            this.btn_asym_read_data.Location = new System.Drawing.Point(141, 62);
            this.btn_asym_read_data.Name = "btn_asym_read_data";
            this.btn_asym_read_data.Size = new System.Drawing.Size(96, 37);
            this.btn_asym_read_data.TabIndex = 6;
            this.btn_asym_read_data.Text = "Файл для шифрования";
            this.btn_asym_read_data.UseVisualStyleBackColor = true;
            this.btn_asym_read_data.Click += new System.EventHandler(this.btn_asym_read_data_Click);
            // 
            // btn_gen_rsa_keys
            // 
            this.btn_gen_rsa_keys.Location = new System.Drawing.Point(62, 19);
            this.btn_gen_rsa_keys.Name = "btn_gen_rsa_keys";
            this.btn_gen_rsa_keys.Size = new System.Drawing.Size(126, 37);
            this.btn_gen_rsa_keys.TabIndex = 7;
            this.btn_gen_rsa_keys.Text = "Сгенерировать ключи";
            this.btn_gen_rsa_keys.UseVisualStyleBackColor = true;
            this.btn_gen_rsa_keys.Click += new System.EventHandler(this.btn_gen_rsa_keys_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(647, 303);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sign";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 329);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_hashing;
        private System.Windows.Forms.TextBox txtbx_hash;
        private System.Windows.Forms.TextBox txtbx_msg;
        private System.Windows.Forms.ComboBox cmbbx_hash_algs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_sym_gen_iv;
        private System.Windows.Forms.Button btn_sym_gen_key;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_sym_read_iv;
        private System.Windows.Forms.Button btn_sym_read_key;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtbx_sym_encr;
        private System.Windows.Forms.Button btn_sym_read_data_enc;
        private System.Windows.Forms.TextBox txtbx_sym_decr;
        private System.Windows.Forms.Button btn_sym_read_data_decr;
        private System.Windows.Forms.TextBox txtbx_asym_decr;
        private System.Windows.Forms.TextBox txtbx_asym_encr;
        private System.Windows.Forms.Button btn_read_rsa_priv_key;
        private System.Windows.Forms.Button btn_read_rsa_publ_key;
        private System.Windows.Forms.Button btn_asym_data_decr;
        private System.Windows.Forms.Button btn_asym_read_data;
        private System.Windows.Forms.Button btn_gen_rsa_keys;
        private System.Windows.Forms.Button btn_rsa_data_encr;
        private System.Windows.Forms.Button btn_rsa_data_decr;
        private System.Windows.Forms.Button btn_sym_data_encr;
        private System.Windows.Forms.Button btn_sym_data_decr;
    }
}

