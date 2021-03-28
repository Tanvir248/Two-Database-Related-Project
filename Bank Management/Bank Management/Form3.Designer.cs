
namespace Bank_Management
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidepanel2 = new System.Windows.Forms.Panel();
            this.seedatabutton4 = new System.Windows.Forms.Button();
            this.loanbutton3 = new System.Windows.Forms.Button();
            this.withdrowbutton2 = new System.Windows.Forms.Button();
            this.depositbutton1 = new System.Windows.Forms.Button();
            this.createaccadddatabutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userControl11 = new Bank_Management.UserControl1();
            this.userControl21 = new Bank_Management.UserControl2();
            this.userControl31 = new Bank_Management.UserControl3();
            this.userControl51 = new Bank_Management.UserControl5();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.sidepanel2);
            this.panel1.Controls.Add(this.seedatabutton4);
            this.panel1.Controls.Add(this.loanbutton3);
            this.panel1.Controls.Add(this.withdrowbutton2);
            this.panel1.Controls.Add(this.depositbutton1);
            this.panel1.Controls.Add(this.createaccadddatabutton1);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 651);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sidepanel2
            // 
            this.sidepanel2.BackColor = System.Drawing.Color.Yellow;
            this.sidepanel2.Location = new System.Drawing.Point(4, 128);
            this.sidepanel2.Name = "sidepanel2";
            this.sidepanel2.Size = new System.Drawing.Size(21, 52);
            this.sidepanel2.TabIndex = 2;
            // 
            // seedatabutton4
            // 
            this.seedatabutton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seedatabutton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seedatabutton4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seedatabutton4.ForeColor = System.Drawing.Color.Lime;
            this.seedatabutton4.Location = new System.Drawing.Point(31, 602);
            this.seedatabutton4.Name = "seedatabutton4";
            this.seedatabutton4.Size = new System.Drawing.Size(99, 38);
            this.seedatabutton4.TabIndex = 4;
            this.seedatabutton4.Text = "See Data";
            this.seedatabutton4.UseVisualStyleBackColor = true;
            this.seedatabutton4.Click += new System.EventHandler(this.button4_Click);
            // 
            // loanbutton3
            // 
            this.loanbutton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loanbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loanbutton3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanbutton3.ForeColor = System.Drawing.Color.Lime;
            this.loanbutton3.Location = new System.Drawing.Point(31, 357);
            this.loanbutton3.Name = "loanbutton3";
            this.loanbutton3.Size = new System.Drawing.Size(99, 58);
            this.loanbutton3.TabIndex = 4;
            this.loanbutton3.Text = "Loan";
            this.loanbutton3.UseVisualStyleBackColor = true;
            this.loanbutton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // withdrowbutton2
            // 
            this.withdrowbutton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withdrowbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrowbutton2.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrowbutton2.ForeColor = System.Drawing.Color.Lime;
            this.withdrowbutton2.Location = new System.Drawing.Point(31, 276);
            this.withdrowbutton2.Name = "withdrowbutton2";
            this.withdrowbutton2.Size = new System.Drawing.Size(99, 56);
            this.withdrowbutton2.TabIndex = 4;
            this.withdrowbutton2.Text = "Withdraw Money";
            this.withdrowbutton2.UseVisualStyleBackColor = true;
            this.withdrowbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // depositbutton1
            // 
            this.depositbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depositbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositbutton1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositbutton1.ForeColor = System.Drawing.Color.Lime;
            this.depositbutton1.Location = new System.Drawing.Point(31, 201);
            this.depositbutton1.Name = "depositbutton1";
            this.depositbutton1.Size = new System.Drawing.Size(99, 54);
            this.depositbutton1.TabIndex = 4;
            this.depositbutton1.Text = "Deposit Money";
            this.depositbutton1.UseVisualStyleBackColor = true;
            this.depositbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createaccadddatabutton1
            // 
            this.createaccadddatabutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createaccadddatabutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createaccadddatabutton1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createaccadddatabutton1.ForeColor = System.Drawing.Color.Lime;
            this.createaccadddatabutton1.Location = new System.Drawing.Point(31, 128);
            this.createaccadddatabutton1.Name = "createaccadddatabutton1";
            this.createaccadddatabutton1.Size = new System.Drawing.Size(99, 52);
            this.createaccadddatabutton1.TabIndex = 4;
            this.createaccadddatabutton1.Text = "Create Account";
            this.createaccadddatabutton1.UseVisualStyleBackColor = true;
            this.createaccadddatabutton1.Click += new System.EventHandler(this.adddatabutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(131, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 622);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(134, -12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(872, 651);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.userControl11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.userControl11.Location = new System.Drawing.Point(134, -1);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(872, 651);
            this.userControl11.TabIndex = 2;
            this.userControl11.Visible = false;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.userControl21.Location = new System.Drawing.Point(134, -1);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(872, 651);
            this.userControl21.TabIndex = 3;
            this.userControl21.Visible = false;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.userControl31.Location = new System.Drawing.Point(134, -1);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(872, 651);
            this.userControl31.TabIndex = 4;
            this.userControl31.Visible = false;
            // 
            // userControl51
            // 
            this.userControl51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.userControl51.Location = new System.Drawing.Point(134, -1);
            this.userControl51.Name = "userControl51";
            this.userControl51.Size = new System.Drawing.Size(872, 651);
            this.userControl51.TabIndex = 5;
            this.userControl51.Visible = false;
            this.userControl51.Load += new System.EventHandler(this.userControl51_Load);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 651);
            this.Controls.Add(this.userControl51);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loanbutton3;
        private System.Windows.Forms.Button withdrowbutton2;
        private System.Windows.Forms.Button depositbutton1;
        private System.Windows.Forms.Button createaccadddatabutton1;
        private System.Windows.Forms.Button seedatabutton4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel sidepanel2;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private UserControl5 userControl51;
    }
}