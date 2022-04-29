﻿
namespace PetShop
{
    partial class FormPetShop
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
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBoxAdaugare = new System.Windows.Forms.GroupBox();
            this.groupBoxOptiuni = new System.Windows.Forms.GroupBox();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.richTextBoxAfisare = new System.Windows.Forms.RichTextBox();
            this.textBoxCumparare = new System.Windows.Forms.TextBox();
            this.buttonCumpara = new System.Windows.Forms.Button();
            this.groupBoxStergere = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.labelVarstaAnimal = new System.Windows.Forms.Label();
            this.labelCategorieAnimal = new System.Windows.Forms.Label();
            this.labelRasa = new System.Windows.Forms.Label();
            this.groupBoxAnimal = new System.Windows.Forms.GroupBox();
            this.groupBoxObiectDeIngrijire = new System.Windows.Forms.GroupBox();
            this.groupBoxHrana = new System.Windows.Forms.GroupBox();
            this.groupBoxJucarii = new System.Windows.Forms.GroupBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.labelCategorieObiectDeIngrijire = new System.Windows.Forms.Label();
            this.labelDenumireObiectDeIngrijire = new System.Windows.Forms.Label();
            this.labelCategorieHrana = new System.Windows.Forms.Label();
            this.labelDenumireHrana = new System.Windows.Forms.Label();
            this.labelDenumireJucarie = new System.Windows.Forms.Label();
            this.textBoxIdDeSters = new System.Windows.Forms.TextBox();
            this.labelIdDeSters = new System.Windows.Forms.Label();
            this.buttonStegere = new System.Windows.Forms.Button();
            this.groupBoxAdaugare.SuspendLayout();
            this.groupBoxOptiuni.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxStergere.SuspendLayout();
            this.groupBoxAnimal.SuspendLayout();
            this.groupBoxObiectDeIngrijire.SuspendLayout();
            this.groupBoxHrana.SuspendLayout();
            this.groupBoxJucarii.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 16;
            this.listBoxMenu.Items.AddRange(new object[] {
            "Utilizator",
            "Administrator",
            "Iesire"});
            this.listBoxMenu.Location = new System.Drawing.Point(6, 21);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(120, 84);
            this.listBoxMenu.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(156, 21);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(200, 84);
            this.listBox.TabIndex = 1;
            // 
            // groupBoxAdaugare
            // 
            this.groupBoxAdaugare.Controls.Add(this.buttonAdauga);
            this.groupBoxAdaugare.Controls.Add(this.groupBoxJucarii);
            this.groupBoxAdaugare.Controls.Add(this.groupBoxHrana);
            this.groupBoxAdaugare.Controls.Add(this.groupBoxObiectDeIngrijire);
            this.groupBoxAdaugare.Controls.Add(this.groupBoxAnimal);
            this.groupBoxAdaugare.Controls.Add(this.labelPret);
            this.groupBoxAdaugare.Controls.Add(this.labelId);
            this.groupBoxAdaugare.Controls.Add(this.labelTip);
            this.groupBoxAdaugare.Controls.Add(this.comboBox1);
            this.groupBoxAdaugare.Controls.Add(this.textBox3);
            this.groupBoxAdaugare.Controls.Add(this.textBox2);
            this.groupBoxAdaugare.Location = new System.Drawing.Point(400, 30);
            this.groupBoxAdaugare.Name = "groupBoxAdaugare";
            this.groupBoxAdaugare.Size = new System.Drawing.Size(866, 220);
            this.groupBoxAdaugare.TabIndex = 2;
            this.groupBoxAdaugare.TabStop = false;
            this.groupBoxAdaugare.Text = "Adaugare";
            // 
            // groupBoxOptiuni
            // 
            this.groupBoxOptiuni.Controls.Add(this.listBoxMenu);
            this.groupBoxOptiuni.Controls.Add(this.listBox);
            this.groupBoxOptiuni.Location = new System.Drawing.Point(21, 30);
            this.groupBoxOptiuni.Name = "groupBoxOptiuni";
            this.groupBoxOptiuni.Size = new System.Drawing.Size(373, 124);
            this.groupBoxOptiuni.TabIndex = 3;
            this.groupBoxOptiuni.TabStop = false;
            this.groupBoxOptiuni.Text = "Optiuni";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.buttonCumpara);
            this.groupBoxUser.Controls.Add(this.textBoxCumparare);
            this.groupBoxUser.Location = new System.Drawing.Point(21, 182);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(373, 122);
            this.groupBoxUser.TabIndex = 4;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Cumparare";
            // 
            // richTextBoxAfisare
            // 
            this.richTextBoxAfisare.Location = new System.Drawing.Point(21, 310);
            this.richTextBoxAfisare.Name = "richTextBoxAfisare";
            this.richTextBoxAfisare.Size = new System.Drawing.Size(1245, 204);
            this.richTextBoxAfisare.TabIndex = 5;
            this.richTextBoxAfisare.Text = "";
            // 
            // textBoxCumparare
            // 
            this.textBoxCumparare.Location = new System.Drawing.Point(6, 39);
            this.textBoxCumparare.Multiline = true;
            this.textBoxCumparare.Name = "textBoxCumparare";
            this.textBoxCumparare.Size = new System.Drawing.Size(216, 27);
            this.textBoxCumparare.TabIndex = 0;
            // 
            // buttonCumpara
            // 
            this.buttonCumpara.Location = new System.Drawing.Point(268, 39);
            this.buttonCumpara.Name = "buttonCumpara";
            this.buttonCumpara.Size = new System.Drawing.Size(75, 23);
            this.buttonCumpara.TabIndex = 1;
            this.buttonCumpara.Text = "Cumpara";
            this.buttonCumpara.UseVisualStyleBackColor = true;
            // 
            // groupBoxStergere
            // 
            this.groupBoxStergere.Controls.Add(this.buttonStegere);
            this.groupBoxStergere.Controls.Add(this.labelIdDeSters);
            this.groupBoxStergere.Controls.Add(this.textBoxIdDeSters);
            this.groupBoxStergere.Location = new System.Drawing.Point(400, 256);
            this.groupBoxStergere.Name = "groupBoxStergere";
            this.groupBoxStergere.Size = new System.Drawing.Size(866, 48);
            this.groupBoxStergere.TabIndex = 6;
            this.groupBoxStergere.TabStop = false;
            this.groupBoxStergere.Text = "Stergere";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(13, 26);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(28, 17);
            this.labelTip.TabIndex = 3;
            this.labelTip.Text = "Tip";
            this.labelTip.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 76);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 17);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "Id";
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(13, 125);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(34, 17);
            this.labelPret.TabIndex = 5;
            this.labelPret.Text = "Pret";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 22);
            this.textBox4.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(0, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(124, 24);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(0, 145);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(124, 24);
            this.comboBox3.TabIndex = 9;
            // 
            // labelVarstaAnimal
            // 
            this.labelVarstaAnimal.AutoSize = true;
            this.labelVarstaAnimal.Location = new System.Drawing.Point(6, 20);
            this.labelVarstaAnimal.Name = "labelVarstaAnimal";
            this.labelVarstaAnimal.Size = new System.Drawing.Size(95, 17);
            this.labelVarstaAnimal.TabIndex = 10;
            this.labelVarstaAnimal.Text = "Varsta Animal";
            // 
            // labelCategorieAnimal
            // 
            this.labelCategorieAnimal.AutoSize = true;
            this.labelCategorieAnimal.Location = new System.Drawing.Point(6, 65);
            this.labelCategorieAnimal.Name = "labelCategorieAnimal";
            this.labelCategorieAnimal.Size = new System.Drawing.Size(69, 17);
            this.labelCategorieAnimal.TabIndex = 11;
            this.labelCategorieAnimal.Text = "Categorie";
            // 
            // labelRasa
            // 
            this.labelRasa.AutoSize = true;
            this.labelRasa.Location = new System.Drawing.Point(6, 124);
            this.labelRasa.Name = "labelRasa";
            this.labelRasa.Size = new System.Drawing.Size(41, 17);
            this.labelRasa.TabIndex = 12;
            this.labelRasa.Text = "Rasa";
            // 
            // groupBoxAnimal
            // 
            this.groupBoxAnimal.Controls.Add(this.textBox4);
            this.groupBoxAnimal.Controls.Add(this.comboBox3);
            this.groupBoxAnimal.Controls.Add(this.labelRasa);
            this.groupBoxAnimal.Controls.Add(this.labelVarstaAnimal);
            this.groupBoxAnimal.Controls.Add(this.labelCategorieAnimal);
            this.groupBoxAnimal.Controls.Add(this.comboBox2);
            this.groupBoxAnimal.Location = new System.Drawing.Point(132, 21);
            this.groupBoxAnimal.Name = "groupBoxAnimal";
            this.groupBoxAnimal.Size = new System.Drawing.Size(145, 175);
            this.groupBoxAnimal.TabIndex = 13;
            this.groupBoxAnimal.TabStop = false;
            this.groupBoxAnimal.Text = "Animal";
            // 
            // groupBoxObiectDeIngrijire
            // 
            this.groupBoxObiectDeIngrijire.Controls.Add(this.labelDenumireObiectDeIngrijire);
            this.groupBoxObiectDeIngrijire.Controls.Add(this.labelCategorieObiectDeIngrijire);
            this.groupBoxObiectDeIngrijire.Controls.Add(this.textBox5);
            this.groupBoxObiectDeIngrijire.Controls.Add(this.comboBox4);
            this.groupBoxObiectDeIngrijire.Location = new System.Drawing.Point(294, 21);
            this.groupBoxObiectDeIngrijire.Name = "groupBoxObiectDeIngrijire";
            this.groupBoxObiectDeIngrijire.Size = new System.Drawing.Size(151, 175);
            this.groupBoxObiectDeIngrijire.TabIndex = 14;
            this.groupBoxObiectDeIngrijire.TabStop = false;
            this.groupBoxObiectDeIngrijire.Text = "Obiect De Ingrijire";
            // 
            // groupBoxHrana
            // 
            this.groupBoxHrana.Controls.Add(this.labelDenumireHrana);
            this.groupBoxHrana.Controls.Add(this.labelCategorieHrana);
            this.groupBoxHrana.Controls.Add(this.textBox6);
            this.groupBoxHrana.Controls.Add(this.comboBox5);
            this.groupBoxHrana.Location = new System.Drawing.Point(464, 26);
            this.groupBoxHrana.Name = "groupBoxHrana";
            this.groupBoxHrana.Size = new System.Drawing.Size(133, 170);
            this.groupBoxHrana.TabIndex = 15;
            this.groupBoxHrana.TabStop = false;
            this.groupBoxHrana.Text = "Hrana";
            // 
            // groupBoxJucarii
            // 
            this.groupBoxJucarii.Controls.Add(this.labelDenumireJucarie);
            this.groupBoxJucarii.Controls.Add(this.textBox7);
            this.groupBoxJucarii.Location = new System.Drawing.Point(619, 26);
            this.groupBoxJucarii.Name = "groupBoxJucarii";
            this.groupBoxJucarii.Size = new System.Drawing.Size(136, 170);
            this.groupBoxJucarii.TabIndex = 16;
            this.groupBoxJucarii.TabStop = false;
            this.groupBoxJucarii.Text = "Jucarie";
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(770, 167);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(75, 23);
            this.buttonAdauga.TabIndex = 17;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(10, 52);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(10, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 1;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(6, 47);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(76, 24);
            this.comboBox5.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 114);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 96);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 0;
            // 
            // labelCategorieObiectDeIngrijire
            // 
            this.labelCategorieObiectDeIngrijire.AutoSize = true;
            this.labelCategorieObiectDeIngrijire.Location = new System.Drawing.Point(7, 28);
            this.labelCategorieObiectDeIngrijire.Name = "labelCategorieObiectDeIngrijire";
            this.labelCategorieObiectDeIngrijire.Size = new System.Drawing.Size(69, 17);
            this.labelCategorieObiectDeIngrijire.TabIndex = 2;
            this.labelCategorieObiectDeIngrijire.Text = "Categorie";
            // 
            // labelDenumireObiectDeIngrijire
            // 
            this.labelDenumireObiectDeIngrijire.AutoSize = true;
            this.labelDenumireObiectDeIngrijire.Location = new System.Drawing.Point(7, 93);
            this.labelDenumireObiectDeIngrijire.Name = "labelDenumireObiectDeIngrijire";
            this.labelDenumireObiectDeIngrijire.Size = new System.Drawing.Size(69, 17);
            this.labelDenumireObiectDeIngrijire.TabIndex = 3;
            this.labelDenumireObiectDeIngrijire.Text = "Denumire";
            this.labelDenumireObiectDeIngrijire.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelCategorieHrana
            // 
            this.labelCategorieHrana.AutoSize = true;
            this.labelCategorieHrana.Location = new System.Drawing.Point(3, 23);
            this.labelCategorieHrana.Name = "labelCategorieHrana";
            this.labelCategorieHrana.Size = new System.Drawing.Size(69, 17);
            this.labelCategorieHrana.TabIndex = 2;
            this.labelCategorieHrana.Text = "Categorie";
            // 
            // labelDenumireHrana
            // 
            this.labelDenumireHrana.AutoSize = true;
            this.labelDenumireHrana.Location = new System.Drawing.Point(6, 94);
            this.labelDenumireHrana.Name = "labelDenumireHrana";
            this.labelDenumireHrana.Size = new System.Drawing.Size(69, 17);
            this.labelDenumireHrana.TabIndex = 3;
            this.labelDenumireHrana.Text = "Denumire";
            // 
            // labelDenumireJucarie
            // 
            this.labelDenumireJucarie.AutoSize = true;
            this.labelDenumireJucarie.Location = new System.Drawing.Point(16, 72);
            this.labelDenumireJucarie.Name = "labelDenumireJucarie";
            this.labelDenumireJucarie.Size = new System.Drawing.Size(69, 17);
            this.labelDenumireJucarie.TabIndex = 1;
            this.labelDenumireJucarie.Text = "Denumire";
            // 
            // textBoxIdDeSters
            // 
            this.textBoxIdDeSters.Location = new System.Drawing.Point(151, 20);
            this.textBoxIdDeSters.Name = "textBoxIdDeSters";
            this.textBoxIdDeSters.Size = new System.Drawing.Size(162, 22);
            this.textBoxIdDeSters.TabIndex = 0;
            // 
            // labelIdDeSters
            // 
            this.labelIdDeSters.AutoSize = true;
            this.labelIdDeSters.Location = new System.Drawing.Point(126, 23);
            this.labelIdDeSters.Name = "labelIdDeSters";
            this.labelIdDeSters.Size = new System.Drawing.Size(19, 17);
            this.labelIdDeSters.TabIndex = 1;
            this.labelIdDeSters.Text = "Id";
            // 
            // buttonStegere
            // 
            this.buttonStegere.Location = new System.Drawing.Point(554, 20);
            this.buttonStegere.Name = "buttonStegere";
            this.buttonStegere.Size = new System.Drawing.Size(75, 23);
            this.buttonStegere.TabIndex = 2;
            this.buttonStegere.Text = "Stergere";
            this.buttonStegere.UseVisualStyleBackColor = true;
            // 
            // FormPetShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 562);
            this.Controls.Add(this.groupBoxStergere);
            this.Controls.Add(this.richTextBoxAfisare);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.groupBoxOptiuni);
            this.Controls.Add(this.groupBoxAdaugare);
            this.Name = "FormPetShop";
            this.Text = "PetShop";
            this.groupBoxAdaugare.ResumeLayout(false);
            this.groupBoxAdaugare.PerformLayout();
            this.groupBoxOptiuni.ResumeLayout(false);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxStergere.ResumeLayout(false);
            this.groupBoxStergere.PerformLayout();
            this.groupBoxAnimal.ResumeLayout(false);
            this.groupBoxAnimal.PerformLayout();
            this.groupBoxObiectDeIngrijire.ResumeLayout(false);
            this.groupBoxObiectDeIngrijire.PerformLayout();
            this.groupBoxHrana.ResumeLayout(false);
            this.groupBoxHrana.PerformLayout();
            this.groupBoxJucarii.ResumeLayout(false);
            this.groupBoxJucarii.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox groupBoxAdaugare;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxOptiuni;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Button buttonCumpara;
        private System.Windows.Forms.TextBox textBoxCumparare;
        private System.Windows.Forms.RichTextBox richTextBoxAfisare;
        private System.Windows.Forms.GroupBox groupBoxStergere;
        private System.Windows.Forms.Label labelCategorieAnimal;
        private System.Windows.Forms.Label labelVarstaAnimal;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.GroupBox groupBoxJucarii;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.GroupBox groupBoxHrana;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.GroupBox groupBoxObiectDeIngrijire;
        private System.Windows.Forms.Label labelDenumireObiectDeIngrijire;
        private System.Windows.Forms.Label labelCategorieObiectDeIngrijire;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.GroupBox groupBoxAnimal;
        private System.Windows.Forms.Label labelRasa;
        private System.Windows.Forms.Label labelDenumireHrana;
        private System.Windows.Forms.Label labelCategorieHrana;
        private System.Windows.Forms.Label labelDenumireJucarie;
        private System.Windows.Forms.Button buttonStegere;
        private System.Windows.Forms.Label labelIdDeSters;
        private System.Windows.Forms.TextBox textBoxIdDeSters;
    }
}

