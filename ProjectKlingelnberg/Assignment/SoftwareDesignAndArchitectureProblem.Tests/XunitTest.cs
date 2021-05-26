using System;
using Xunit;
using Machines;
using System.Collections.Generic;

namespace SoftwareDesignAndArchitectureProblem.Tests
{
    public class TestingSoftwareDesignAndArchitectureProblem
    {
        [Fact]
        public void CheckingTheSizeOfCsvFile()
        {

            //arrange
            string userinput="Cutter head";
            string filePath = @"/Users/abhinnmishra/Downloads/CsharpHandson/ProjectKlingelnberg/Assignment/Data.csv";
            CsvReader reader = new CsvReader(filePath, userinput);
            List<Structure> machines = reader.ReadAllMachines();
            int actual = 9;
            //act

            int expected = machines.Count;

            //assert

            Assert.Equal(actual, expected);

        }

    }
}
