namespace Sistema_Goniotech
{
    partial class Index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cadastrar_paciente = new System.Windows.Forms.Button();
            this.btn_cadastrar_fisio = new System.Windows.Forms.Button();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cadastrar_paciente
            // 
            this.btn_cadastrar_paciente.BackgroundImage = global::Sistema_Goniotech.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.btn_cadastrar_paciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cadastrar_paciente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrar_paciente.Location = new System.Drawing.Point(43, 42);
            this.btn_cadastrar_paciente.Name = "btn_cadastrar_paciente";
            this.btn_cadastrar_paciente.Size = new System.Drawing.Size(100, 100);
            this.btn_cadastrar_paciente.TabIndex = 0;
            this.btn_cadastrar_paciente.Text = "Cadastrar Paciente";
            this.btn_cadastrar_paciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastrar_paciente.UseCompatibleTextRendering = true;
            this.btn_cadastrar_paciente.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar_fisio
            // 
            this.btn_cadastrar_fisio.BackgroundImage = global::Sistema_Goniotech.Properties.Resources.Doctor_Male_icon_icons_com_75051;
            this.btn_cadastrar_fisio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cadastrar_fisio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrar_fisio.Location = new System.Drawing.Point(43, 177);
            this.btn_cadastrar_fisio.Name = "btn_cadastrar_fisio";
            this.btn_cadastrar_fisio.Size = new System.Drawing.Size(100, 100);
            this.btn_cadastrar_fisio.TabIndex = 1;
            this.btn_cadastrar_fisio.Text = "Cadastrar Fisioterapeuta";
            this.btn_cadastrar_fisio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastrar_fisio.UseVisualStyleBackColor = true;
            // 
            // btn_localizar
            // 
            this.btn_localizar.BackgroundImage = global::Sistema_Goniotech.Properties.Resources.business_man_usersearch_thesearch_theclient_2356;
            this.btn_localizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_localizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_localizar.Location = new System.Drawing.Point(43, 295);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(100, 100);
            this.btn_localizar.TabIndex = 2;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_localizar.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sistema_Goniotech.Properties.Resources.Logo_OK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_localizar);
            this.Controls.Add(this.btn_cadastrar_fisio);
            this.Controls.Add(this.btn_cadastrar_paciente);
            this.DoubleBuffered = true;
            this.Name = "Index";
            this.ShowIcon = false;
            this.Text = "GonioTech";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar_paciente;
        private System.Windows.Forms.Button btn_cadastrar_fisio;
        private System.Windows.Forms.Button btn_localizar;
    }
}

