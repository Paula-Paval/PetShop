using Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static View.Meniu;

namespace View
{
    public class View : IView
    {
        private IPresenter _presenter;
        private IModel _model;
        private List<MenuOption> _menuOptions1;
        private List<MenuOption> _menuOptions2;
        private MenuState _menuState;


        public View()
        {

        }
        public void SetModel(IModel model)
        {
            _model = model;
        }
        private void SetMenu(MenuState menuState)
        {
            _menuState = menuState;
        }
        private void ManageMenu(UserChoice choice)
        {

        }
        private void  EnableCumparare()
        {

        }
        private void EnableAdaugare()
        {

        }
        private void EnableStergere()
        {

        }
        private void ListAll(string tip )
        {

        }
        public void Display(string text, string color)
        {
            throw new NotImplementedException();
        }

        public void SetPresenter(IPresenter presenter)
        {
            throw new NotImplementedException();
        }
    }
}
