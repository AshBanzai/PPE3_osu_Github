namespace PPE3_osu_Github
{
    partial class MenuFrais
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
            this.btn_visu = new System.Windows.Forms.Button();
            this.btn_modif = new System.Windows.Forms.Button();
            this.btn_creation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_visu
            // 
            this.btn_visu.Location = new System.Drawing.Point(297, 68);
            this.btn_visu.Name = "btn_visu";
            this.btn_visu.Size = new System.Drawing.Size(192, 23);
            this.btn_visu.TabIndex = 0;
            this.btn_visu.Text = "Visualiser la fiche de frais";
            this.btn_visu.UseVisualStyleBackColor = true;
            this.btn_visu.Click += new System.EventHandler(this.btn_visu_Click);
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(297, 127);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(192, 23);
            this.btn_modif.TabIndex = 1;
            this.btn_modif.Text = "Modifier la fiche de frais";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // btn_creation
            // 
            this.btn_creation.Location = new System.Drawing.Point(297, 189);
            this.btn_creation.Name = "btn_creation";
            this.btn_creation.Size = new System.Drawing.Size(192, 23);
            this.btn_creation.TabIndex = 2;
            this.btn_creation.Text = "Créer une fiche de frais";
            this.btn_creation.UseVisualStyleBackColor = true;
            this.btn_creation.Click += new System.EventHandler(this.btn_creation_Click);
            // 
            // MenuFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_creation);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.btn_visu);
            this.Name = "MenuFrais";
            this.Text = "MenuFrais";
            this.Load += new System.EventHandler(this.MenuFrais_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_visu;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Button btn_creation;
    }
}