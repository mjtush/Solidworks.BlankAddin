
namespace Solidworks.BlankAddin
{
	partial class TaskpaneHostUI
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.myButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// myButton
			// 
			this.myButton.Location = new System.Drawing.Point(148, 127);
			this.myButton.Name = "myButton";
			this.myButton.Size = new System.Drawing.Size(121, 43);
			this.myButton.TabIndex = 0;
			this.myButton.Text = "myButton";
			this.myButton.UseVisualStyleBackColor = true;
			// 
			// TaskpaneHostUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.myButton);
			this.Name = "TaskpaneHostUI";
			this.Size = new System.Drawing.Size(445, 434);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button myButton;
	}
}
