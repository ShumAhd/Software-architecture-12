

using Castle.Components.DictionaryAdapter.Xml;
using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services.Impl;
using Microsoft.AspNetCore.Mvc;

namespace ClinicTest
{
    public class Tests
    {
        private ClientController clientController;
        private PetController petController;
        private ConsultationController consultationController;

        [SetUp]
        public void Setup()
        {
            clientController = new ClientController(new ClientRepository());
            petController = new PetController(new PetRepository());
            consultationController = new ConsultationController(new ConsultationRepository());

            clientController.Create(new CreateClientRequest());
            clientController.Create(new CreateClientRequest());
            clientController.Create(new CreateClientRequest());
            clientController.Create(new CreateClientRequest());

            petController.Create(new CreatePetRequest());
            petController.Create(new CreatePetRequest());
            petController.Create(new CreatePetRequest());
            petController.Create(new CreatePetRequest());

            consultationController.Create(new CreateConsultationRequest());
            consultationController.Create(new CreateConsultationRequest());
            consultationController.Create(new CreateConsultationRequest());
            consultationController.Create(new CreateConsultationRequest());

        }

        [Test]
        public void Test1_getAll()
        {
            var clientResult = clientController.GetAll();


            if (clientResult.Result.GetType() == (new List<Client>()).GetType())
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test2_getAll()
        {
            var petResult = petController.GetAll();

            if (petResult.Result.GetType() == (new List<Pet>()).GetType())
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test3_getAll()
        {
            var consultationResult = consultationController.GetAll();

            if (consultationResult.Result.GetType() == (new List<Pet>()).GetType())
                Assert.Pass();
            else
                Assert.Fail();
        }




    }
}