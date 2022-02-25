﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetInfo;
using PetInfo.Classes.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Transactions;

namespace PetInfoTest
{
    [TestClass]
    public class PetDAOTest
    {
        PetDAO petDAO;
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=PetInfo;Integrated Security=True";

        private TransactionScope tran;

        private int count = 0;

        private int petId = 0;

        [TestInitialize]
        public void Setup()
        {
            tran = new TransactionScope();

            // Arrange
            petDAO = new PetDAO(connectionString);

            List<Pet> pets = petDAO.GetPets();
            count = pets.Count;

            Pet pet = new Pet("Xyzzy", "dog", "Afghan");
            petDAO.AddPet(pet);

            using (SqlConnection conn = new SqlConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT id FROM pet WHERE name = @name", conn);

                cmd.Parameters.AddWithValue("@name", "Xyzzy");

                int id = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod]
        public void PetDAOConstructor()
        {
            Assert.IsNotNull(petDAO);
        }

        [TestMethod]
        [DataRow("Dog 1", "dog", "All American")]
        [DataRow("Dog 2", "dog", "Mutt")]
        [DataRow("Dog 3", "dog", "Doberman")]

        public void PetDAOAddPet(string name, string type, string breed)
        {
            //Act
            petDAO.AddPet(name, type, breed);
            List<Pet> pets = petDAO.GetPets();

            //Assert
            Assert.AreEqual(name, pets[pets.Count - 1].Name);
        }

        [TestMethod]
        public void PetDAOGetPetsTest()
        {
            // act

            List<Pet> pets;
            pets = petDAO.GetPets();
            int afterCount = pets.Count;

            Assert.IsNotNull(pets);
            Assert.AreEqual(count + 1, afterCount);
        }

        //[TestMethod]
        //public void PetDAOGetPetTest()
        //{

        //}

        //[TestMethod]
        //public void PetDAOGetPetTest()
        //{

        //}
    }
}
