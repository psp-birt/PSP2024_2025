using System.Diagnostics;

namespace PSP01_TA_procesos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLanzarProceso = new System.Windows.Forms.Button();
            this.buttonMatarProceso = new System.Windows.Forms.Button();
            this.buttonMostrarProcSist = new System.Windows.Forms.Button();
            this.comboBoxProc = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLanzarProceso
            // 
            this.buttonLanzarProceso.Location = new System.Drawing.Point(25, 23);
            this.buttonLanzarProceso.Name = "buttonLanzarProceso";
            this.buttonLanzarProceso.Size = new System.Drawing.Size(167, 72);
            this.buttonLanzarProceso.TabIndex = 0;
            this.buttonLanzarProceso.Text = "Lanzar Proceso Notepad";
            this.buttonLanzarProceso.UseVisualStyleBackColor = true;
            this.buttonLanzarProceso.Click += new System.EventHandler(this.buttonLanzarProceso_Click);
            // 
            // buttonMatarProceso
            // 
            this.buttonMatarProceso.Location = new System.Drawing.Point(212, 23);
            this.buttonMatarProceso.Name = "buttonMatarProceso";
            this.buttonMatarProceso.Size = new System.Drawing.Size(111, 72);
            this.buttonMatarProceso.TabIndex = 1;
            this.buttonMatarProceso.Text = "MatarProceso";
            this.buttonMatarProceso.UseVisualStyleBackColor = true;
            this.buttonMatarProceso.Click += new System.EventHandler(this.buttonMatarProceso_Click);
            // 
            // buttonMostrarProcSist
            // 
            this.buttonMostrarProcSist.Location = new System.Drawing.Point(25, 101);
            this.buttonMostrarProcSist.Name = "buttonMostrarProcSist";
            this.buttonMostrarProcSist.Size = new System.Drawing.Size(167, 72);
            this.buttonMostrarProcSist.TabIndex = 2;
            this.buttonMostrarProcSist.Text = "Mostrar Procesos Sistema";
            this.buttonMostrarProcSist.UseVisualStyleBackColor = true;
            this.buttonMostrarProcSist.Click += new System.EventHandler(this.buttonMostrarProcSist_Click);
            // 
            // comboBoxProc
            // 
            this.comboBoxProc.FormattingEnabled = true;
            this.comboBoxProc.Location = new System.Drawing.Point(212, 127);
            this.comboBoxProc.Name = "comboBoxProc";
            this.comboBoxProc.Size = new System.Drawing.Size(167, 23);
            this.comboBoxProc.TabIndex = 3;
            this.comboBoxProc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(334, 44);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 15);
            this.labelID.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 200);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.comboBoxProc);
            this.Controls.Add(this.buttonMostrarProcSist);
            this.Controls.Add(this.buttonMatarProceso);
            this.Controls.Add(this.buttonLanzarProceso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLanzarProceso;
        private Button buttonMatarProceso;
        private Button buttonMostrarProcSist;
        private ComboBox comboBoxProc;
        private Process p;
        private Label labelID;
    }
}