namespace Sistema_Goniotech
{
    partial class Localizar_Paciente
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
            this.btn_avaliar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_avaliar
            // 
            this.btn_avaliar.BackgroundImage = global::Sistema_Goniotech.Properties.Resources.Angle_Thingy_36322;
            this.btn_avaliar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_avaliar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_avaliar.Location = new System.Drawing.Point(688, 341);
            this.btn_avaliar.Name = "btn_avaliar";
            this.btn_avaliar.Size = new System.Drawing.Size(75, 76);
            this.btn_avaliar.TabIndex = 0;
            this.btn_avaliar.Text = "Avaliar Paciente";
            this.btn_avaliar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_avaliar.UseVisualStyleBackColor = true;
            this.btn_avaliar.Click += new System.EventHandler(this.btn_avaliar_Click);
            // 
            // Localizar_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_avaliar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Localizar_Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar_Paciente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_avaliar;
    }
}