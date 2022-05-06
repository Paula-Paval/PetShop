
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
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.groupBoxJucarii = new System.Windows.Forms.GroupBox();
            this.labelDenumireJucarie = new System.Windows.Forms.Label();
            this.textBoxDenumireJucarie = new System.Windows.Forms.TextBox();
            this.groupBoxHrana = new System.Windows.Forms.GroupBox();
            this.labelDenumireHrana = new System.Windows.Forms.Label();
            this.labelCategorieHrana = new System.Windows.Forms.Label();
            this.textBoxDenumireHrana = new System.Windows.Forms.TextBox();
            this.comboBoxCategorieHrana = new System.Windows.Forms.ComboBox();
            this.groupBoxObiectDeIngrijire = new System.Windows.Forms.GroupBox();
            this.labelDenumireObiectDeIngrijire = new System.Windows.Forms.Label();
            this.labelCategorieObiectDeIngrijire = new System.Windows.Forms.Label();
            this.textBoxDenumireObiect = new System.Windows.Forms.TextBox();
            this.comboBoxCategorieIngrijire = new System.Windows.Forms.ComboBox();
            this.groupBoxAnimal = new System.Windows.Forms.GroupBox();
            this.textBoxVarsta = new System.Windows.Forms.TextBox();
            this.labelVarstaAnimal = new System.Windows.Forms.Label();
            this.labelCategorieAnimal = new System.Windows.Forms.Label();
            this.comboBoxSpecie = new System.Windows.Forms.ComboBox();
            this.labelPret = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.comboBoxCategorii = new System.Windows.Forms.ComboBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.groupBoxOptiuni = new System.Windows.Forms.GroupBox();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.buttonCumpara = new System.Windows.Forms.Button();
            this.textBoxCumparare = new System.Windows.Forms.TextBox();
            this.richTextBoxAfisare = new System.Windows.Forms.RichTextBox();
            this.groupBoxStergere = new System.Windows.Forms.GroupBox();
            this.buttonStegere = new System.Windows.Forms.Button();
            this.labelIdDeSters = new System.Windows.Forms.Label();
            this.textBoxIdDeSters = new System.Windows.Forms.TextBox();
            this.groupBoxAdaugare.SuspendLayout();
            this.groupBoxJucarii.SuspendLayout();
            this.groupBoxHrana.SuspendLayout();
            this.groupBoxObiectDeIngrijire.SuspendLayout();
            this.groupBoxAnimal.SuspendLayout();
            this.groupBoxOptiuni.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxStergere.SuspendLayout();
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
            this.listBoxMenu.Size = new System.Drawing.Size(89, 84);
            this.listBoxMenu.TabIndex = 0;
            this.listBoxMenu.SelectedIndexChanged += new System.EventHandler(this.listBoxMenu_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(101, 21);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(266, 84);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
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
            this.groupBoxAdaugare.Controls.Add(this.comboBoxCategorii);
            this.groupBoxAdaugare.Controls.Add(this.textBoxPret);
            this.groupBoxAdaugare.Controls.Add(this.textBoxId);
            this.groupBoxAdaugare.Location = new System.Drawing.Point(400, 30);
            this.groupBoxAdaugare.Name = "groupBoxAdaugare";
            this.groupBoxAdaugare.Size = new System.Drawing.Size(866, 220);
            this.groupBoxAdaugare.TabIndex = 2;
            this.groupBoxAdaugare.TabStop = false;
            this.groupBoxAdaugare.Text = "Adaugare";
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(723, 167);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(75, 34);
            this.buttonAdauga.TabIndex = 17;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // groupBoxJucarii
            // 
            this.groupBoxJucarii.Controls.Add(this.labelDenumireJucarie);
            this.groupBoxJucarii.Controls.Add(this.textBoxDenumireJucarie);
            this.groupBoxJucarii.Location = new System.Drawing.Point(660, 26);
            this.groupBoxJucarii.Name = "groupBoxJucarii";
            this.groupBoxJucarii.Size = new System.Drawing.Size(186, 129);
            this.groupBoxJucarii.TabIndex = 16;
            this.groupBoxJucarii.TabStop = false;
            this.groupBoxJucarii.Text = "Jucarie";
            // 
            // labelDenumireJucarie
            // 
            this.labelDenumireJucarie.AutoSize = true;
            this.labelDenumireJucarie.Location = new System.Drawing.Point(24, 23);
            this.labelDenumireJucarie.Name = "labelDenumireJucarie";
            this.labelDenumireJucarie.Size = new System.Drawing.Size(69, 17);
            this.labelDenumireJucarie.TabIndex = 1;
            this.labelDenumireJucarie.Text = "Denumire";
            // 
            // textBoxDenumireJucarie
            // 
            this.textBoxDenumireJucarie.Location = new System.Drawing.Point(27, 50);
            this.textBoxDenumireJucarie.Name = "textBoxDenumireJucarie";
            this.textBoxDenumireJucarie.Size = new System.Drawing.Size(133, 22);
            this.textBoxDenumireJucarie.TabIndex = 0;
            // 
            // groupBoxHrana
            // 
            this.groupBoxHrana.Controls.Add(this.labelDenumireHrana);
            this.groupBoxHrana.Controls.Add(this.labelCategorieHrana);
            this.groupBoxHrana.Controls.Add(this.textBoxDenumireHrana);
            this.groupBoxHrana.Controls.Add(this.comboBoxCategorieHrana);
            this.groupBoxHrana.Location = new System.Drawing.Point(464, 26);
            this.groupBoxHrana.Name = "groupBoxHrana";
            this.groupBoxHrana.Size = new System.Drawing.Size(174, 170);
            this.groupBoxHrana.TabIndex = 15;
            this.groupBoxHrana.TabStop = false;
            this.groupBoxHrana.Text = "Hrana";
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
            // labelCategorieHrana
            // 
            this.labelCategorieHrana.AutoSize = true;
            this.labelCategorieHrana.Location = new System.Drawing.Point(3, 23);
            this.labelCategorieHrana.Name = "labelCategorieHrana";
            this.labelCategorieHrana.Size = new System.Drawing.Size(69, 17);
            this.labelCategorieHrana.TabIndex = 2;
            this.labelCategorieHrana.Text = "Categorie";
            // 
            // textBoxDenumireHrana
            // 
            this.textBoxDenumireHrana.Location = new System.Drawing.Point(6, 114);
            this.textBoxDenumireHrana.Name = "textBoxDenumireHrana";
            this.textBoxDenumireHrana.Size = new System.Drawing.Size(158, 22);
            this.textBoxDenumireHrana.TabIndex = 1;
            // 
            // comboBoxCategorieHrana
            // 
            this.comboBoxCategorieHrana.FormattingEnabled = true;
            this.comboBoxCategorieHrana.Location = new System.Drawing.Point(6, 47);
            this.comboBoxCategorieHrana.Name = "comboBoxCategorieHrana";
            this.comboBoxCategorieHrana.Size = new System.Drawing.Size(158, 24);
            this.comboBoxCategorieHrana.TabIndex = 0;
            // 
            // groupBoxObiectDeIngrijire
            // 
            this.groupBoxObiectDeIngrijire.Controls.Add(this.labelDenumireObiectDeIngrijire);
            this.groupBoxObiectDeIngrijire.Controls.Add(this.labelCategorieObiectDeIngrijire);
            this.groupBoxObiectDeIngrijire.Controls.Add(this.textBoxDenumireObiect);
            this.groupBoxObiectDeIngrijire.Controls.Add(this.comboBoxCategorieIngrijire);
            this.groupBoxObiectDeIngrijire.Location = new System.Drawing.Point(294, 21);
            this.groupBoxObiectDeIngrijire.Name = "groupBoxObiectDeIngrijire";
            this.groupBoxObiectDeIngrijire.Size = new System.Drawing.Size(151, 175);
            this.groupBoxObiectDeIngrijire.TabIndex = 14;
            this.groupBoxObiectDeIngrijire.TabStop = false;
            this.groupBoxObiectDeIngrijire.Text = "Obiect De Ingrijire";
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
            // labelCategorieObiectDeIngrijire
            // 
            this.labelCategorieObiectDeIngrijire.AutoSize = true;
            this.labelCategorieObiectDeIngrijire.Location = new System.Drawing.Point(7, 28);
            this.labelCategorieObiectDeIngrijire.Name = "labelCategorieObiectDeIngrijire";
            this.labelCategorieObiectDeIngrijire.Size = new System.Drawing.Size(69, 17);
            this.labelCategorieObiectDeIngrijire.TabIndex = 2;
            this.labelCategorieObiectDeIngrijire.Text = "Categorie";
            // 
            // textBoxDenumireObiect
            // 
            this.textBoxDenumireObiect.Location = new System.Drawing.Point(10, 119);
            this.textBoxDenumireObiect.Name = "textBoxDenumireObiect";
            this.textBoxDenumireObiect.Size = new System.Drawing.Size(135, 22);
            this.textBoxDenumireObiect.TabIndex = 1;
            this.textBoxDenumireObiect.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // comboBoxCategorieIngrijire
            // 
            this.comboBoxCategorieIngrijire.FormattingEnabled = true;
            this.comboBoxCategorieIngrijire.Location = new System.Drawing.Point(6, 52);
            this.comboBoxCategorieIngrijire.Name = "comboBoxCategorieIngrijire";
            this.comboBoxCategorieIngrijire.Size = new System.Drawing.Size(139, 24);
            this.comboBoxCategorieIngrijire.TabIndex = 0;
            // 
            // groupBoxAnimal
            // 
            this.groupBoxAnimal.Controls.Add(this.textBoxVarsta);
            this.groupBoxAnimal.Controls.Add(this.labelVarstaAnimal);
            this.groupBoxAnimal.Controls.Add(this.labelCategorieAnimal);
            this.groupBoxAnimal.Controls.Add(this.comboBoxSpecie);
            this.groupBoxAnimal.Location = new System.Drawing.Point(132, 21);
            this.groupBoxAnimal.Name = "groupBoxAnimal";
            this.groupBoxAnimal.Size = new System.Drawing.Size(145, 175);
            this.groupBoxAnimal.TabIndex = 13;
            this.groupBoxAnimal.TabStop = false;
            this.groupBoxAnimal.Text = "Animal";
            // 
            // textBoxVarsta
            // 
            this.textBoxVarsta.Location = new System.Drawing.Point(6, 52);
            this.textBoxVarsta.Name = "textBoxVarsta";
            this.textBoxVarsta.Size = new System.Drawing.Size(124, 22);
            this.textBoxVarsta.TabIndex = 6;
            // 
            // labelVarstaAnimal
            // 
            this.labelVarstaAnimal.AutoSize = true;
            this.labelVarstaAnimal.Location = new System.Drawing.Point(6, 28);
            this.labelVarstaAnimal.Name = "labelVarstaAnimal";
            this.labelVarstaAnimal.Size = new System.Drawing.Size(95, 17);
            this.labelVarstaAnimal.TabIndex = 10;
            this.labelVarstaAnimal.Text = "Varsta Animal";
            // 
            // labelCategorieAnimal
            // 
            this.labelCategorieAnimal.AutoSize = true;
            this.labelCategorieAnimal.Location = new System.Drawing.Point(16, 93);
            this.labelCategorieAnimal.Name = "labelCategorieAnimal";
            this.labelCategorieAnimal.Size = new System.Drawing.Size(69, 17);
            this.labelCategorieAnimal.TabIndex = 11;
            this.labelCategorieAnimal.Text = "Categorie";
            // 
            // comboBoxSpecie
            // 
            this.comboBoxSpecie.FormattingEnabled = true;
            this.comboBoxSpecie.Location = new System.Drawing.Point(9, 117);
            this.comboBoxSpecie.Name = "comboBoxSpecie";
            this.comboBoxSpecie.Size = new System.Drawing.Size(124, 24);
            this.comboBoxSpecie.TabIndex = 8;
            this.comboBoxSpecie.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(13, 138);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(34, 17);
            this.labelPret.TabIndex = 5;
            this.labelPret.Text = "Pret";
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
            // comboBoxCategorii
            // 
            this.comboBoxCategorii.FormattingEnabled = true;
            this.comboBoxCategorii.Location = new System.Drawing.Point(16, 46);
            this.comboBoxCategorii.Name = "comboBoxCategorii";
            this.comboBoxCategorii.Size = new System.Drawing.Size(100, 24);
            this.comboBoxCategorii.TabIndex = 2;
            this.comboBoxCategorii.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategorii_SelectedIndexChanged);
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(16, 167);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(100, 22);
            this.textBoxPret.TabIndex = 1;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(16, 102);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 0;
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
            // buttonCumpara
            // 
            this.buttonCumpara.Location = new System.Drawing.Point(265, 39);
            this.buttonCumpara.Name = "buttonCumpara";
            this.buttonCumpara.Size = new System.Drawing.Size(75, 29);
            this.buttonCumpara.TabIndex = 1;
            this.buttonCumpara.Text = "Cumpara";
            this.buttonCumpara.UseVisualStyleBackColor = true;
            // 
            // textBoxCumparare
            // 
            this.textBoxCumparare.Location = new System.Drawing.Point(6, 39);
            this.textBoxCumparare.Multiline = true;
            this.textBoxCumparare.Name = "textBoxCumparare";
            this.textBoxCumparare.Size = new System.Drawing.Size(216, 27);
            this.textBoxCumparare.TabIndex = 0;
            // 
            // richTextBoxAfisare
            // 
            this.richTextBoxAfisare.Location = new System.Drawing.Point(21, 310);
            this.richTextBoxAfisare.Name = "richTextBoxAfisare";
            this.richTextBoxAfisare.Size = new System.Drawing.Size(1245, 204);
            this.richTextBoxAfisare.TabIndex = 5;
            this.richTextBoxAfisare.Text = "";
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
            // buttonStegere
            // 
            this.buttonStegere.Location = new System.Drawing.Point(553, 11);
            this.buttonStegere.Name = "buttonStegere";
            this.buttonStegere.Size = new System.Drawing.Size(75, 31);
            this.buttonStegere.TabIndex = 2;
            this.buttonStegere.Text = "Stergere";
            this.buttonStegere.UseVisualStyleBackColor = true;
            // 
            // labelIdDeSters
            // 
            this.labelIdDeSters.AutoSize = true;
            this.labelIdDeSters.Location = new System.Drawing.Point(129, 18);
            this.labelIdDeSters.Name = "labelIdDeSters";
            this.labelIdDeSters.Size = new System.Drawing.Size(19, 17);
            this.labelIdDeSters.TabIndex = 1;
            this.labelIdDeSters.Text = "Id";
            // 
            // textBoxIdDeSters
            // 
            this.textBoxIdDeSters.Location = new System.Drawing.Point(165, 15);
            this.textBoxIdDeSters.Name = "textBoxIdDeSters";
            this.textBoxIdDeSters.Size = new System.Drawing.Size(162, 22);
            this.textBoxIdDeSters.TabIndex = 0;
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
            this.groupBoxJucarii.ResumeLayout(false);
            this.groupBoxJucarii.PerformLayout();
            this.groupBoxHrana.ResumeLayout(false);
            this.groupBoxHrana.PerformLayout();
            this.groupBoxObiectDeIngrijire.ResumeLayout(false);
            this.groupBoxObiectDeIngrijire.PerformLayout();
            this.groupBoxAnimal.ResumeLayout(false);
            this.groupBoxAnimal.PerformLayout();
            this.groupBoxOptiuni.ResumeLayout(false);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxStergere.ResumeLayout(false);
            this.groupBoxStergere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox groupBoxAdaugare;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.ComboBox comboBoxCategorii;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.GroupBox groupBoxOptiuni;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Button buttonCumpara;
        private System.Windows.Forms.TextBox textBoxCumparare;
        private System.Windows.Forms.RichTextBox richTextBoxAfisare;
        private System.Windows.Forms.GroupBox groupBoxStergere;
        private System.Windows.Forms.Label labelCategorieAnimal;
        private System.Windows.Forms.Label labelVarstaAnimal;
        private System.Windows.Forms.ComboBox comboBoxSpecie;
        private System.Windows.Forms.TextBox textBoxVarsta;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.GroupBox groupBoxJucarii;
        private System.Windows.Forms.TextBox textBoxDenumireJucarie;
        private System.Windows.Forms.GroupBox groupBoxHrana;
        private System.Windows.Forms.TextBox textBoxDenumireHrana;
        private System.Windows.Forms.ComboBox comboBoxCategorieHrana;
        private System.Windows.Forms.GroupBox groupBoxObiectDeIngrijire;
        private System.Windows.Forms.Label labelDenumireObiectDeIngrijire;
        private System.Windows.Forms.Label labelCategorieObiectDeIngrijire;
        private System.Windows.Forms.TextBox textBoxDenumireObiect;
        private System.Windows.Forms.ComboBox comboBoxCategorieIngrijire;
        private System.Windows.Forms.GroupBox groupBoxAnimal;
        private System.Windows.Forms.Label labelDenumireHrana;
        private System.Windows.Forms.Label labelCategorieHrana;
        private System.Windows.Forms.Label labelDenumireJucarie;
        private System.Windows.Forms.Button buttonStegere;
        private System.Windows.Forms.Label labelIdDeSters;
        private System.Windows.Forms.TextBox textBoxIdDeSters;
    }
}

