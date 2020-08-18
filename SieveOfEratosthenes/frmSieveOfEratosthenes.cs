using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace SieveOfEratosthenes
{
	/// <summary>
	/// Summary description for Sieve Of Eratosthenes.
	/// </summary>
	public class frmSieveOfEratosthenes : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblActualPrimes;
		private System.Windows.Forms.Label lblEstPrimes;
		private System.Windows.Forms.TextBox txtMaxNumber;
		private System.Windows.Forms.ListBox lstPrimes;
		private System.Windows.Forms.Button btnFindPrimes;
		private System.Windows.Forms.TextBox txtEstPrimes;
		private System.Windows.Forms.TextBox txtActualPrimes;
		private System.Windows.Forms.Button btnExit;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSieveOfEratosthenes()
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
			this.lblActualPrimes = new System.Windows.Forms.Label();
			this.lblEstPrimes = new System.Windows.Forms.Label();
			this.txtMaxNumber = new System.Windows.Forms.TextBox();
			this.txtEstPrimes = new System.Windows.Forms.TextBox();
			this.txtActualPrimes = new System.Windows.Forms.TextBox();
			this.btnFindPrimes = new System.Windows.Forms.Button();
			this.lstPrimes = new System.Windows.Forms.ListBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Max Number:";
			// 
			// lblActualPrimes
			// 
			this.lblActualPrimes.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblActualPrimes.Location = new System.Drawing.Point(16, 88);
			this.lblActualPrimes.Name = "lblActualPrimes";
			this.lblActualPrimes.Size = new System.Drawing.Size(160, 16);
			this.lblActualPrimes.TabIndex = 1;
			this.lblActualPrimes.Text = "Actual Primes:";
			// 
			// lblEstPrimes
			// 
			this.lblEstPrimes.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblEstPrimes.Location = new System.Drawing.Point(16, 56);
			this.lblEstPrimes.Name = "lblEstPrimes";
			this.lblEstPrimes.Size = new System.Drawing.Size(160, 16);
			this.lblEstPrimes.TabIndex = 2;
			this.lblEstPrimes.Text = "Estimate Primes:";
			// 
			// txtMaxNumber
			// 
			this.txtMaxNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtMaxNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.txtMaxNumber.Location = new System.Drawing.Point(176, 24);
			this.txtMaxNumber.MaxLength = 6;
			this.txtMaxNumber.Name = "txtMaxNumber";
			this.txtMaxNumber.Size = new System.Drawing.Size(88, 26);
			this.txtMaxNumber.TabIndex = 3;
			this.txtMaxNumber.Text = "";
			// 
			// txtEstPrimes
			// 
			this.txtEstPrimes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtEstPrimes.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.txtEstPrimes.Location = new System.Drawing.Point(176, 56);
			this.txtEstPrimes.MaxLength = 6;
			this.txtEstPrimes.Name = "txtEstPrimes";
			this.txtEstPrimes.ReadOnly = true;
			this.txtEstPrimes.Size = new System.Drawing.Size(88, 26);
			this.txtEstPrimes.TabIndex = 4;
			this.txtEstPrimes.Text = "";
			// 
			// txtActualPrimes
			// 
			this.txtActualPrimes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtActualPrimes.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.txtActualPrimes.Location = new System.Drawing.Point(176, 88);
			this.txtActualPrimes.MaxLength = 6;
			this.txtActualPrimes.Name = "txtActualPrimes";
			this.txtActualPrimes.ReadOnly = true;
			this.txtActualPrimes.Size = new System.Drawing.Size(88, 26);
			this.txtActualPrimes.TabIndex = 5;
			this.txtActualPrimes.Text = "";
			// 
			// btnFindPrimes
			// 
			this.btnFindPrimes.BackColor = System.Drawing.Color.White;
			this.btnFindPrimes.Font = new System.Drawing.Font("Transformers Movie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnFindPrimes.Location = new System.Drawing.Point(344, 32);
			this.btnFindPrimes.Name = "btnFindPrimes";
			this.btnFindPrimes.Size = new System.Drawing.Size(120, 24);
			this.btnFindPrimes.TabIndex = 7;
			this.btnFindPrimes.Text = "FIND &PRIMES";
			this.btnFindPrimes.Click += new System.EventHandler(this.btnFindPrimes_Click);
			// 
			// lstPrimes
			// 
			this.lstPrimes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lstPrimes.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.lstPrimes.HorizontalScrollbar = true;
			this.lstPrimes.ItemHeight = 20;
			this.lstPrimes.Location = new System.Drawing.Point(16, 120);
			this.lstPrimes.MultiColumn = true;
			this.lstPrimes.Name = "lstPrimes";
			this.lstPrimes.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lstPrimes.Size = new System.Drawing.Size(448, 204);
			this.lstPrimes.TabIndex = 8;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.Font = new System.Drawing.Font("Transformers Movie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(344, 72);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(120, 24);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "E&XIT";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmSieveOfEratosthenes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(480, 338);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.lstPrimes);
			this.Controls.Add(this.btnFindPrimes);
			this.Controls.Add(this.txtActualPrimes);
			this.Controls.Add(this.txtEstPrimes);
			this.Controls.Add(this.txtMaxNumber);
			this.Controls.Add(this.lblEstPrimes);
			this.Controls.Add(this.lblActualPrimes);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSieveOfEratosthenes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SIEVE OF ERATOSTHENES";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmSieveOfEratosthenes());
		}

		// Build a Sieve of Eratosthenes.
		private bool[] MakeSieve(int max)
		{
			// Make an array indicating whether numbers are prime.
			bool[] is_prime = new bool[max + 1];
			is_prime[2] = true;
			for (int i = 3; i <= max; i += 2) 
				is_prime[i] = true;

			// Cross out multiples of odd primes.
			for (int i = 3; i <= max; i += 2)
			{
				// See if i is prime.
				if (is_prime[i])
				{
					// Knock out multiples of i.
					for (int j = i * 3; j <= max; j += i)
						is_prime[j] = false;
				}
			}
			return is_prime;
		}

		// Make a sieve and display the primes.
		private void btnFindPrimes_Click(object sender, System.EventArgs e)
		{
			lstPrimes.Items.Clear();
			txtEstPrimes.Text = "";
			txtActualPrimes.Text = "";

			// Make the sieve.
			int max = int.Parse(txtMaxNumber.Text);
			bool[] is_prime = MakeSieve(max);

			// Display the primes.
			int num_primes = 0;
			for (int i = 2; i <= max; i++)
				if (is_prime[i])
				{
					if (num_primes <= 999999) 
						lstPrimes.Items.Add(i);
					num_primes++;
				}

			// Display the estimated and actual number of primes.
			txtActualPrimes.Text = num_primes.ToString();	
		
			// Display a Legendre estimate ?(n) = n/(log(n) - 1.08366).
			double est = (max / (Math.Log(max) - 1.08366));
			txtEstPrimes.Text = est.ToString("0");
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit the Sieve of Eratosthenes Program?", "SIEVE OF ERATOSTHENES", MessageBoxButtons.OKCancel) == DialogResult.OK)
				Application.Exit();
		}
	}
}