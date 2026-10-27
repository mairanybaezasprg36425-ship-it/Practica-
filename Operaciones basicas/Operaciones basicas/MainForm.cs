/*
 * Created by SharpDevelop.
 * User: CC2_PC07
 * Date: 27/10/2026
 * Time: 07:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Operaciones_basicas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSumaClick(object sender, EventArgs e)
		{
			double num1, num2, suma;
			num1=Convert.ToDouble(txtNum1.Text);
			num2=Convert.ToDouble(txtNum2.Text);
			suma=num1+num2;
			lblResultado.Text=txtNum1.Text+"+"+txtNum2.Text+"= "+Convert.ToString(suma);			
		}
		
		void BtnMutiClick(object sender, EventArgs e)
		{
			double num1, num2, multi;
			num1=Convert.ToDouble(txtNum1.Text);
			num2=Convert.ToDouble(txtNum2.Text);
			multi=num1*num2;
			lblResultado.Text=txtNum1.Text+"*"+txtNum2.Text+"= "+Convert.ToString(multi);					
		}
		
		void BtnRestaClick(object sender, EventArgs e)
		{
			double num1, num2, resta;
			num1=Convert.ToDouble(txtNum1.Text);
			num2=Convert.ToDouble(txtNum2.Text);
			resta=num1-num2;
			lblResultado.Text=txtNum1.Text+"-"+txtNum2.Text+"= "+Convert.ToString(resta);			
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			double num1, num2, divi;
			num1=Convert.ToDouble(txtNum1.Text);
			num2=Convert.ToDouble(txtNum2.Text);
			divi=num1/num2;
			lblResultado.Text=txtNum1.Text+"/"+txtNum2.Text+"= "+Convert.ToString(divi);			
		}
		
		void LblResultadoClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnModuloClick(object sender, EventArgs e)
		{
			double num1, num2, modu;
			num1=Convert.ToDouble(txtNum1.Text);
			num2=Convert.ToDouble(txtNum2.Text);
			modu=num1%num2;
			lblResultado.Text=txtNum1.Text+"%"+txtNum2.Text+"= "+Convert.ToString(modu);			
		}
	}
}
