namespace CenterWindowsDialog
{
  partial class FormOption
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.buttonOK = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonOK
      // 
      this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonOK.Location = new System.Drawing.Point(93, 225);
      this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new System.Drawing.Size(100, 28);
      this.buttonOK.TabIndex = 0;
      this.buttonOK.Text = "OK";
      this.buttonOK.UseVisualStyleBackColor = true;
      this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCancel.Location = new System.Drawing.Point(280, 225);
      this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(100, 28);
      this.buttonCancel.TabIndex = 1;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
      // 
      // FormOption
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(459, 307);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonOK);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "FormOption";
      this.Text = "FormOption";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button buttonCancel;
  }
}