/**************************************************************************
 *                                                                        *
 *  File:        ModelTests.cs                                            *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description: Testarea unitatilor in Visual Studio. Aici vom           *
 *               verifica funcționalitatea corectă  a unităților          *
 *               individuale de cod sursă.                                *
 *                                                                        *
 **************************************************************************/

using Commons;
using Commons.infrastucture;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace PetShopTests
{
    /// <summary>
    /// ModelTests
    /// </summary>
    [TestClass]
    public class ModelTests
    {
        /// <summary>
        /// Obiect de tip IModel
        /// </summary>
        private IModel _model;

        /// <summary>
        /// Constructor ModelTests
        /// </summary>
        public ModelTests()
        {
            _model = new Model.Model();
        }

        /// <summary>
        /// Metoda de testare AddAnimal_Should_Throw_IdNegativExcetion
        /// </summary>
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

        /// <summary>
        /// Metoda de testare  AddAnimal_Should_Throw_VarstaException
        /// </summary>
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

        /// <summary>
        /// Metoda de testare AddAnimal_Should_Throw_PretNegativException
        /// </summary>
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

        /// <summary>
        /// Metoda de testare AddAnimal_Success
        /// </summary>
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

        /// <summary>
        /// Metoda de testare DeleteAnimal_Should_Throw_IdNegativExcetion
        /// </summary>

        [TestMethod]
        [ExpectedException(typeof(IdNegativExcetion))]
        public void DeleteAnimal_Should_Throw_IdNegativExcetion()
        {
            var id = -3;

            _model.DeleteAnimal(id);

        }

        /// <summary>
        /// Metoda de testare  DeleteAnimal_Should_Return_False
        /// </summary>
        [TestMethod]
        public void DeleteAnimal_Should_Return_False()
        {
            var id = 3;

            var result = _model.DeleteAnimal(id);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// Metoda de testare  DeleteAnimal_Should_Return_True
        /// </summary>
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

        /// <summary>
        /// Metoda de testare  AddObiecteIngrijire_Should_Throw_IdNegativExcetion
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IdNegativExcetion))]
        public void AddObiecteIngrijire_Should_Throw_IdNegativExcetion()
        {
            var animal = new Animal
            {
                Id = -2
            };

            _model.AddAnimal(animal);

        }

        /// <summary>
        /// Metoda de testare AddObiecteIngrijire_Should_Throw_PretNegativException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PretNegativException))]
        public void AddObiecteIngrijire_Should_Throw_PretNegativException()
        {
            var animal = new Animal
            {
                Id = 1,
                Pret = -1
            };

            _model.AddAnimal(animal);

        }
        /// <summary>
        /// Metoda de testare AddObiecteIngrijire_Success
        /// </summary>

        [TestMethod]
        public void AddObiecteIngrijire_Success()
        {
            var animal = new Animal
            {
                Id = 1,
                Pret = 20,
                Categorie = "caine"
            };

            _model.AddAnimal(animal);

            var animalDinLista = _model.GetAnimals().FirstOrDefault(x => x.Id == animal.Id);

            Assert.IsNotNull(animalDinLista);
        }
        /// <summary>
        /// Metoda de testare DeleteObiectIngrijire_Should_Throw_IdNegativExcetion
        /// </summary>

        [TestMethod]
        [ExpectedException(typeof(IdNegativExcetion))]
        public void DeleteObiectIngrijire_Should_Throw_IdNegativExcetion()
        {
            var id = -3;

            _model.DeleteAnimal(id);

        }

        /// <summary>
        /// Metoda de testare DeleteObiectIngrijire_Should_Return_False
        /// </summary>
        [TestMethod]
        public void DeleteObiectIngrijire_Should_Return_False()
        {
            var id = 3;

            var result = _model.DeleteAnimal(id);

            Assert.IsFalse(result);
        }
        /// <summary>
        /// Metoda de testare DeleteObiectIngrijire_Should_Return_True
        /// </summary>
        [TestMethod]
        public void DeleteObiectIngrijire_Should_Return_True()
        {
            var animal = new Animal
            {
                Id = 1,
                Pret = 20,
                Categorie = "caine"
            };
            _model.SetAnimals(new List<Animal>() { animal });
            var id = 1;

            var result = _model.DeleteAnimal(id);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// Metoda de testare AddJucarii_Should_Throw_IdNegativExcetion
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IdNegativExcetion))]
        public void AddJucarii_Should_Throw_IdNegativExcetion()
        {
            var animal = new Animal
            {
                Id = -2
            };

            _model.AddAnimal(animal);

        }

        /// <summary>
        /// Metoda de testare AddJucarii_Should_Throw_PretNegativException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PretNegativException))]
        public void AddJucarii_Should_Throw_PretNegativException()
        {
            var animal = new Animal
            {
                Id = 1,
                Pret = -1
            };

            _model.AddAnimal(animal);

        }

        /// <summary>
        /// Metoda de testare AddJucarii_Success
        /// </summary>
        [TestMethod]
        public void AddJucarii_Success()
        {
            var animal = new Animal
            {
                Id = 1,
                Categorie = "caine"
            };

            _model.AddAnimal(animal);

            var animalDinLista = _model.GetAnimals().FirstOrDefault(x => x.Id == animal.Id);

            Assert.IsNotNull(animalDinLista);
        }


        /// <summary>
        /// Metoda de testare DeleteJucarii_Should_Throw_IdNegativExcetion
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IdNegativExcetion))]
        public void DeleteJucarii_Should_Throw_IdNegativExcetion()
        {
            var id = -3;

            _model.DeleteAnimal(id);

        }
        /// <summary>
        /// Metoda de testare DeleteJucarii_Should_Return_False
        /// </summary>

        [TestMethod]
        public void DeleteJucarii_Should_Return_False()
        {
            var id = 3;

            var result = _model.DeleteAnimal(id);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// Metoda de testare DeleteJucarii_Should_Return_True 
        /// </summary>
        [TestMethod]
        public void DeleteJucarii_Should_Return_True()
        {
            var animal = new Animal
            {
                Id = 1,
                Pret = 20,
                Categorie = "caine"
            };
            _model.SetAnimals(new List<Animal>() { animal });
            var id = 1;

            var result = _model.DeleteAnimal(id);

            Assert.IsTrue(result);
        }


        /// <summary>
        /// Metoda de testare  AddHrana_Should_Throw_IdNegativExcetion
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IdNegativExcetion))]
        public void AddHrana_Should_Throw_IdNegativExcetion()
        {
            var animal = new Animal
            {
                Id = -2
            };

            _model.AddAnimal(animal);

        }

        /// <summary>
        /// Metoda de testare AddHrana_Should_Throw_PretNegativException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PretNegativException))]
        public void AddHrana_Should_Throw_PretNegativException()
        {
            var animal = new Animal
            {
                Id = 1,
                Pret = -1,
            };

            _model.AddAnimal(animal);

        }


        /// <summary>
        /// Metoda de testare AddHrana_Success
        /// </summary>
        [TestMethod]
        public void AddHrana_Success()
        {
            var animal = new Animal
            {
                Id = 1,
                Pret = 20,
                Categorie = "caine"
            };

            _model.AddAnimal(animal);

            var animalDinLista = _model.GetAnimals().FirstOrDefault(x => x.Id == animal.Id);

            Assert.IsNotNull(animalDinLista);
        }

        /// <summary>
        /// Metoda de testare DeleteHrana_Should_Throw_IdNegativExcetion
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IdNegativExcetion))]
        public void DeleteHrana_Should_Throw_IdNegativExcetion()
        {
            var id = -3;

            _model.DeleteAnimal(id);

        }

        /// <summary>
        /// Metoda de testare  DeleteHrana_Should_Return_False
        /// </summary>
        [TestMethod]
        public void DeleteHrana_Should_Return_False()
        {
            var id = 3;

            var result = _model.DeleteAnimal(id);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// Metoda de testare DeleteHrana_Should_Return_True()
        /// </summary>
        [TestMethod]
        public void DeleteHrana_Should_Return_True()
        {
            var animal = new Animal
            {
                Id = 1,
                Pret = 20,
                Categorie = "caine"
            };
            _model.SetAnimals(new List<Animal>() { animal });
            var id = 1;

            var result = _model.DeleteAnimal(id);

            Assert.IsTrue(result);
        }

    }
}
