﻿using Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using static View.Meniu;


namespace PetShop
{
    public partial class FormPetShop : Form
    {
        private IPresenter _presenter= new Presenter.Presenter();

        private List<MenuOption> _menuOptions;     

        public enum Categorii
        {
            animal,
            obiect,
            hrana,
            jucarie,

        }
        public enum Specii
        {
            caine,
            pisica,           

        }

        public enum CategorieObiecte
        {
            perie,
            cuscaTransport,
            bol,

        }

        public enum CategorieHrana
        {
            hranaUmedaCaini,
            hranaUscataCaini,
            hranaUmedaPisici,
            hranaUscataPisici,
        }



        public FormPetShop()
        {
            InitializeComponent();
            groupBoxUser.Enabled = false;
            groupBoxStergere.Enabled = false;
            groupBoxAdaugare.Enabled = false;
            comboBoxCategorii.DataSource = Enum.GetValues(typeof(Categorii));
            comboBoxCategorii.SelectedItem = Categorii.animal;
            comboBoxSpecie.DataSource= Enum.GetValues(typeof(Specii));
            comboBoxSpecie.SelectedItem = Specii.caine;
            comboBoxCategorieIngrijire.DataSource = Enum.GetValues(typeof(CategorieObiecte));
            comboBoxCategorieIngrijire.SelectedItem = CategorieObiecte.perie;
            comboBoxCategorieHrana.DataSource = Enum.GetValues(typeof(CategorieHrana));
            comboBoxCategorieHrana.SelectedItem = CategorieHrana.hranaUmedaCaini;
            comboBoxTipStergere.DataSource = Enum.GetValues(typeof(Categorii));
            comboBoxTipStergere.SelectedItem = Categorii.animal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch(listBoxMenu.SelectedItem.ToString())
            {
                case "Utilizator": Meniu.UserMenu(out _menuOptions);                   
                    break;
                case "Administrator":
                    Meniu.AdminMenu(out _menuOptions);
                    break;
                case "Iesire":
                    Environment.Exit(0);
                    break;                
            }
            listBox.Items.Clear();
            foreach (var item in _menuOptions)
            {
                listBox.Items.Add(item.Text);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(listBox.SelectedItem.ToString())
            {
                case "Introducerea unui produs":
                    groupBoxAdaugare.Enabled = true;
                    groupBoxObiectDeIngrijire.Enabled = false;
                    groupBoxHrana.Enabled = false;
                    groupBoxJucarii.Enabled = false;
                    groupBoxUser.Enabled = false;
                    groupBoxStergere.Enabled = false;
                   
                    break;
                case "Stegerea unui produs":
                    groupBoxStergere.Enabled = true;
                    groupBoxUser.Enabled = false;                   
                    groupBoxAdaugare.Enabled = false;
                    break;
            }
        }

        private void comboBoxCategorii_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCategorii.SelectedItem)
            {
                case Categorii.animal:
                    groupBoxAnimal.Enabled = true;
                    groupBoxObiectDeIngrijire.Enabled = false;
                    groupBoxHrana.Enabled = false;
                    groupBoxJucarii.Enabled = false;
                    break;
                case Categorii.obiect:
                    groupBoxObiectDeIngrijire.Enabled = true;
                    groupBoxAnimal.Enabled = false;
                    groupBoxHrana.Enabled = false;
                    groupBoxJucarii.Enabled = false;
                    break;
                case Categorii.hrana:
                    groupBoxHrana.Enabled = true;
                    groupBoxObiectDeIngrijire.Enabled = false;
                    groupBoxAnimal.Enabled = false;
                    groupBoxJucarii.Enabled = false;

                    break;
                case Categorii.jucarie:
                    groupBoxJucarii.Enabled = true;
                    groupBoxHrana.Enabled = false;
                    groupBoxObiectDeIngrijire.Enabled = false;
                    groupBoxAnimal.Enabled = false;
                    break;


            }
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {

            if(groupBoxAnimal.Enabled==true)
            {
                var animal = new Animal()
                {
                    Id = Convert.ToInt32(textBoxId.Text),
                    Pret = Convert.ToDouble(textBoxPret.Text),
                    Varsta = Convert.ToInt32(textBoxVarsta.Text),
                    Categorie = comboBoxSpecie.Text,
                };
                _presenter.AddAnimal(animal);

                MessageBox.Show("Produsul din categoria animale a fost adăugat cu succes!");
            }

            if (groupBoxObiectDeIngrijire.Enabled == true)
            {
                var obiectIngrijire = new ObiectIngrijire()
                {
                    Id = Convert.ToInt32(textBoxId.Text),
                    Pret = Convert.ToDouble(textBoxPret.Text),
                    Categorie = comboBoxCategorieIngrijire.Text,
                    Denumire = textBoxDenumireObiect.Text,
                };
                _presenter.AddObiecteIngrijire(obiectIngrijire);

                MessageBox.Show("Produsul din categoria obiecte de ingrijire a fost adăugat cu succes!");
            }

            if (groupBoxHrana.Enabled == true)
            {
                var hrana = new Hrana()
                {
                    Id = Convert.ToInt32(textBoxId.Text),
                    Pret = Convert.ToDouble(textBoxPret.Text),
                    Categorie = comboBoxCategorieHrana.Text,
                    Denumire = textBoxDenumireHrana.Text,
                };
                _presenter.AddHrana(hrana);

                MessageBox.Show("Produsul din categoria hrana a fost adăugat cu succes!");
            }

            if (groupBoxJucarii.Enabled == true)
            {
                var jucarie = new Jucarie()
                {
                    Id = Convert.ToInt32(textBoxId.Text),
                    Pret = Convert.ToDouble(textBoxPret.Text),
                    Denumire = textBoxDenumireJucarie.Text,
                };
                _presenter.AddJucarii(jucarie);

                MessageBox.Show("Produsul din categoria jucarii a fost adăugat cu succes!");
            }
        }

        private void buttonStegere_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBoxIdDeSters.Text);
            switch (comboBoxTipStergere.SelectedItem)
            {
                case Categorii.animal:
                    if(!_presenter.RemoveProdus(id, 0))
                    {
                        MessageBox.Show("Nu exista un astfel de animal");
                    }
                    else
                    {
                        MessageBox.Show("Stergere realizata cu succes!");
                    }
                    
                    break;
                case Categorii.obiect:
                    if (!_presenter.RemoveProdus(id, 1))
                    {
                        MessageBox.Show("Nu exista un astfel de obiect de ingrijire");
                    }
                    else
                    {
                        MessageBox.Show("Stergere realizata cu succes!");
                    }
                    break;
                case Categorii.hrana:
                    if (!_presenter.RemoveProdus(id, 2))
                    {
                        MessageBox.Show("Nu exista un astfel de hrana");
                    }
                    else
                    {
                        MessageBox.Show("Stergere realizata cu succes!");
                    }
                    break;
                case Categorii.jucarie:
                    if (!_presenter.RemoveProdus(id, 3))
                    {
                        MessageBox.Show("Nu exista un astfel de jucarie");
                    }
                    else
                    {
                        MessageBox.Show("Stergere realizata cu succes!");
                    }
                    break;
            }
           
        }
    }
}
