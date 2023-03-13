namespace examenm5uf2
{
	partial class FrmMain
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Yellow;
			this.button1.Location = new System.Drawing.Point(61, 79);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(288, 53);
			this.button1.TabIndex = 0;
			this.button1.Text = "&Animal";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Fuchsia;
			this.button2.Location = new System.Drawing.Point(392, 79);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(308, 53);
			this.button2.TabIndex = 1;
			this.button2.Text = "&Viaje";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Fuchsia;
			this.button3.Location = new System.Drawing.Point(246, 199);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(308, 53);
			this.button3.TabIndex = 2;
			this.button3.Text = "&Comer";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "FrmMain";
			this.Text = "FrmMain";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}

