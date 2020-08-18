using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace WordGlossary
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmWordGlossary : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listWords;
		private System.Windows.Forms.TextBox txtDefinition;
		private Hashtable glossary = new Hashtable();
		private System.Windows.Forms.Label lblWord;
		private System.Windows.Forms.Label lblDefinition;		
		private System.ComponentModel.Container components = null;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public frmWordGlossary()
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
            this.listWords = new System.Windows.Forms.ListBox();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listWords
            // 
            this.listWords.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listWords.ItemHeight = 20;
            this.listWords.Location = new System.Drawing.Point(88, 32);
            this.listWords.Name = "listWords";
            this.listWords.Size = new System.Drawing.Size(138, 84);
            this.listWords.Sorted = true;
            this.listWords.TabIndex = 0;
            this.listWords.SelectedIndexChanged += new System.EventHandler(this.listWords_SelectedIndexChanged);
            // 
            // txtDefinition
            // 
            this.txtDefinition.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefinition.Location = new System.Drawing.Point(16, 160);
            this.txtDefinition.Multiline = true;
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(282, 80);
            this.txtDefinition.TabIndex = 1;
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(96, 8);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(114, 24);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "Word";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDefinition
            // 
            this.lblDefinition.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefinition.Location = new System.Drawing.Point(24, 128);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(274, 24);
            this.lblDefinition.TabIndex = 3;
            this.lblDefinition.Text = "Definition";
            this.lblDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmWordGlossary
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(317, 262);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.listWords);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWordGlossary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WORD GLOSSARY";
            this.Load += new System.EventHandler(this.frmWordGlossary_Load);
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
			Application.Run(new frmWordGlossary());
		}

		private void BuildGlossary(Hashtable g)
		{
			StreamReader inFile;
			string line;
			string[] words;
			inFile = File.OpenText("D:\\POST-COLYMPIC_ERA\\Important_Stuff\\Computer-Related\\Programming_Projects\\Visual_Studio\\WordGlossary\\words.txt");
			char[] delimiter = new char[]{','};
			while (inFile.Peek() != -1)
			{
				line = inFile.ReadLine();
				words = line.Split(delimiter);
				g.Add(words[0], words[1]);
			}
			inFile.Close();
		}

		private void DisplayWords(Hashtable g)
		{
			Object[] words = new Object[100];
			g.Keys.CopyTo(words, 0);
			for(int i = 0; i <= words.GetUpperBound(0); i++)
				if (!(words[i] == null))
					listWords.Items.Add((words[i]));
		}

		private void frmWordGlossary_Load(object sender, System.EventArgs e)
		{
			BuildGlossary(glossary);
			DisplayWords(glossary);
		}

		private void listWords_SelectedIndexChanged(object sender, System.EventArgs e)
		{		
			Object word;
			word = listWords.SelectedItem;
			txtDefinition.Text = glossary[word].ToString();
		}
	}
}