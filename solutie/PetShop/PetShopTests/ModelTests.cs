using Commons;
using Commons.infrastucture;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace PetShopTests
{
    [TestClass]
    public class ModelTests
    {
        private IModel _model;
        public ModelTests()
        {
            _model = new Model.Model();
        }

        [TestMethod]
        [ExpectedException(typeof(IdNegativExcetion))]
        public void AddAnimal_Should_Throw_IdNegativExcetion()
        {
            var animal = new Animal
            {
                Id = -2
            };

            _model.AddAnimal(animal);

        }
        [TestMethod]
        [ExpectedException(typeof(VarstaException))]
        public void AddAnimal_Should_Throw_VarstaException()
        {
            var animal = new Animal
            {
                Id = 1,
                Varsta = -2
            };

            _model.AddAnimal(animal);

        }
        [TestMethod]
        [ExpectedException(typeof(PretNegativException))]
        public void AddAnimal_Should_Throw_PretNegativException()
        {
            var animal = new Animal
            {
                Id = 1,
                Varsta = 20,
                Pret = -1,
            };

            _model.AddAnimal(animal);

        }

        [TestMethod]
        public void AddAnimal_Success()
        {
            var animal = new Animal
            {
                Id = 1,
                Varsta = 20,
                Pret = 20,
                Categorie = "caine"
            };

            _model.AddAnimal(animal);

            var animalDinLista = _model.GetAnimals().FirstOrDefault(x => x.Id == animal.Id);

            Assert.IsNotNull(animalDinLista);
        }

        [TestMethod]
        [ExpectedException(typeof(IdNegativExcetion))]
        public void DeleteAnimal_Should_Throw_IdNegativExcetion()
        {
            var id = -3;

            _model.DeleteAnimal(id);

        }
        [TestMethod]
        public void DeleteAnimal_Should_Return_False()
        {
            var id = 3;

            var result = _model.DeleteAnimal(id);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void DeleteAnimal_Should_Return_True()
        {
            var animal = new Animal
            {
                Id = 1,
                Varsta = 20,
                Pret = 20,
                Categorie = "caine"
            };
            _model.SetAnimals(new List<Animal>() {animal }  );
            var id = 1;

            var result = _model.DeleteAnimal(id);

            Assert.IsTrue(result);
        }
    }
}
