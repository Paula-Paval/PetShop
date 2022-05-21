/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                             *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description: Punctul din aplicatie cel mai aproape de utilizator      *
 *               contine operatiile pe care le poate face utilizatorul    *
 *               prin intermediul interfetei grafice                      *
 **************************************************************************/
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
using Commons.infrastucture;

namespace PetShop
{
    /// <summary>
    /// Clasa FormPetShop
    /// </summary>
    public partial class FormPetShop : Form, IView
    {
        /// <summary>
        /// Presenter-ul
        /// </summary>
        private IPresenter _presenter;

        /// <summary>
        /// Lista de optiuni
        /// </summary>
        private List<MenuOption> _menuOptions;

        /// <summary>
        /// Enumaram Categoriile
        /// </summary>
        public enum Categorii
        {
            animal,
            obiect,
            hrana,
            jucarie,

        }

        /// <summary>
        /// Enumaram speciile de animale
        /// </summary>
        public enum Specii
        {
            caine,
            pisica,

        }

        /// <summary>
        /// Enumaram Categoriile de obiecte de ingrijire
        /// </summary>
        public enum CategorieObiecte
        {
            perie,
            cuscaTransport,
            bol,

        }
        /// <summary>
        /// Enumaram Categoriile de hrana 
        /// </summary>
        public enum CategorieHrana
        {
            hranaUmedaCaini,
            hranaUscataCaini,
            hranaUmedaPisici,
            hranaUscataPisici,
        }


        /// <summary>
        /// FormPetShop
        /// </summary>
        public FormPetShop()
        {
            InitializeComponent();
            groupBoxUser.Enabled = false;
            groupBoxStergere.Enabled = false;
            groupBoxAdaugare.Enabled = false;
            comboBoxCategorii.DataSource = Enum.GetValues(typeof(Categorii));
            comboBoxCategorii.SelectedItem = Categorii.animal;
            comboBoxSpecie.DataSource = Enum.GetValues(typeof(Specii));
            comboBoxSpecie.SelectedItem = Specii.caine;
            comboBoxCategorieIngrijire.DataSource = Enum.GetValues(typeof(CategorieObiecte));
            comboBoxCategorieIngrijire.SelectedItem = CategorieObiecte.perie;
            comboBoxCategorieHrana.DataSource = Enum.GetValues(typeof(CategorieHrana));
            comboBoxCategorieHrana.SelectedItem = CategorieHrana.hranaUmedaCaini;
            comboBoxTipStergere.DataSource = Enum.GetValues(typeof(Categorii));
            comboBoxTipStergere.SelectedItem = Categorii.animal;
            comboBoxTipCumparare.DataSource = Enum.GetValues(typeof(Categorii));
            comboBoxTipCumparare.SelectedItem = Categorii.animal;

        }

        /// <summary>
        /// SetPresenter
        /// </summary>
        /// <param name="presenter">Obiect de tip IPresenter</param>
        public void SetPresenter(IPresenter presenter)
        {
            _presenter = presenter;
            try
            {
                _presenter.Init();
            }
            catch (FisierNotFoundException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
     

        /// <summary>
        /// Lista meniu
        /// </summary>
        /// <param name="sender">Parametru de tip object</param>
        /// <param name="e">Parametru de tip EventArgs</param>
        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (listBoxMenu.SelectedItem.ToString())
            {
                case "Utilizator":
                    Meniu.UserMenu(out _menuOptions);
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

        /// <summary>
        /// Lista 
        /// </summary>
        /// <param name="sender">Parametru de tip object</param>
        /// <param name="e">Parametru de tip EventArgs</param>
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valoare = listBox.SelectedItem.ToString();
;            switch (valoare)
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
                case "Afisarea tuturor animalelor":
                    richTextBoxAfisare.Text = _presenter.List(Constante.Animal);
                    break;
                case "Afisarea tuturor jucariilor":
                    richTextBoxAfisare.Text = _presenter.List(Constante.Jucarie);
                    break;
                case "Afisarea tuturor obiectlor de ingrijire ":
                    richTextBoxAfisare.Text = _presenter.List(Constante.ObiectDeIngrijire);
                    break;
                case "Afisarea hranei ":
                    richTextBoxAfisare.Text = _presenter.List(Constante.Hrana);
                    break;
                case "Cumparare":
                    groupBoxUser.Enabled = true;
                    groupBoxAdaugare.Enabled = false;
                    groupBoxStergere.Enabled = false;
                    break;

            }
        }

        /// <summary>
        /// Categorii
        /// </summary>
        /// <param name="sender">Parametru de tip object</param>
        /// <param name="e">Parametru de tip EventArgs</param>
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

        /// <summary>
        /// Butonul adauga
        /// </summary>
        /// <param name="sender">Parametru de tip object</param>
        /// <param name="e">Parametru de tip EventArgs</param>
        private void buttonAdauga_Click(object sender, EventArgs e)
        {

            if (groupBoxAnimal.Enabled == true)
            {
                try
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
                catch (FisierNotFoundException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (IdNegativExcetion ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (PretNegativException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (VarstaException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

            }

            if (groupBoxObiectDeIngrijire.Enabled == true)
            {
                try
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
                catch (FisierNotFoundException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (IdNegativExcetion ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (PretNegativException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }

            if (groupBoxHrana.Enabled == true)
            {
                try
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
                catch (FisierNotFoundException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (IdNegativExcetion ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (PretNegativException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }

            if (groupBoxJucarii.Enabled == true)
            {
                try
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
                catch (FisierNotFoundException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (IdNegativExcetion ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (PretNegativException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        /// <summary>
        /// Butonul stergere
        /// </summary>
        /// <param name="sender">Parametru de tip object</param>
        /// <param name="e">Parametru de tip EventArgs</param>

        private void buttonStegere_Click(object sender, EventArgs e)
        {
           
            try
            {
                var id = Convert.ToInt32(textBoxIdDeSters.Text);
                switch (comboBoxTipStergere.SelectedItem)
                {
                    case Categorii.animal:
                        if (!_presenter.RemoveProdus(id, Constante.Animal))
                        {
                            MessageBox.Show("Nu exista un astfel de animal");
                        }
                        else
                        {
                            MessageBox.Show("Stergere realizata cu succes!");
                        }

                        break;
                    case Categorii.obiect:
                        if (!_presenter.RemoveProdus(id, Constante.ObiectDeIngrijire))
                        {
                            MessageBox.Show("Nu exista un astfel de obiect de ingrijire");
                        }
                        else
                        {
                            MessageBox.Show("Stergere realizata cu succes!");
                        }
                        break;
                    case Categorii.hrana:
                        if (!_presenter.RemoveProdus(id, Constante.Hrana))
                        {
                            MessageBox.Show("Nu exista un astfel de hrana");
                        }
                        else
                        {
                            MessageBox.Show("Stergere realizata cu succes!");
                        }
                        break;
                    case Categorii.jucarie:
                        if (!_presenter.RemoveProdus(id, Constante.Jucarie))
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
            catch (FisierNotFoundException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (IdNegativExcetion ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }


        }

        /// <summary>
        /// Butonul cumpara
        /// </summary>
        /// <param name="sender">Parametru de tip object</param>
        /// <param name="e">Parametru de tip EventArgs</param>
        private void buttonCumpara_Click(object sender, EventArgs e)
        {
            var denumire = textBoxCumparare.Text;
            try
            {
                switch (comboBoxTipCumparare.SelectedItem)
                {
                    case Categorii.animal:
                        if (!_presenter.Cumpara(Constante.Animal, denumire))
                        {
                            MessageBox.Show("Nu exista un astfel de animal");
                        }
                        else
                        {
                            MessageBox.Show("Cumparare  realizata cu succes!");
                        }

                        break;
                    case Categorii.obiect:
                        if (!_presenter.Cumpara(Constante.ObiectDeIngrijire, denumire))
                        {
                            MessageBox.Show("Nu exista un astfel de obiect de ingrijire");
                        }
                        else
                        {
                            MessageBox.Show("Cumparare realizata cu succes!");
                        }
                        break;
                    case Categorii.hrana:
                        if (!_presenter.Cumpara(Constante.Hrana, denumire))
                        {
                            MessageBox.Show("Nu exista un astfel de hrana");
                        }
                        else
                        {
                            MessageBox.Show("Cumparare realizata cu succes!");
                        }
                        break;
                    case Categorii.jucarie:
                        if (!_presenter.Cumpara(Constante.Jucarie, denumire))
                        {
                            MessageBox.Show("Nu exista un astfel de jucarie");
                        }
                        else
                        {
                            MessageBox.Show("Cumparare realizata cu succes!");
                        }
                        break;
                }
            }
            catch (FisierNotFoundException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (IdNegativExcetion ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        /// <summary>
        /// Butonul about
        /// </summary>
        /// <param name="sender">Parametru de tip object</param>
        /// <param name="e">Parametru de tip EventArgs</param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect IP: PetShop \nRealizat de: \n \t *Bursuc Stefana \n \t *Chihaia Georgiana \n \t *Paula Paval \n \t *Timofte Constantin-Bogdan \n Grupa: 1309B");
        }
    }
}
