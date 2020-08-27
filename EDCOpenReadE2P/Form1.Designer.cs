namespace EDCOpenReadE2P
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
            this.e2p_open_btn = new System.Windows.Forms.Button();
            this.e2p_file_path_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.e2p_vin = new System.Windows.Forms.TextBox();
            this.e2p_sec_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.e2p_sw_ver = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.e2p_sw_date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // e2p_open_btn
            // 
            this.e2p_open_btn.Location = new System.Drawing.Point(12, 28);
            this.e2p_open_btn.Name = "e2p_open_btn";
            this.e2p_open_btn.Size = new System.Drawing.Size(75, 23);
            this.e2p_open_btn.TabIndex = 0;
            this.e2p_open_btn.Text = "Open E2P File";
            this.e2p_open_btn.UseVisualStyleBackColor = true;
            this.e2p_open_btn.Click += new System.EventHandler(this.e2p_open_btn_Click);
            // 
            // e2p_file_path_txt
            // 
            this.e2p_file_path_txt.Location = new System.Drawing.Point(127, 30);
            this.e2p_file_path_txt.Name = "e2p_file_path_txt";
            this.e2p_file_path_txt.ReadOnly = true;
            this.e2p_file_path_txt.Size = new System.Drawing.Size(165, 20);
            this.e2p_file_path_txt.TabIndex = 1;
            this.e2p_file_path_txt.Text = "CR 7.5 das E2P\'s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Security Code";
            // 
            // e2p_vin
            // 
            this.e2p_vin.Location = new System.Drawing.Point(127, 89);
            this.e2p_vin.Name = "e2p_vin";
            this.e2p_vin.ReadOnly = true;
            this.e2p_vin.Size = new System.Drawing.Size(165, 20);
            this.e2p_vin.TabIndex = 4;
            // 
            // e2p_sec_code
            // 
            this.e2p_sec_code.Location = new System.Drawing.Point(127, 117);
            this.e2p_sec_code.Name = "e2p_sec_code";
            this.e2p_sec_code.ReadOnly = true;
            this.e2p_sec_code.Size = new System.Drawing.Size(165, 20);
            this.e2p_sec_code.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ECU SW Ver";
            // 
            // e2p_sw_ver
            // 
            this.e2p_sw_ver.Location = new System.Drawing.Point(127, 145);
            this.e2p_sw_ver.Name = "e2p_sw_ver";
            this.e2p_sw_ver.ReadOnly = true;
            this.e2p_sw_ver.Size = new System.Drawing.Size(165, 20);
            this.e2p_sw_ver.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ECU SW Date";
            // 
            // e2p_sw_date
            // 
            this.e2p_sw_date.Location = new System.Drawing.Point(127, 174);
            this.e2p_sw_date.Name = "e2p_sw_date";
            this.e2p_sw_date.ReadOnly = true;
            this.e2p_sw_date.Size = new System.Drawing.Size(165, 20);
            this.e2p_sw_date.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 245);
            this.Controls.Add(this.e2p_sw_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.e2p_sw_ver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.e2p_sec_code);
            this.Controls.Add(this.e2p_vin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.e2p_file_path_txt);
            this.Controls.Add(this.e2p_open_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Opel EDC16C39 E2P Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button e2p_open_btn;
        private System.Windows.Forms.TextBox e2p_file_path_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox e2p_vin;
        private System.Windows.Forms.TextBox e2p_sec_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox e2p_sw_ver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox e2p_sw_date;
    }
}

