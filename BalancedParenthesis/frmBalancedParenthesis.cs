using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BalancedParenthesis
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmBalancedParenthesis : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnValidate;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtExpression;
		private System.Windows.Forms.Label lblExpression;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmBalancedParenthesis()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtExpression = new System.Windows.Forms.TextBox();
			this.btnValidate = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblExpression = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtExpression
			// 
			this.txtExpression.BackColor = System.Drawing.Color.Honeydew;
			this.txtExpression.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtExpression.Location = new System.Drawing.Point(16, 48);
			this.txtExpression.MaxLength = 55;
			this.txtExpression.Name = "txtExpression";
			this.txtExpression.Size = new System.Drawing.Size(512, 26);
			this.txtExpression.TabIndex = 0;
			this.txtExpression.Text = "";
			this.txtExpression.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnValidate
			// 
			this.btnValidate.BackColor = System.Drawing.Color.Gainsboro;
			this.btnValidate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnValidate.Location = new System.Drawing.Point(16, 88);
			this.btnValidate.Name = "btnValidate";
			this.btnValidate.Size = new System.Drawing.Size(160, 32);
			this.btnValidate.TabIndex = 1;
			this.btnValidate.Text = "&VALIDATE";
			this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Gainsboro;
			this.btnClear.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(192, 88);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(160, 32);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "&CLEAR";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
			this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(368, 88);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(160, 32);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "E&XIT";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblExpression
			// 
			this.lblExpression.Font = new System.Drawing.Font("Transformers Movie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblExpression.ForeColor = System.Drawing.Color.Orange;
			this.lblExpression.Location = new System.Drawing.Point(16, 16);
			this.lblExpression.Name = "lblExpression";
			this.lblExpression.Size = new System.Drawing.Size(512, 24);
			this.lblExpression.TabIndex = 4;
			this.lblExpression.Text = "Enter an arithmetic expression: ";
			this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmBalancedParenthesis
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Maroon;
			this.ClientSize = new System.Drawing.Size(544, 138);
			this.Controls.Add(this.lblExpression);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnValidate);
			this.Controls.Add(this.txtExpression);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBalancedParenthesis";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BALANCED PARENTHESIS";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmBalancedParenthesis());
		}

		public bool CheckBalancedParenthesis(String expr)
		{
			int len = expr.Length;
			Stack s = new Stack();
			for (int i = 0; i <= len - 1; i++)
			{
				if (expr[i].ToString() == "(" || expr[i].ToString() == "{" || expr[i].ToString() == "[")
					s.Push(expr[i]);
				else if (expr[i].ToString() == ")" || expr[i].ToString() == "}" || expr[i].ToString() == "]")
					if (s.Count == 0 || s.Peek().ToString() != getPair(expr[i].ToString()))
						return false;
					else
						s.Pop();
			}
			return s.Count == 0 ? true : false;
		}

		public string getPair(string s)
		{
			if (s == ")")
				return "(";
			else if (s == "}")
				return "{";
			else
				return "[";
		}

		private void btnValidate_Click(object sender, System.EventArgs e)
		{
			if (txtExpression.Text == "")
			{
				return;
			}
			else if (CheckBalancedParenthesis(txtExpression.Text) == true)
			{
				txtExpression.ForeColor = Color.DarkGreen;
			}
			else if (CheckBalancedParenthesis(txtExpression.Text) == false)
			{
				txtExpression.ForeColor = Color.Red;
			}
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			txtExpression.Clear();
			txtExpression.Focus();
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}