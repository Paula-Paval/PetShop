using Commons;
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
                
            }
           
        }
    }
}
