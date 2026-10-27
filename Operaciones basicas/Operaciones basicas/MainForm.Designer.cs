/*
 * Created by SharpDevelop.
 * User: CC2_PC07
 * Date: 27/10/2026
 * Time: 07:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Operaciones_basicas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNum1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnMuti = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNum1
			// 
			this.lblNum1.Location = new System.Drawing.Point(12, 26);
			this.lblNum1.Name = "lblNum1";
			this.lblNum1.Size = new System.Drawing.Size(110, 23);
			this.lblNum1.TabIndex = 0;
			this.lblNum1.Text = "Numero 1:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Numero 2:";
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(150, 26);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(141, 26);
			this.txtNum1.TabIndex = 2;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(150, 67);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(141, 26);
			this.txtNum2.TabIndex = 3;
			// 
			// btnSuma
			// 
			this.btnSuma.Location = new System.Drawing.Point(12, 134);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(75, 33);
			this.btnSuma.TabIndex = 4;
			this.btnSuma.Text = "Suma";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// btnResta
			// 
			this.btnResta.Location = new System.Drawing.Point(225, 133);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(75, 33);
			this.btnResta.TabIndex = 5;
			this.btnResta.Text = "Resta";
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.BtnRestaClick);
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(13, 173);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(75, 37);
			this.btnDividir.TabIndex = 6;
			this.btnDividir.Text = "Division";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// btnMuti
			// 
			this.btnMuti.Location = new System.Drawing.Point(225, 172);
			this.btnMuti.Name = "btnMuti";
			this.btnMuti.Size = new System.Drawing.Size(75, 38);
			this.btnMuti.TabIndex = 7;
			this.btnMuti.Text = "Multiplicacion";
			this.btnMuti.UseVisualStyleBackColor = true;
			this.btnMuti.Click += new System.EventHandler(this.BtnMutiClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(63, 235);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(228, 23);
			this.lblResultado.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 276);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnMuti);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblNum1);
			this.Name = "MainForm";
			this.Text = "Operaciones basicas";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnMuti;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblNum1;
	}
}
