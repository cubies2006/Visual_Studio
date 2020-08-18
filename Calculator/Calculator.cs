using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Calculator
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmCalculator : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdAdd;
		private System.Windows.Forms.TextBox txtInput1;
		private System.Windows.Forms.TextBox txtInput2;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Button cmdMultiply;
		private System.Windows.Forms.Button cmdDivide;
		private System.Windows.Forms.Button cmdSubtract;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmCalculator()
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
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdMultiply = new System.Windows.Forms.Button();
            this.cmdDivide = new System.Windows.Forms.Button();
            this.cmdSubtract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtInput1.Location = new System.Drawing.Point(16, 16);
            this.txtInput1.MaxLength = 12;
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(269, 20);
            this.txtInput1.TabIndex = 0;
            this.txtInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInput2
            // 
            this.txtInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtInput2.Location = new System.Drawing.Point(16, 48);
            this.txtInput2.MaxLength = 12;
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(269, 20);
            this.txtInput2.TabIndex = 1;
            this.txtInput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtResult.Location = new System.Drawing.Point(16, 80);
            this.txtResult.MaxLength = 50;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(269, 20);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.Color.Blue;
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdAdd.Location = new System.Drawing.Point(156, 112);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(117, 24);
            this.cmdAdd.TabIndex = 3;
            this.cmdAdd.Text = "&ADD";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdMultiply
            // 
            this.cmdMultiply.BackColor = System.Drawing.Color.Crimson;
            this.cmdMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMultiply.Location = new System.Drawing.Point(24, 112);
            this.cmdMultiply.Name = "cmdMultiply";
            this.cmdMultiply.Size = new System.Drawing.Size(117, 24);
            this.cmdMultiply.TabIndex = 4;
            this.cmdMultiply.Text = "&MULTIPLY";
            this.cmdMultiply.UseVisualStyleBackColor = false;
            this.cmdMultiply.Click += new System.EventHandler(this.cmdMultiply_Click);
            // 
            // cmdDivide
            // 
            this.cmdDivide.BackColor = System.Drawing.Color.Green;
            this.cmdDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDivide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdDivide.Location = new System.Drawing.Point(24, 144);
            this.cmdDivide.Name = "cmdDivide";
            this.cmdDivide.Size = new System.Drawing.Size(117, 24);
            this.cmdDivide.TabIndex = 5;
            this.cmdDivide.Text = "&DIVIDE";
            this.cmdDivide.UseVisualStyleBackColor = false;
            this.cmdDivide.Click += new System.EventHandler(this.cmdDivide_Click);
            // 
            // cmdSubtract
            // 
            this.cmdSubtract.BackColor = System.Drawing.Color.Yellow;
            this.cmdSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubtract.Location = new System.Drawing.Point(156, 144);
            this.cmdSubtract.Name = "cmdSubtract";
            this.cmdSubtract.Size = new System.Drawing.Size(117, 24);
            this.cmdSubtract.TabIndex = 6;
            this.cmdSubtract.Text = "&SUBTRACT";
            this.cmdSubtract.UseVisualStyleBackColor = false;
            this.cmdSubtract.Click += new System.EventHandler(this.cmdSubtract_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(300, 186);
            this.Controls.Add(this.cmdSubtract);
            this.Controls.Add(this.cmdDivide);
            this.Controls.Add(this.cmdMultiply);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmCalculator());
		}

		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			double val1, val2;
			val1 = Double.Parse(txtInput1.Text);
			val2 = Double.Parse(txtInput2.Text);
			txtResult.Text = (val1 + val2).ToString();
		}

		private void cmdMultiply_Click(object sender, System.EventArgs e)
		{
			double val1, val2;
			val1 = Double.Parse(txtInput1.Text);
			val2 = Double.Parse(txtInput2.Text);
			txtResult.Text = (val1 * val2).ToString();
		}

		private void cmdDivide_Click(object sender, System.EventArgs e)
		{
			double val1, val2;
			val1 = Double.Parse(txtInput1.Text);
			val2 = Double.Parse(txtInput2.Text);
			txtResult.Text = (val1 / val2).ToString();
		}

		private void cmdSubtract_Click(object sender, System.EventArgs e)
		{
			double val1, val2;
			val1 = Double.Parse(txtInput1.Text);
			val2 = Double.Parse(txtInput2.Text);
			txtResult.Text = (val1 - val2).ToString();
		}
	}
}
