namespace WindowsFormsLemonWay
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFibonacci = new System.Windows.Forms.Button();
            this.buttonXmlToJson = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonFibonacci
            // 
            this.buttonFibonacci.Location = new System.Drawing.Point(330, 39);
            this.buttonFibonacci.Name = "buttonFibonacci";
            this.buttonFibonacci.Size = new System.Drawing.Size(185, 68);
            this.buttonFibonacci.TabIndex = 0;
            this.buttonFibonacci.Text = "Compute Fibonancci(10)";
            this.buttonFibonacci.UseVisualStyleBackColor = true;
            this.buttonFibonacci.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonXmlToJson
            // 
            this.buttonXmlToJson.Location = new System.Drawing.Point(100, 246);
            this.buttonXmlToJson.Name = "buttonXmlToJson";
            this.buttonXmlToJson.Size = new System.Drawing.Size(185, 80);
            this.buttonXmlToJson.TabIndex = 1;
            this.buttonXmlToJson.Text = "Compute Xml To Json";
            this.buttonXmlToJson.UseVisualStyleBackColor = true;
            this.buttonXmlToJson.Click += new System.EventHandler(this.buttonXmlToJson_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 185);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 238);
            this.textBox1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonXmlToJson);
            this.Controls.Add(this.buttonFibonacci);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFibonacci;
        private System.Windows.Forms.Button buttonXmlToJson;
        private System.Windows.Forms.TextBox textBox1;
    }
}

