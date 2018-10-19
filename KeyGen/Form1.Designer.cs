namespace KeyGen
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_privKey = new System.Windows.Forms.TextBox();
            this.tb_pubKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_prover_privateKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_prover_PublicKey = new System.Windows.Forms.TextBox();
            this.textBox_prover_signature = new System.Windows.Forms.TextBox();
            this.textBox_prover_message = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Verifier_PublicKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_verifier_signature = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Verifier_Message = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_sign = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.groupBox_keygen = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_keygen.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(95, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Keys";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_privKey
            // 
            this.tb_privKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_privKey.Location = new System.Drawing.Point(95, 70);
            this.tb_privKey.Name = "tb_privKey";
            this.tb_privKey.ReadOnly = true;
            this.tb_privKey.Size = new System.Drawing.Size(395, 20);
            this.tb_privKey.TabIndex = 1;
            // 
            // tb_pubKey
            // 
            this.tb_pubKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pubKey.Location = new System.Drawing.Point(95, 108);
            this.tb_pubKey.Name = "tb_pubKey";
            this.tb_pubKey.ReadOnly = true;
            this.tb_pubKey.Size = new System.Drawing.Size(395, 20);
            this.tb_pubKey.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Private Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Public Key:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(95, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(395, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_prover_privateKey
            // 
            this.textBox_prover_privateKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_prover_privateKey.Location = new System.Drawing.Point(95, 73);
            this.textBox_prover_privateKey.Name = "textBox_prover_privateKey";
            this.textBox_prover_privateKey.Size = new System.Drawing.Size(395, 20);
            this.textBox_prover_privateKey.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Private Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Public Key:";
            // 
            // textBox_prover_PublicKey
            // 
            this.textBox_prover_PublicKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_prover_PublicKey.Location = new System.Drawing.Point(95, 117);
            this.textBox_prover_PublicKey.Name = "textBox_prover_PublicKey";
            this.textBox_prover_PublicKey.Size = new System.Drawing.Size(395, 20);
            this.textBox_prover_PublicKey.TabIndex = 10;
            // 
            // textBox_prover_signature
            // 
            this.textBox_prover_signature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_prover_signature.Location = new System.Drawing.Point(95, 197);
            this.textBox_prover_signature.Name = "textBox_prover_signature";
            this.textBox_prover_signature.ReadOnly = true;
            this.textBox_prover_signature.Size = new System.Drawing.Size(395, 20);
            this.textBox_prover_signature.TabIndex = 11;
            // 
            // textBox_prover_message
            // 
            this.textBox_prover_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_prover_message.Location = new System.Drawing.Point(95, 36);
            this.textBox_prover_message.Name = "textBox_prover_message";
            this.textBox_prover_message.Size = new System.Drawing.Size(395, 20);
            this.textBox_prover_message.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Message:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Signature:";
            // 
            // textBox_Verifier_PublicKey
            // 
            this.textBox_Verifier_PublicKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Verifier_PublicKey.Location = new System.Drawing.Point(95, 92);
            this.textBox_Verifier_PublicKey.Name = "textBox_Verifier_PublicKey";
            this.textBox_Verifier_PublicKey.Size = new System.Drawing.Size(395, 20);
            this.textBox_Verifier_PublicKey.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Signature:";
            // 
            // textBox_verifier_signature
            // 
            this.textBox_verifier_signature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_verifier_signature.Location = new System.Drawing.Point(95, 134);
            this.textBox_verifier_signature.Name = "textBox_verifier_signature";
            this.textBox_verifier_signature.ReadOnly = true;
            this.textBox_verifier_signature.Size = new System.Drawing.Size(395, 20);
            this.textBox_verifier_signature.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Public Key:";
            // 
            // textBox_Verifier_Message
            // 
            this.textBox_Verifier_Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Verifier_Message.Location = new System.Drawing.Point(95, 51);
            this.textBox_Verifier_Message.Name = "textBox_Verifier_Message";
            this.textBox_Verifier_Message.Size = new System.Drawing.Size(395, 20);
            this.textBox_Verifier_Message.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Message:";
            // 
            // button_sign
            // 
            this.button_sign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sign.Location = new System.Drawing.Point(95, 156);
            this.button_sign.Name = "button_sign";
            this.button_sign.Size = new System.Drawing.Size(395, 23);
            this.button_sign.TabIndex = 21;
            this.button_sign.Text = "Sign";
            this.button_sign.UseVisualStyleBackColor = true;
            this.button_sign.Click += new System.EventHandler(this.button_sign_Click);
            // 
            // button_validate
            // 
            this.button_validate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_validate.Location = new System.Drawing.Point(95, 173);
            this.button_validate.Name = "button_validate";
            this.button_validate.Size = new System.Drawing.Size(395, 23);
            this.button_validate.TabIndex = 22;
            this.button_validate.Text = "Validated Signature";
            this.button_validate.UseVisualStyleBackColor = true;
            this.button_validate.Click += new System.EventHandler(this.button_validate_Click);
            // 
            // groupBox_keygen
            // 
            this.groupBox_keygen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_keygen.Controls.Add(this.button1);
            this.groupBox_keygen.Controls.Add(this.tb_privKey);
            this.groupBox_keygen.Controls.Add(this.tb_pubKey);
            this.groupBox_keygen.Controls.Add(this.label1);
            this.groupBox_keygen.Controls.Add(this.label2);
            this.groupBox_keygen.Controls.Add(this.button2);
            this.groupBox_keygen.Location = new System.Drawing.Point(12, 12);
            this.groupBox_keygen.Name = "groupBox_keygen";
            this.groupBox_keygen.Size = new System.Drawing.Size(510, 185);
            this.groupBox_keygen.TabIndex = 23;
            this.groupBox_keygen.TabStop = false;
            this.groupBox_keygen.Text = "KEY GENERATION";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox_prover_message);
            this.groupBox2.Controls.Add(this.textBox_prover_privateKey);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button_sign);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_prover_PublicKey);
            this.groupBox2.Controls.Add(this.textBox_prover_signature);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 243);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SIGNING";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBox_Verifier_Message);
            this.groupBox3.Controls.Add(this.textBox_Verifier_PublicKey);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button_validate);
            this.groupBox3.Controls.Add(this.textBox_verifier_signature);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 221);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VALIDATION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(534, 710);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_keygen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyGen";
            this.groupBox_keygen.ResumeLayout(false);
            this.groupBox_keygen.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_privKey;
        private System.Windows.Forms.TextBox tb_pubKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_prover_privateKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_prover_PublicKey;
        private System.Windows.Forms.TextBox textBox_prover_signature;
        private System.Windows.Forms.TextBox textBox_prover_message;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Verifier_PublicKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_verifier_signature;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Verifier_Message;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_sign;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.GroupBox groupBox_keygen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

