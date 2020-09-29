namespace TestForms
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetHome = new System.Windows.Forms.Button();
            this.btnHoming = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateSquare = new System.Windows.Forms.Button();
            this.btnCutSquare = new System.Windows.Forms.Button();
            this.txtGCodeSquare = new System.Windows.Forms.TextBox();
            this.txtSquareSide = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSimulateSquare = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFeed = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFeed);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnHoming);
            this.groupBox2.Controls.Add(this.btnSetHome);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.cboCom);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(39, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 218);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Conexión";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(46, 42);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(143, 45);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(46, 102);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // cboCom
            // 
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(356, 42);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(149, 33);
            this.cboCom.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(372, 112);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(18, 25);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Puerto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Estado";
            // 
            // btnSetHome
            // 
            this.btnSetHome.Location = new System.Drawing.Point(537, 42);
            this.btnSetHome.Name = "btnSetHome";
            this.btnSetHome.Size = new System.Drawing.Size(178, 45);
            this.btnSetHome.TabIndex = 22;
            this.btnSetHome.Text = "Set Origen";
            this.btnSetHome.UseVisualStyleBackColor = true;
            this.btnSetHome.Click += new System.EventHandler(this.BtnSetHome_Click);
            // 
            // btnHoming
            // 
            this.btnHoming.Location = new System.Drawing.Point(537, 102);
            this.btnHoming.Name = "btnHoming";
            this.btnHoming.Size = new System.Drawing.Size(178, 45);
            this.btnHoming.TabIndex = 23;
            this.btnHoming.Text = "Volver a Origen";
            this.btnHoming.UseVisualStyleBackColor = true;
            this.btnHoming.Click += new System.EventHandler(this.BtnHoming_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSimulateSquare);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSquareSide);
            this.groupBox1.Controls.Add(this.txtGCodeSquare);
            this.groupBox1.Controls.Add(this.btnCutSquare);
            this.groupBox1.Controls.Add(this.btnGenerateSquare);
            this.groupBox1.Location = new System.Drawing.Point(39, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 724);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuadrado";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // btnGenerateSquare
            // 
            this.btnGenerateSquare.Location = new System.Drawing.Point(30, 56);
            this.btnGenerateSquare.Name = "btnGenerateSquare";
            this.btnGenerateSquare.Size = new System.Drawing.Size(205, 45);
            this.btnGenerateSquare.TabIndex = 0;
            this.btnGenerateSquare.Text = "Generar GCode";
            this.btnGenerateSquare.UseVisualStyleBackColor = true;
            this.btnGenerateSquare.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnCutSquare
            // 
            this.btnCutSquare.Location = new System.Drawing.Point(30, 638);
            this.btnCutSquare.Name = "btnCutSquare";
            this.btnCutSquare.Size = new System.Drawing.Size(205, 45);
            this.btnCutSquare.TabIndex = 1;
            this.btnCutSquare.Text = "Ejecutar";
            this.btnCutSquare.UseVisualStyleBackColor = true;
            this.btnCutSquare.Click += new System.EventHandler(this.BtnCutSquare_Click);
            // 
            // txtGCodeSquare
            // 
            this.txtGCodeSquare.Location = new System.Drawing.Point(30, 154);
            this.txtGCodeSquare.Multiline = true;
            this.txtGCodeSquare.Name = "txtGCodeSquare";
            this.txtGCodeSquare.Size = new System.Drawing.Size(685, 465);
            this.txtGCodeSquare.TabIndex = 2;
            // 
            // txtSquareSide
            // 
            this.txtSquareSide.Location = new System.Drawing.Point(341, 63);
            this.txtSquareSide.Name = "txtSquareSide";
            this.txtSquareSide.Size = new System.Drawing.Size(108, 31);
            this.txtSquareSide.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lado";
            // 
            // chkSimulateSquare
            // 
            this.chkSimulateSquare.AutoSize = true;
            this.chkSimulateSquare.Location = new System.Drawing.Point(474, 63);
            this.chkSimulateSquare.Name = "chkSimulateSquare";
            this.chkSimulateSquare.Size = new System.Drawing.Size(116, 29);
            this.chkSimulateSquare.TabIndex = 22;
            this.chkSimulateSquare.Text = "Simular";
            this.chkSimulateSquare.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Feed";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtFeed
            // 
            this.txtFeed.Location = new System.Drawing.Point(356, 167);
            this.txtFeed.Name = "txtFeed";
            this.txtFeed.Size = new System.Drawing.Size(149, 31);
            this.txtFeed.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 1060);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Testing CNC Backend Functions";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetHome;
        private System.Windows.Forms.Button btnHoming;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSimulateSquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSquareSide;
        private System.Windows.Forms.TextBox txtGCodeSquare;
        private System.Windows.Forms.Button btnCutSquare;
        private System.Windows.Forms.Button btnGenerateSquare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFeed;
    }
}

