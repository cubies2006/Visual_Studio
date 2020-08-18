using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace BitshiftOperations
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmBitshiftOperations : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button vtnRight;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtInt;
		private System.Windows.Forms.TextBox txtBitShift;
		private System.Windows.Forms.Label lblIntBits;
		private System.Windows.Forms.Label lblOrigBits;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmBitshiftOperations()
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtInt = new System.Windows.Forms.TextBox();
			this.txtBitShift = new System.Windows.Forms.TextBox();
			this.lblIntBits = new System.Windows.Forms.Label();
			this.lblOrigBits = new System.Windows.Forms.Label();
			this.btnLeft = new System.Windows.Forms.Button();
			this.vtnRight = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Transformers Movie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Integer to Shift:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Transformers Movie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(232, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Bits to Shift:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtInt
			// 
			this.txtInt.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtInt.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.txtInt.Location = new System.Drawing.Point(80, 80);
			this.txtInt.MaxLength = 10;
			this.txtInt.Name = "txtInt";
			this.txtInt.Size = new System.Drawing.Size(96, 25);
			this.txtInt.TabIndex = 2;
			this.txtInt.Text = "";
			this.txtInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtBitShift
			// 
			this.txtBitShift.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtBitShift.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.txtBitShift.Location = new System.Drawing.Point(232, 80);
			this.txtBitShift.MaxLength = 1;
			this.txtBitShift.Name = "txtBitShift";
			this.txtBitShift.Size = new System.Drawing.Size(104, 25);
			this.txtBitShift.TabIndex = 3;
			this.txtBitShift.Text = "";
			this.txtBitShift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblIntBits
			// 
			this.lblIntBits.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblIntBits.Location = new System.Drawing.Point(16, 168);
			this.lblIntBits.Name = "lblIntBits";
			this.lblIntBits.Size = new System.Drawing.Size(384, 24);
			this.lblIntBits.TabIndex = 4;
			this.lblIntBits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblOrigBits
			// 
			this.lblOrigBits.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblOrigBits.Location = new System.Drawing.Point(16, 120);
			this.lblOrigBits.Name = "lblOrigBits";
			this.lblOrigBits.Size = new System.Drawing.Size(384, 32);
			this.lblOrigBits.TabIndex = 5;
			this.lblOrigBits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnLeft
			// 
			this.btnLeft.BackColor = System.Drawing.Color.Crimson;
			this.btnLeft.Font = new System.Drawing.Font("Transformers Movie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnLeft.Location = new System.Drawing.Point(120, 208);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(72, 32);
			this.btnLeft.TabIndex = 6;
			this.btnLeft.Text = "<<";
			this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
			// 
			// vtnRight
			// 
			this.vtnRight.BackColor = System.Drawing.Color.Blue;
			this.vtnRight.Font = new System.Drawing.Font("Transformers Movie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vtnRight.Location = new System.Drawing.Point(232, 208);
			this.vtnRight.Name = "vtnRight";
			this.vtnRight.Size = new System.Drawing.Size(72, 32);
			this.vtnRight.TabIndex = 7;
			this.vtnRight.Text = ">>";
			this.vtnRight.Click += new System.EventHandler(this.vtnRight_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Green;
			this.btnClear.Font = new System.Drawing.Font("Transformers Movie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(120, 256);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(72, 32);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "&CLEAR";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Yellow;
			this.btnExit.Font = new System.Drawing.Font("Transformers Movie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(232, 256);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(72, 32);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "E&XIT";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
			// 
			// frmBitshiftOperations
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(416, 330);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.vtnRight);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.lblOrigBits);
			this.Controls.Add(this.lblIntBits);
			this.Controls.Add(this.txtBitShift);
			this.Controls.Add(this.txtInt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBitshiftOperations";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BITSHIFT OPERATIONS";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmBitshiftOperations());
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
					bitBuffer.Append(" ");			}
			return bitBuffer;
		}

		private void btnExit_Click_1(object sender, System.EventArgs e)
		{
			this.Close();		
		}

		private void btnLeft_Click(object sender, System.EventArgs e)
		{
            int value = Int32.Parse(txtInt.Text);
            lblOrigBits.Text = ConvertBits(value).ToString();
            value <<= Int32.Parse(txtBitShift.Text);
            lblIntBits.Text = ConvertBits(value).ToString();
        }

		private void vtnRight_Click(object sender, System.EventArgs e)
		{
			int value = Int32.Parse(txtInt.Text);
			lblOrigBits.Text = ConvertBits(value).ToString();
			value >>= Int32.Parse(txtBitShift.Text);
			lblIntBits.Text = ConvertBits(value).ToString();
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			txtInt.Text = "";
			txtInt.Focus();
			txtBitShift.Text = "";
			lblOrigBits.Text = "";
			lblIntBits.Text = "";
		}
	}
}
