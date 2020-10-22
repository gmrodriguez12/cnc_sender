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
            this.txtGCode = new System.Windows.Forms.TextBox();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.genCircleCode = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSquareSide);
            this.groupBox1.Controls.Add(this.btnGenerateSquare);
            this.groupBox1.Location = new System.Drawing.Point(390, 170);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(162, 87);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuadrado";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // chkSimulateSquare
            // 
            this.chkSimulateSquare.AutoSize = true;
            this.chkSimulateSquare.Location = new System.Drawing.Point(117, 216);
            this.chkSimulateSquare.Margin = new System.Windows.Forms.Padding(2);
            this.chkSimulateSquare.Name = "chkSimulateSquare";
            this.chkSimulateSquare.Size = new System.Drawing.Size(60, 17);
            this.chkSimulateSquare.TabIndex = 22;
            this.chkSimulateSquare.Text = "Simular";
            this.chkSimulateSquare.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lado";
            // 
            // txtSquareSide
            // 
            this.txtSquareSide.Location = new System.Drawing.Point(41, 17);
            this.txtSquareSide.Margin = new System.Windows.Forms.Padding(2);
            this.txtSquareSide.Name = "txtSquareSide";
            this.txtSquareSide.Size = new System.Drawing.Size(56, 20);
            this.txtSquareSide.TabIndex = 3;
            // 
            // txtGCode
            // 
            this.txtGCode.Location = new System.Drawing.Point(11, 32);
            this.txtGCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtGCode.Multiline = true;
            this.txtGCode.Name = "txtGCode";
            this.txtGCode.Size = new System.Drawing.Size(346, 170);
            this.txtGCode.TabIndex = 2;
            // 
            // btnCutSquare
            // 
            this.btnCutSquare.Location = new System.Drawing.Point(11, 212);
            this.btnCutSquare.Margin = new System.Windows.Forms.Padding(2);
            this.btnCutSquare.Name = "btnCutSquare";
            this.btnCutSquare.Size = new System.Drawing.Size(102, 23);
            this.btnCutSquare.TabIndex = 1;
            this.btnCutSquare.Text = "Ejecutar";
            this.btnCutSquare.UseVisualStyleBackColor = true;
            this.btnCutSquare.Click += new System.EventHandler(this.BtnCutSquare_Click);
            // 
            // btnGenerateSquare
            // 
            this.btnGenerateSquare.Location = new System.Drawing.Point(12, 50);
            this.btnGenerateSquare.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateSquare.Name = "btnGenerateSquare";
            this.btnGenerateSquare.Size = new System.Drawing.Size(134, 23);
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
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(376, 118);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Conexión";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // txtFeed
            // 
            this.txtFeed.Location = new System.Drawing.Point(139, 89);
            this.txtFeed.Margin = new System.Windows.Forms.Padding(2);
            this.txtFeed.Name = "txtFeed";
            this.txtFeed.Size = new System.Drawing.Size(76, 20);
            this.txtFeed.TabIndex = 25;
            this.txtFeed.Text = "800";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Feed";
            // 
            // btnHoming
            // 
            this.btnHoming.Location = new System.Drawing.Point(268, 53);
            this.btnHoming.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnSetHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetHome.Name = "btnSetHome";
            this.btnSetHome.Size = new System.Drawing.Size(89, 23);
            this.btnSetHome.TabIndex = 22;
            this.btnSetHome.Text = "Set Origen";
            this.btnSetHome.UseVisualStyleBackColor = true;
            this.btnSetHome.Click += new System.EventHandler(this.BtnSetHome_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(11, 22);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(72, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(11, 53);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
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
            this.cboCom.Location = new System.Drawing.Point(139, 24);
            this.cboCom.Margin = new System.Windows.Forms.Padding(2);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(76, 21);
            this.cboCom.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(147, 60);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Puerto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 61);
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
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(162, 147);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimiento Ejes";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // btnZDown
            // 
            this.btnZDown.Location = new System.Drawing.Point(80, 105);
            this.btnZDown.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnZUp.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnYrigth.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnYleft.Margin = new System.Windows.Forms.Padding(2);
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
            this.txtDistance.Margin = new System.Windows.Forms.Padding(2);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(56, 20);
            this.txtDistance.TabIndex = 24;
            this.txtDistance.Text = "10";
            // 
            // btnXright
            // 
            this.btnXright.Location = new System.Drawing.Point(80, 49);
            this.btnXright.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnXleft.Margin = new System.Windows.Forms.Padding(2);
            this.btnXleft.Name = "btnXleft";
            this.btnXleft.Size = new System.Drawing.Size(56, 22);
            this.btnXleft.TabIndex = 1;
            this.btnXleft.Text = "X <";
            this.btnXleft.UseVisualStyleBackColor = true;
            this.btnXleft.Click += new System.EventHandler(this.btnXleft_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtGCode);
            this.groupBox4.Controls.Add(this.chkSimulateSquare);
            this.groupBox4.Controls.Add(this.btnCutSquare);
            this.groupBox4.Location = new System.Drawing.Point(3, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 248);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ejecución";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(392, 263);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(160, 108);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rectángulo";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(392, 377);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 93);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Línea Recta";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.txtRadius);
            this.groupBox7.Controls.Add(this.genCircleCode);
            this.groupBox7.Location = new System.Drawing.Point(3, 392);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(186, 78);
            this.groupBox7.TabIndex = 33;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Círculo";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(195, 392);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(187, 78);
            this.groupBox8.TabIndex = 34;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Triángulo Rectángulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Radio";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(50, 15);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(2);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(56, 20);
            this.txtRadius.TabIndex = 23;
            // 
            // genCircleCode
            // 
            this.genCircleCode.Location = new System.Drawing.Point(14, 43);
            this.genCircleCode.Margin = new System.Windows.Forms.Padding(2);
            this.genCircleCode.Name = "genCircleCode";
            this.genCircleCode.Size = new System.Drawing.Size(134, 23);
            this.genCircleCode.TabIndex = 22;
            this.genCircleCode.Text = "Generar GCode";
            this.genCircleCode.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Largo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 18);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Generar GCode";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ancho";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(47, 45);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 20);
            this.textBox3.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 677);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSimulateSquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSquareSide;
        private System.Windows.Forms.TextBox txtGCode;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button genCircleCode;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

