namespace CNC_Sender_GRBL_09
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSimulateSquare = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSquareSide = new System.Windows.Forms.TextBox();
            this.txtGCodeSquare = new System.Windows.Forms.TextBox();
            this.btnCutSquare = new System.Windows.Forms.Button();
            this.btnGenerateSquare = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHoming = new System.Windows.Forms.Button();
            this.btnSetHome = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnZDown = new System.Windows.Forms.Button();
            this.btnZUp = new System.Windows.Forms.Button();
            this.btnYrigth = new System.Windows.Forms.Button();
            this.btnYleft = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.btnXright = new System.Windows.Forms.Button();
            this.btnXleft = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSimulateSquare);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSquareSide);
            this.groupBox1.Controls.Add(this.txtGCodeSquare);
            this.groupBox1.Controls.Add(this.btnCutSquare);
            this.groupBox1.Controls.Add(this.btnGenerateSquare);
            this.groupBox1.Location = new System.Drawing.Point(6, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(376, 378);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuadrado";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // chkSimulateSquare
            // 
            this.chkSimulateSquare.AutoSize = true;
            this.chkSimulateSquare.Location = new System.Drawing.Point(237, 33);
            this.chkSimulateSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSimulateSquare.Name = "chkSimulateSquare";
            this.chkSimulateSquare.Size = new System.Drawing.Size(60, 17);
            this.chkSimulateSquare.TabIndex = 22;
            this.chkSimulateSquare.Text = "Simular";
            this.chkSimulateSquare.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lado";
            // 
            // txtSquareSide
            // 
            this.txtSquareSide.Location = new System.Drawing.Point(170, 33);
            this.txtSquareSide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSquareSide.Name = "txtSquareSide";
            this.txtSquareSide.Size = new System.Drawing.Size(56, 20);
            this.txtSquareSide.TabIndex = 3;
            // 
            // txtGCodeSquare
            // 
            this.txtGCodeSquare.Location = new System.Drawing.Point(15, 80);
            this.txtGCodeSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGCodeSquare.Multiline = true;
            this.txtGCodeSquare.Name = "txtGCodeSquare";
            this.txtGCodeSquare.Size = new System.Drawing.Size(344, 244);
            this.txtGCodeSquare.TabIndex = 2;
            // 
            // btnCutSquare
            // 
            this.btnCutSquare.Location = new System.Drawing.Point(15, 332);
            this.btnCutSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCutSquare.Name = "btnCutSquare";
            this.btnCutSquare.Size = new System.Drawing.Size(102, 23);
            this.btnCutSquare.TabIndex = 1;
            this.btnCutSquare.Text = "Ejecutar";
            this.btnCutSquare.UseVisualStyleBackColor = true;
            this.btnCutSquare.Click += new System.EventHandler(this.BtnCutSquare_Click);
            // 
            // btnGenerateSquare
            // 
            this.btnGenerateSquare.Location = new System.Drawing.Point(15, 29);
            this.btnGenerateSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateSquare.Name = "btnGenerateSquare";
            this.btnGenerateSquare.Size = new System.Drawing.Size(102, 23);
            this.btnGenerateSquare.TabIndex = 0;
            this.btnGenerateSquare.Text = "Generar GCode";
            this.btnGenerateSquare.UseVisualStyleBackColor = true;
            this.btnGenerateSquare.Click += new System.EventHandler(this.BtnGenerateSquare_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(376, 118);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Conexión";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // txtFeed
            // 
            this.txtFeed.Location = new System.Drawing.Point(178, 87);
            this.txtFeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFeed.Name = "txtFeed";
            this.txtFeed.Size = new System.Drawing.Size(76, 20);
            this.txtFeed.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Feed";
            // 
            // btnHoming
            // 
            this.btnHoming.Location = new System.Drawing.Point(268, 53);
            this.btnHoming.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHoming.Name = "btnHoming";
            this.btnHoming.Size = new System.Drawing.Size(89, 23);
            this.btnHoming.TabIndex = 23;
            this.btnHoming.Text = "Volver a Origen";
            this.btnHoming.UseVisualStyleBackColor = true;
            this.btnHoming.Click += new System.EventHandler(this.BtnHoming_Click);
            // 
            // btnSetHome
            // 
            this.btnSetHome.Location = new System.Drawing.Point(268, 22);
            this.btnSetHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetHome.Name = "btnSetHome";
            this.btnSetHome.Size = new System.Drawing.Size(89, 23);
            this.btnSetHome.TabIndex = 22;
            this.btnSetHome.Text = "Set Origen";
            this.btnSetHome.UseVisualStyleBackColor = true;
            this.btnSetHome.Click += new System.EventHandler(this.BtnSetHome_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(23, 22);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(72, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(23, 53);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // cboCom
            // 
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(178, 22);
            this.cboCom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(76, 21);
            this.cboCom.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(186, 58);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Puerto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Estado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnZDown);
            this.groupBox3.Controls.Add(this.btnZUp);
            this.groupBox3.Controls.Add(this.btnYrigth);
            this.groupBox3.Controls.Add(this.btnYleft);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDistance);
            this.groupBox3.Controls.Add(this.btnXright);
            this.groupBox3.Controls.Add(this.btnXleft);
            this.groupBox3.Location = new System.Drawing.Point(390, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(162, 147);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimiento Ejes";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // btnZDown
            // 
            this.btnZDown.Location = new System.Drawing.Point(80, 105);
            this.btnZDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZDown.Name = "btnZDown";
            this.btnZDown.Size = new System.Drawing.Size(52, 22);
            this.btnZDown.TabIndex = 28;
            this.btnZDown.Text = "Z Abajo";
            this.btnZDown.UseVisualStyleBackColor = true;
            this.btnZDown.Click += new System.EventHandler(this.btnZDown_Click);
            // 
            // btnZUp
            // 
            this.btnZUp.Location = new System.Drawing.Point(21, 105);
            this.btnZUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZUp.Name = "btnZUp";
            this.btnZUp.Size = new System.Drawing.Size(56, 22);
            this.btnZUp.TabIndex = 29;
            this.btnZUp.Text = "Z  Arriba";
            this.btnZUp.UseVisualStyleBackColor = true;
            this.btnZUp.Click += new System.EventHandler(this.btnZUp_Click);
            // 
            // btnYrigth
            // 
            this.btnYrigth.Location = new System.Drawing.Point(80, 78);
            this.btnYrigth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYrigth.Name = "btnYrigth";
            this.btnYrigth.Size = new System.Drawing.Size(52, 22);
            this.btnYrigth.TabIndex = 26;
            this.btnYrigth.Text = "Y >";
            this.btnYrigth.UseVisualStyleBackColor = true;
            this.btnYrigth.Click += new System.EventHandler(this.btnYrigth_Click);
            // 
            // btnYleft
            // 
            this.btnYleft.Location = new System.Drawing.Point(21, 78);
            this.btnYleft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYleft.Name = "btnYleft";
            this.btnYleft.Size = new System.Drawing.Size(56, 22);
            this.btnYleft.TabIndex = 27;
            this.btnYleft.Text = "Y <";
            this.btnYleft.UseVisualStyleBackColor = true;
            this.btnYleft.Click += new System.EventHandler(this.btnYleft_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Distancia";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(72, 22);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(56, 20);
            this.txtDistance.TabIndex = 24;
            // 
            // btnXright
            // 
            this.btnXright.Location = new System.Drawing.Point(80, 49);
            this.btnXright.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXright.Name = "btnXright";
            this.btnXright.Size = new System.Drawing.Size(52, 22);
            this.btnXright.TabIndex = 0;
            this.btnXright.Text = "X >";
            this.btnXright.UseVisualStyleBackColor = true;
            this.btnXright.Click += new System.EventHandler(this.btnXright_Click);
            // 
            // btnXleft
            // 
            this.btnXleft.Location = new System.Drawing.Point(21, 49);
            this.btnXleft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXleft.Name = "btnXleft";
            this.btnXleft.Size = new System.Drawing.Size(56, 22);
            this.btnXleft.TabIndex = 1;
            this.btnXleft.Text = "X <";
            this.btnXleft.UseVisualStyleBackColor = true;
            this.btnXleft.Click += new System.EventHandler(this.btnXleft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 541);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSimulateSquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSquareSide;
        private System.Windows.Forms.TextBox txtGCodeSquare;
        private System.Windows.Forms.Button btnCutSquare;
        private System.Windows.Forms.Button btnGenerateSquare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHoming;
        private System.Windows.Forms.Button btnSetHome;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnZDown;
        private System.Windows.Forms.Button btnZUp;
        private System.Windows.Forms.Button btnYrigth;
        private System.Windows.Forms.Button btnYleft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Button btnXright;
        private System.Windows.Forms.Button btnXleft;
    }
}

