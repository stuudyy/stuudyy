﻿namespace Zufallsgenerator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.btnbearbeiten = new System.Windows.Forms.Button();
            this.btnentfernen = new System.Windows.Forms.Button();
            this.btnAllesEntfernen = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHinzufügen.Location = new System.Drawing.Point(776, 70);
            this.btnHinzufügen.Margin = new System.Windows.Forms.Padding(4);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(243, 54);
            this.btnHinzufügen.TabIndex = 0;
            this.btnHinzufügen.Text = "Eintrag hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // btnbearbeiten
            // 
            this.btnbearbeiten.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbearbeiten.Location = new System.Drawing.Point(776, 146);
            this.btnbearbeiten.Margin = new System.Windows.Forms.Padding(4);
            this.btnbearbeiten.Name = "btnbearbeiten";
            this.btnbearbeiten.Size = new System.Drawing.Size(243, 54);
            this.btnbearbeiten.TabIndex = 1;
            this.btnbearbeiten.Text = "Eintrag bearbeiten";
            this.btnbearbeiten.UseVisualStyleBackColor = true;
            // 
            // btnentfernen
            // 
            this.btnentfernen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentfernen.Location = new System.Drawing.Point(776, 220);
            this.btnentfernen.Margin = new System.Windows.Forms.Padding(4);
            this.btnentfernen.Name = "btnentfernen";
            this.btnentfernen.Size = new System.Drawing.Size(243, 54);
            this.btnentfernen.TabIndex = 2;
            this.btnentfernen.Text = "Eintrag entfernen";
            this.btnentfernen.UseVisualStyleBackColor = true;
            // 
            // btnAllesEntfernen
            // 
            this.btnAllesEntfernen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllesEntfernen.Location = new System.Drawing.Point(776, 298);
            this.btnAllesEntfernen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllesEntfernen.Name = "btnAllesEntfernen";
            this.btnAllesEntfernen.Size = new System.Drawing.Size(243, 54);
            this.btnAllesEntfernen.TabIndex = 3;
            this.btnAllesEntfernen.Text = "Alle Einträge entfernen";
            this.btnAllesEntfernen.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(776, 410);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(243, 54);
            this.button5.TabIndex = 4;
            this.button5.Text = "Alle Einträge sortieren";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(776, 482);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(243, 54);
            this.button6.TabIndex = 5;
            this.button6.Text = "Alle Einträge mischen";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(58, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(584, 477);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nummer";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 480;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(17, 22);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(705, 522);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nummer";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 580;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 582);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnAllesEntfernen);
            this.Controls.Add(this.btnentfernen);
            this.Controls.Add(this.btnbearbeiten);
            this.Controls.Add(this.btnHinzufügen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Projekte";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Button btnbearbeiten;
        private System.Windows.Forms.Button btnentfernen;
        private System.Windows.Forms.Button btnAllesEntfernen;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

