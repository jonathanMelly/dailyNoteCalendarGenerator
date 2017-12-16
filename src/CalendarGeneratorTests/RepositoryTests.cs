using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarGenerator.Tests
{
    [TestClass()]
    public class RepositoryTests
    {
        Repository repository;

        [TestInitialize]
        public void Prepare()
        {
            repository = new Repository();
        }

        [TestMethod()]
        public void InitTest()
        {
            //ARRANGE


            //ACT
            repository.Init();

           //ASSERT
        }
    }
}