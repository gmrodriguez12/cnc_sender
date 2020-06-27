namespace CNC_Testing
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.btnXRight = new System.Windows.Forms.Button();
            this.btnYRight = new System.Windows.Forms.Button();
            this.btnYLeft = new System.Windows.Forms.Button();
            this.btnXLeft = new System.Windows.Forms.Button();
            this.btnZDown = new System.Windows.Forms.Button();
            this.btnZup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkRele = new System.Windows.Forms.CheckBox();
            this.chkSimulate = new System.Windows.Forms.CheckBox();
            this.btnReturnZero = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValidationErrorsQuad = new System.Windows.Forms.Label();
            this.btnSetHome = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRunImport = new System.Windows.Forms.Button();
            this.lblImportationResult = new System.Windows.Forms.Label();
            this.btnExplore = new System.Windows.Forms.Button();
            this.btnSetProperty = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            // btnXRight
            // 
            this.btnXRight.Location = new System.Drawing.Point(516, 232);
            this.btnXRight.Name = "btnXRight";
            this.btnXRight.Size = new System.Drawing.Size(123, 55);
            this.btnXRight.TabIndex = 4;
            this.btnXRight.Text = "X >>";
            this.btnXRight.UseVisualStyleBackColor = true;
            this.btnXRight.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // btnYRight
            // 
            this.btnYRight.Location = new System.Drawing.Point(516, 146);
            this.btnYRight.Name = "btnYRight";
            this.btnYRight.Size = new System.Drawing.Size(123, 55);
            this.btnYRight.TabIndex = 5;
            this.btnYRight.Text = "Y >>";
            this.btnYRight.UseVisualStyleBackColor = true;
            this.btnYRight.Click += new System.EventHandler(this.BtnYRight_Click);
            // 
            // btnYLeft
            // 
            this.btnYLeft.Location = new System.Drawing.Point(362, 146);
            this.btnYLeft.Name = "btnYLeft";
            this.btnYLeft.Size = new System.Drawing.Size(123, 55);
            this.btnYLeft.TabIndex = 6;
            this.btnYLeft.Text = "<< Y";
            this.btnYLeft.UseVisualStyleBackColor = true;
            this.btnYLeft.Click += new System.EventHandler(this.BtnYLeft_Click);
            // 
            // btnXLeft
            // 
            this.btnXLeft.Location = new System.Drawing.Point(362, 232);
            this.btnXLeft.Name = "btnXLeft";
            this.btnXLeft.Size = new System.Drawing.Size(123, 55);
            this.btnXLeft.TabIndex = 7;
            this.btnXLeft.Text = "<< X";
            this.btnXLeft.UseVisualStyleBackColor = true;
            this.btnXLeft.Click += new System.EventHandler(this.BtnXLeft_Click);
            // 
            // btnZDown
            // 
            this.btnZDown.Location = new System.Drawing.Point(443, 310);
            this.btnZDown.Name = "btnZDown";
            this.btnZDown.Size = new System.Drawing.Size(123, 55);
            this.btnZDown.TabIndex = 9;
            this.btnZDown.Text = "Z Down";
            this.btnZDown.UseVisualStyleBackColor = true;
            this.btnZDown.Click += new System.EventHandler(this.BtnZDown_Click);
            // 
            // btnZup
            // 
            this.btnZup.Location = new System.Drawing.Point(443, 70);
            this.btnZup.Name = "btnZup";
            this.btnZup.Size = new System.Drawing.Size(123, 55);
            this.btnZup.TabIndex = 8;
            this.btnZup.Text = "Z Up";
            this.btnZup.UseVisualStyleBackColor = true;
            this.btnZup.Click += new System.EventHandler(this.BtnZup_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 53);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ejecutar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(144, 54);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(97, 31);
            this.txtWidth.TabIndex = 12;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(144, 98);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(97, 31);
            this.txtHeight.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Largo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ancho";
            // 
            // chkRele
            // 
            this.chkRele.AutoSize = true;
            this.chkRele.Location = new System.Drawing.Point(280, 49);
            this.chkRele.Name = "chkRele";
            this.chkRele.Size = new System.Drawing.Size(160, 29);
            this.chkRele.TabIndex = 16;
            this.chkRele.Text = "Activar Rele";
            this.chkRele.UseVisualStyleBackColor = true;
            // 
            // chkSimulate
            // 
            this.chkSimulate.AutoSize = true;
            this.chkSimulate.Location = new System.Drawing.Point(280, 104);
            this.chkSimulate.Name = "chkSimulate";
            this.chkSimulate.Size = new System.Drawing.Size(174, 29);
            this.chkSimulate.TabIndex = 17;
            this.chkSimulate.Text = "Simular Corte";
            this.chkSimulate.UseVisualStyleBackColor = true;
            // 
            // btnReturnZero
            // 
            this.btnReturnZero.Location = new System.Drawing.Point(36, 119);
            this.btnReturnZero.Name = "btnReturnZero";
            this.btnReturnZero.Size = new System.Drawing.Size(220, 44);
            this.btnReturnZero.TabIndex = 18;
            this.btnReturnZero.Text = "Retornar a Origen";
            this.btnReturnZero.UseVisualStyleBackColor = true;
            this.btnReturnZero.Click += new System.EventHandler(this.BtnReturnZero_Click);
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(372, 112);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(18, 25);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValidationErrorsQuad);
            this.groupBox1.Controls.Add(this.chkRele);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkSimulate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(59, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 217);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuadrados y Rectángulos";
            // 
            // lblValidationErrorsQuad
            // 
            this.lblValidationErrorsQuad.AutoSize = true;
            this.lblValidationErrorsQuad.ForeColor = System.Drawing.Color.Red;
            this.lblValidationErrorsQuad.Location = new System.Drawing.Point(56, 162);
            this.lblValidationErrorsQuad.Name = "lblValidationErrorsQuad";
            this.lblValidationErrorsQuad.Size = new System.Drawing.Size(171, 25);
            this.lblValidationErrorsQuad.TabIndex = 21;
            this.lblValidationErrorsQuad.Text = "Validation Errors";
            // 
            // btnSetHome
            // 
            this.btnSetHome.Location = new System.Drawing.Point(36, 57);
            this.btnSetHome.Name = "btnSetHome";
            this.btnSetHome.Size = new System.Drawing.Size(220, 44);
            this.btnSetHome.TabIndex = 23;
            this.btnSetHome.Text = "Setear Origen";
            this.btnSetHome.UseVisualStyleBackColor = true;
            this.btnSetHome.Click += new System.EventHandler(this.BtnSetHome_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.cboCom);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(59, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 172);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Conexión";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnSetHome);
            this.groupBox3.Controls.Add(this.btnReturnZero);
            this.groupBox3.Controls.Add(this.btnZup);
            this.groupBox3.Controls.Add(this.btnXRight);
            this.groupBox3.Controls.Add(this.btnZDown);
            this.groupBox3.Controls.Add(this.btnYRight);
            this.groupBox3.Controls.Add(this.btnYLeft);
            this.groupBox3.Controls.Add(this.btnXLeft);
            this.groupBox3.Location = new System.Drawing.Point(893, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 429);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Movimiento";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(36, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(272, 87);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRunImport);
            this.groupBox4.Controls.Add(this.lblImportationResult);
            this.groupBox4.Controls.Add(this.btnExplore);
            this.groupBox4.Location = new System.Drawing.Point(59, 519);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(789, 217);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Importar Archivo";
            // 
            // btnRunImport
            // 
            this.btnRunImport.Location = new System.Drawing.Point(311, 75);
            this.btnRunImport.Name = "btnRunImport";
            this.btnRunImport.Size = new System.Drawing.Size(220, 53);
            this.btnRunImport.TabIndex = 22;
            this.btnRunImport.Text = "Ejecutar";
            this.btnRunImport.UseVisualStyleBackColor = true;
            this.btnRunImport.Click += new System.EventHandler(this.BtnRunImport_Click);
            // 
            // lblImportationResult
            // 
            this.lblImportationResult.AutoSize = true;
            this.lblImportationResult.ForeColor = System.Drawing.Color.Red;
            this.lblImportationResult.Location = new System.Drawing.Point(56, 162);
            this.lblImportationResult.Name = "lblImportationResult";
            this.lblImportationResult.Size = new System.Drawing.Size(18, 25);
            this.lblImportationResult.TabIndex = 21;
            this.lblImportationResult.Text = ".";
            // 
            // btnExplore
            // 
            this.btnExplore.Location = new System.Drawing.Point(46, 75);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(220, 53);
            this.btnExplore.TabIndex = 11;
            this.btnExplore.Text = "Explorar";
            this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler(this.BtnExplore_Click);
            // 
            // btnSetProperty
            // 
            this.btnSetProperty.Location = new System.Drawing.Point(929, 519);
            this.btnSetProperty.Name = "btnSetProperty";
            this.btnSetProperty.Size = new System.Drawing.Size(220, 51);
            this.btnSetProperty.TabIndex = 25;
            this.btnSetProperty.Text = "Setear Propiedad";
            this.btnSetProperty.UseVisualStyleBackColor = true;
            this.btnSetProperty.Click += new System.EventHandler(this.BtnSetProperty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1348);
            this.Controls.Add(this.btnSetProperty);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.Button btnXRight;
        private System.Windows.Forms.Button btnYRight;
        private System.Windows.Forms.Button btnYLeft;
        private System.Windows.Forms.Button btnXLeft;
        private System.Windows.Forms.Button btnZDown;
        private System.Windows.Forms.Button btnZup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkRele;
        private System.Windows.Forms.CheckBox chkSimulate;
        private System.Windows.Forms.Button btnReturnZero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValidationErrorsQuad;
        private System.Windows.Forms.Button btnSetHome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblImportationResult;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Button btnRunImport;
        private System.Windows.Forms.Button btnSetProperty;
    }
}

