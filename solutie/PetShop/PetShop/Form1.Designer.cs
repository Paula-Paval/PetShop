
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPetShop));
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBoxAdaugare = new System.Windows.Forms.GroupBox();
            this.groupBoxJucarii = new System.Windows.Forms.GroupBox();
            this.labelDenumireJucarie = new System.Windows.Forms.Label();
            this.textBoxDenumireJucarie = new System.Windows.Forms.TextBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
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
            this.denumireProdusCumparat = new System.Windows.Forms.Label();
            this.labelTipCumparare = new System.Windows.Forms.Label();
            this.comboBoxTipCumparare = new System.Windows.Forms.ComboBox();
            this.buttonCumpara = new System.Windows.Forms.Button();
            this.textBoxCumparare = new System.Windows.Forms.TextBox();
            this.richTextBoxAfisare = new System.Windows.Forms.RichTextBox();
            this.groupBoxStergere = new System.Windows.Forms.GroupBox();
            this.labelTipStergere = new System.Windows.Forms.Label();
            this.comboBoxTipStergere = new System.Windows.Forms.ComboBox();
            this.buttonStegere = new System.Windows.Forms.Button();
            this.labelIdDeSters = new System.Windows.Forms.Label();
            this.textBoxIdDeSters = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonHelpUtilizator = new System.Windows.Forms.Button();
            this.buttonHelpProgramator = new System.Windows.Forms.Button();
            this.groupBoxAdaugare.SuspendLayout();
            this.groupBoxJucarii.SuspendLayout();
            this.groupBoxHrana.SuspendLayout();
            this.groupBoxObiectDeIngrijire.SuspendLayout();
            this.groupBoxAnimal.SuspendLayout();
            this.groupBoxOptiuni.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxStergere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.listBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(101, 21);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(232, 84);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // groupBoxAdaugare
            // 
            this.groupBoxAdaugare.Controls.Add(this.groupBoxJucarii);
            this.groupBoxAdaugare.Controls.Add(this.buttonAdauga);
            this.groupBoxAdaugare.Controls.Add(this.groupBoxHrana);
            this.groupBoxAdaugare.Controls.Add(this.groupBoxObiectDeIngrijire);
            this.groupBoxAdaugare.Controls.Add(this.groupBoxAnimal);
            this.groupBoxAdaugare.Controls.Add(this.labelPret);
            this.groupBoxAdaugare.Controls.Add(this.labelId);
            this.groupBoxAdaugare.Controls.Add(this.labelTip);
            this.groupBoxAdaugare.Controls.Add(this.comboBoxCategorii);
            this.groupBoxAdaugare.Controls.Add(this.textBoxPret);
            this.groupBoxAdaugare.Controls.Add(this.textBoxId);
            this.groupBoxAdaugare.Location = new System.Drawing.Point(137, 155);
            this.groupBoxAdaugare.Name = "groupBoxAdaugare";
            this.groupBoxAdaugare.Size = new System.Drawing.Size(1149, 256);
            this.groupBoxAdaugare.TabIndex = 2;
            this.groupBoxAdaugare.TabStop = false;
            this.groupBoxAdaugare.Text = "Adaugare";
            // 
            // groupBoxJucarii
            // 
            this.groupBoxJucarii.Controls.Add(this.labelDenumireJucarie);
            this.groupBoxJucarii.Controls.Add(this.textBoxDenumireJucarie);
            this.groupBoxJucarii.Location = new System.Drawing.Point(861, 26);
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
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(861, 167);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(146, 56);
            this.buttonAdauga.TabIndex = 17;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // groupBoxHrana
            // 
            this.groupBoxHrana.Controls.Add(this.labelDenumireHrana);
            this.groupBoxHrana.Controls.Add(this.labelCategorieHrana);
            this.groupBoxHrana.Controls.Add(this.textBoxDenumireHrana);
            this.groupBoxHrana.Controls.Add(this.comboBoxCategorieHrana);
            this.groupBoxHrana.Location = new System.Drawing.Point(601, 21);
            this.groupBoxHrana.Name = "groupBoxHrana";
            this.groupBoxHrana.Size = new System.Drawing.Size(174, 175);
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
            this.groupBoxObiectDeIngrijire.Location = new System.Drawing.Point(378, 21);
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
            this.groupBoxAnimal.Location = new System.Drawing.Point(158, 21);
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
            this.groupBoxOptiuni.Location = new System.Drawing.Point(909, 12);
            this.groupBoxOptiuni.Name = "groupBoxOptiuni";
            this.groupBoxOptiuni.Size = new System.Drawing.Size(377, 137);
            this.groupBoxOptiuni.TabIndex = 3;
            this.groupBoxOptiuni.TabStop = false;
            this.groupBoxOptiuni.Text = "Optiuni";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.denumireProdusCumparat);
            this.groupBoxUser.Controls.Add(this.labelTipCumparare);
            this.groupBoxUser.Controls.Add(this.comboBoxTipCumparare);
            this.groupBoxUser.Controls.Add(this.buttonCumpara);
            this.groupBoxUser.Controls.Add(this.textBoxCumparare);
            this.groupBoxUser.Location = new System.Drawing.Point(137, 417);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(477, 122);
            this.groupBoxUser.TabIndex = 4;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Cumparare";
            // 
            // denumireProdusCumparat
            // 
            this.denumireProdusCumparat.AutoSize = true;
            this.denumireProdusCumparat.Location = new System.Drawing.Point(13, 69);
            this.denumireProdusCumparat.Name = "denumireProdusCumparat";
            this.denumireProdusCumparat.Size = new System.Drawing.Size(69, 17);
            this.denumireProdusCumparat.TabIndex = 6;
            this.denumireProdusCumparat.Text = "Denumire";
            // 
            // labelTipCumparare
            // 
            this.labelTipCumparare.AutoSize = true;
            this.labelTipCumparare.Location = new System.Drawing.Point(13, 31);
            this.labelTipCumparare.Name = "labelTipCumparare";
            this.labelTipCumparare.Size = new System.Drawing.Size(28, 17);
            this.labelTipCumparare.TabIndex = 5;
            this.labelTipCumparare.Text = "Tip";
            // 
            // comboBoxTipCumparare
            // 
            this.comboBoxTipCumparare.FormattingEnabled = true;
            this.comboBoxTipCumparare.Location = new System.Drawing.Point(97, 28);
            this.comboBoxTipCumparare.Name = "comboBoxTipCumparare";
            this.comboBoxTipCumparare.Size = new System.Drawing.Size(94, 24);
            this.comboBoxTipCumparare.TabIndex = 2;
            // 
            // buttonCumpara
            // 
            this.buttonCumpara.Location = new System.Drawing.Point(308, 36);
            this.buttonCumpara.Name = "buttonCumpara";
            this.buttonCumpara.Size = new System.Drawing.Size(154, 48);
            this.buttonCumpara.TabIndex = 1;
            this.buttonCumpara.Text = "Cumpara";
            this.buttonCumpara.UseVisualStyleBackColor = true;
            this.buttonCumpara.Click += new System.EventHandler(this.buttonCumpara_Click);
            // 
            // textBoxCumparare
            // 
            this.textBoxCumparare.Location = new System.Drawing.Point(97, 66);
            this.textBoxCumparare.Multiline = true;
            this.textBoxCumparare.Name = "textBoxCumparare";
            this.textBoxCumparare.Size = new System.Drawing.Size(191, 27);
            this.textBoxCumparare.TabIndex = 0;
            // 
            // richTextBoxAfisare
            // 
            this.richTextBoxAfisare.Location = new System.Drawing.Point(137, 547);
            this.richTextBoxAfisare.Name = "richTextBoxAfisare";
            this.richTextBoxAfisare.Size = new System.Drawing.Size(969, 182);
            this.richTextBoxAfisare.TabIndex = 5;
            this.richTextBoxAfisare.Text = "";
            // 
            // groupBoxStergere
            // 
            this.groupBoxStergere.Controls.Add(this.labelTipStergere);
            this.groupBoxStergere.Controls.Add(this.comboBoxTipStergere);
            this.groupBoxStergere.Controls.Add(this.buttonStegere);
            this.groupBoxStergere.Controls.Add(this.labelIdDeSters);
            this.groupBoxStergere.Controls.Add(this.textBoxIdDeSters);
            this.groupBoxStergere.Location = new System.Drawing.Point(633, 422);
            this.groupBoxStergere.Name = "groupBoxStergere";
            this.groupBoxStergere.Size = new System.Drawing.Size(653, 119);
            this.groupBoxStergere.TabIndex = 6;
            this.groupBoxStergere.TabStop = false;
            this.groupBoxStergere.Text = "Stergere";
            // 
            // labelTipStergere
            // 
            this.labelTipStergere.AutoSize = true;
            this.labelTipStergere.Location = new System.Drawing.Point(59, 23);
            this.labelTipStergere.Name = "labelTipStergere";
            this.labelTipStergere.Size = new System.Drawing.Size(28, 17);
            this.labelTipStergere.TabIndex = 4;
            this.labelTipStergere.Text = "Tip";
            // 
            // comboBoxTipStergere
            // 
            this.comboBoxTipStergere.FormattingEnabled = true;
            this.comboBoxTipStergere.Location = new System.Drawing.Point(121, 18);
            this.comboBoxTipStergere.Name = "comboBoxTipStergere";
            this.comboBoxTipStergere.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipStergere.TabIndex = 3;
            // 
            // buttonStegere
            // 
            this.buttonStegere.Location = new System.Drawing.Point(365, 29);
            this.buttonStegere.Name = "buttonStegere";
            this.buttonStegere.Size = new System.Drawing.Size(146, 50);
            this.buttonStegere.TabIndex = 2;
            this.buttonStegere.Text = "Stergere";
            this.buttonStegere.UseVisualStyleBackColor = true;
            this.buttonStegere.Click += new System.EventHandler(this.buttonStegere_Click);
            // 
            // labelIdDeSters
            // 
            this.labelIdDeSters.AutoSize = true;
            this.labelIdDeSters.Location = new System.Drawing.Point(68, 64);
            this.labelIdDeSters.Name = "labelIdDeSters";
            this.labelIdDeSters.Size = new System.Drawing.Size(19, 17);
            this.labelIdDeSters.TabIndex = 1;
            this.labelIdDeSters.Text = "Id";
            // 
            // textBoxIdDeSters
            // 
            this.textBoxIdDeSters.Location = new System.Drawing.Point(121, 59);
            this.textBoxIdDeSters.Name = "textBoxIdDeSters";
            this.textBoxIdDeSters.Size = new System.Drawing.Size(162, 22);
            this.textBoxIdDeSters.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.ImageLocation = "C:\\Users\\Admin\\Desktop\\Proiect IP\\PetShop\\solutie\\PetShop\\PetShop\\bin\\Debug\\PetSh" +
    "op.png";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 137);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHelpProgramator);
            this.groupBox1.Controls.Add(this.buttonAbout);
            this.groupBox1.Controls.Add(this.buttonHelpUtilizator);
            this.groupBox1.Location = new System.Drawing.Point(1112, 547);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 182);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(14, 126);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(146, 50);
            this.buttonAbout.TabIndex = 6;
            this.buttonAbout.Text = "Despre";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonHelpUtilizator
            // 
            this.buttonHelpUtilizator.Location = new System.Drawing.Point(14, 11);
            this.buttonHelpUtilizator.Name = "buttonHelpUtilizator";
            this.buttonHelpUtilizator.Size = new System.Drawing.Size(146, 50);
            this.buttonHelpUtilizator.TabIndex = 5;
            this.buttonHelpUtilizator.Text = "Help utilizator";
            this.buttonHelpUtilizator.UseVisualStyleBackColor = true;
            // 
            // buttonHelpProgramator
            // 
            this.buttonHelpProgramator.Location = new System.Drawing.Point(14, 69);
            this.buttonHelpProgramator.Name = "buttonHelpProgramator";
            this.buttonHelpProgramator.Size = new System.Drawing.Size(146, 50);
            this.buttonHelpProgramator.TabIndex = 7;
            this.buttonHelpProgramator.Text = "Help programator";
            this.buttonHelpProgramator.UseVisualStyleBackColor = true;
            // 
            // FormPetShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1425, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxStergere);
            this.Controls.Add(this.richTextBoxAfisare);
            this.Controls.Add(this.groupBoxAdaugare);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.groupBoxOptiuni);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelTipStergere;
        private System.Windows.Forms.ComboBox comboBoxTipStergere;
        private System.Windows.Forms.Label labelTipCumparare;
        private System.Windows.Forms.ComboBox comboBoxTipCumparare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHelpUtilizator;
        private System.Windows.Forms.Label denumireProdusCumparat;
        private System.Windows.Forms.Button buttonHelpProgramator;
    }
}

