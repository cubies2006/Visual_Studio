using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace frmBitwiseOperations
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmBitwiseOperations : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAnd;
		private System.Windows.Forms.Button btnOr;
		private System.Windows.Forms.Button btnXor;
		private System.Windows.Forms.TextBox txtInt1;
		private System.Windows.Forms.TextBox txtInt2;
		private System.Windows.Forms.Label lblInt1Bits;
		private System.Windows.Forms.Label lblInt2Bits;
		private System.Windows.Forms.Label lblBitResult;
		private System.Windows.Forms.Label lblBits;
		private System.Windows.Forms.Label lblInt1;
		private System.Windows.Forms.Label lblInt2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmBitwiseOperations()
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
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnAnd = new System.Windows.Forms.Button();
			this.btnOr = new System.Windows.Forms.Button();
			this.btnXor = new System.Windows.Forms.Button();
			this.txtInt1 = new System.Windows.Forms.TextBox();
			this.txtInt2 = new System.Windows.Forms.TextBox();
			this.lblInt1Bits = new System.Windows.Forms.Label();
			this.lblInt2Bits = new System.Windows.Forms.Label();
			this.lblBitResult = new System.Windows.Forms.Label();
			this.lblBits = new System.Windows.Forms.Label();
			this.lblInt1 = new System.Windows.Forms.Label();
			this.lblInt2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.RosyBrown;
			this.btnClear.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(56, 152);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(80, 24);
			this.btnClear.TabIndex = 0;
			this.btnClear.Text = "&CLEAR";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.IndianRed;
			this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(56, 184);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(80, 24);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "E&XIT";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnAnd
			// 
			this.btnAnd.BackColor = System.Drawing.Color.Green;
			this.btnAnd.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnAnd.ForeColor = System.Drawing.SystemColors.Control;
			this.btnAnd.Location = new System.Drawing.Point(232, 184);
			this.btnAnd.Name = "btnAnd";
			this.btnAnd.Size = new System.Drawing.Size(64, 24);
			this.btnAnd.TabIndex = 2;
			this.btnAnd.Text = "&AND";
			this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
			// 
			// btnOr
			// 
			this.btnOr.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.btnOr.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnOr.ForeColor = System.Drawing.SystemColors.Control;
			this.btnOr.Location = new System.Drawing.Point(304, 184);
			this.btnOr.Name = "btnOr";
			this.btnOr.Size = new System.Drawing.Size(64, 24);
			this.btnOr.TabIndex = 3;
			this.btnOr.Text = "&OR";
			this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
			// 
			// btnXor
			// 
			this.btnXor.BackColor = System.Drawing.Color.Blue;
			this.btnXor.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnXor.ForeColor = System.Drawing.SystemColors.Control;
			this.btnXor.Location = new System.Drawing.Point(376, 184);
			this.btnXor.Name = "btnXor";
			this.btnXor.Size = new System.Drawing.Size(64, 24);
			this.btnXor.TabIndex = 4;
			this.btnXor.Text = "&XOR";
			this.btnXor.Click += new System.EventHandler(this.btnXor_Click);
			// 
			// txtInt1
			// 
			this.txtInt1.BackColor = System.Drawing.SystemColors.Control;
			this.txtInt1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtInt1.Location = new System.Drawing.Point(80, 64);
			this.txtInt1.MaxLength = 10;
			this.txtInt1.Name = "txtInt1";
			this.txtInt1.Size = new System.Drawing.Size(96, 23);
			this.txtInt1.TabIndex = 5;
			this.txtInt1.Text = "";
			// 
			// txtInt2
			// 
			this.txtInt2.BackColor = System.Drawing.SystemColors.Control;
			this.txtInt2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtInt2.Location = new System.Drawing.Point(80, 88);
			this.txtInt2.MaxLength = 10;
			this.txtInt2.Name = "txtInt2";
			this.txtInt2.Size = new System.Drawing.Size(96, 23);
			this.txtInt2.TabIndex = 6;
			this.txtInt2.Text = "";
			// 
			// lblInt1Bits
			// 
			this.lblInt1Bits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblInt1Bits.Location = new System.Drawing.Point(192, 64);
			this.lblInt1Bits.Name = "lblInt1Bits";
			this.lblInt1Bits.Size = new System.Drawing.Size(296, 24);
			this.lblInt1Bits.TabIndex = 7;
			this.lblInt1Bits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblInt2Bits
			// 
			this.lblInt2Bits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblInt2Bits.Location = new System.Drawing.Point(192, 96);
			this.lblInt2Bits.Name = "lblInt2Bits";
			this.lblInt2Bits.Size = new System.Drawing.Size(296, 24);
			this.lblInt2Bits.TabIndex = 8;
			this.lblInt2Bits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBitResult
			// 
			this.lblBitResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblBitResult.Location = new System.Drawing.Point(192, 136);
			this.lblBitResult.Name = "lblBitResult";
			this.lblBitResult.Size = new System.Drawing.Size(296, 24);
			this.lblBitResult.TabIndex = 9;
			this.lblBitResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBits
			// 
			this.lblBits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblBits.Location = new System.Drawing.Point(192, 24);
			this.lblBits.Name = "lblBits";
			this.lblBits.Size = new System.Drawing.Size(288, 24);
			this.lblBits.TabIndex = 10;
			this.lblBits.Text = "Bits (in 4 octaves)";
			this.lblBits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblInt1
			// 
			this.lblInt1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblInt1.Location = new System.Drawing.Point(8, 64);
			this.lblInt1.Name = "lblInt1";
			this.lblInt1.Size = new System.Drawing.Size(72, 24);
			this.lblInt1.TabIndex = 11;
			this.lblInt1.Text = "Integer 1";
			// 
			// lblInt2
			// 
			this.lblInt2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblInt2.Location = new System.Drawing.Point(8, 88);
			this.lblInt2.Name = "lblInt2";
			this.lblInt2.Size = new System.Drawing.Size(72, 24);
			this.lblInt2.TabIndex = 12;
			this.lblInt2.Text = "Integer 2";
			// 
			// frmBitwiseOperations
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(496, 234);
			this.Controls.Add(this.lblInt2);
			this.Controls.Add(this.lblInt1);
			this.Controls.Add(this.lblBits);
			this.Controls.Add(this.lblBitResult);
			this.Controls.Add(this.lblInt2Bits);
			this.Controls.Add(this.lblInt1Bits);
			this.Controls.Add(this.txtInt2);
			this.Controls.Add(this.txtInt1);
			this.Controls.Add(this.btnXor);
			this.Controls.Add(this.btnOr);
			this.Controls.Add(this.btnAnd);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBitwiseOperations";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BITWISE OPERATIONS";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmBitwiseOperations());
		}

		private StringBuilder ConvertBits(int val)
		{
			int dispMask = 1 << 31;
			StringBuilder bitBuffer = new StringBuilder(35);
			for(int i = 1; i <= 32; i++) 
			{
				if ((val & dispMask) == 0)
					bitBuffer.Append("0");
				else
					bitBuffer.Append("1");
				val <<= 1;
				if ((i % 8) == 0)
					bitBuffer.Append(" ");
			}
			return bitBuffer;
		}

		private void btnAnd_Click(object sender, System.EventArgs e)
		{
			int val1, val2;
			val1 = Int32.Parse(txtInt1.Text);
			val2 = Int32.Parse(txtInt2.Text);
			lblInt1Bits.Text = ConvertBits(val1).ToString();
			lblInt2Bits.Text = ConvertBits(val2).ToString();			
			lblBitResult.Text = ConvertBits(val1 & val2).ToString();
		}

		private void btnOr_Click(object sender, System.EventArgs e)
		{
			int val1, val2;
			val1 = Int32.Parse(txtInt1.Text);
			val2 = Int32.Parse(txtInt2.Text);
			lblInt1Bits.Text = ConvertBits(val1).ToString();
			lblInt2Bits.Text = ConvertBits(val2).ToString();
			lblBitResult.Text = ConvertBits(val1 | val2).ToString();
		}

		private void btnXor_Click(object sender, System.EventArgs e)
		{
			int val1, val2;
			val1 = Int32.Parse(txtInt1.Text);
			val2 = Int32.Parse(txtInt2.Text);
			lblInt1Bits.Text = ConvertBits(val1).ToString();
			lblInt2Bits.Text = ConvertBits(val2).ToString();
			lblBitResult.Text = ConvertBits(val1 ^ val2).ToString();
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			txtInt1.Text = "";
			txtInt2.Text = "";
			lblInt1Bits.Text = "";
			lblInt2Bits.Text = "";
			lblBitResult.Text = "";
			txtInt1.Focus();
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
