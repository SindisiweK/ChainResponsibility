using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainResponsibilty;
using System.IO;

namespace ChainResponsibilty.Tests
{
    [TestFixture]
    public class FileParserTests
    {
        [Test]
        public void GivenTextFile_ShouldReturnMessageWithTextFileExtension()
        {
            //Arrange
            var fileName = "Spec.txt";
            var text = new TextFile();
            var json = new JSONFile();
            var csv = new CsvFile();
            var xml = new XmlFile();


            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            text.Parse(fileName);

            //Assert
            var expected = "File should be parsed with .txt";
            Assert.AreEqual(expected, fakeoutput.ToString());
        }

        [Test]
        public void GivenJsonFile_ShouldReturnJsonFileExtension()
        {
            //Arrange
            var fileName = "Spec.json";
            var text = new TextFile();
            var json = new JSONFile();
            var csv = new CsvFile();
            var xml = new XmlFile();

            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            json.Parse(fileName);

            //Assert
            var expected = "File should be parsed with .json";
            Assert.AreEqual(expected, fakeoutput.ToString());
        }

        [Test]
        public void GivenCsvFile_ShouldReturnCsvFileExtension()
        {
            //Arrange
            var fileName = "Spec.csv";

            var csv = new CsvFile();
            var text = new TextFile();
            var json = new JSONFile();
            var xml = new XmlFile();

            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            csv.Parse(fileName);

            //Assert
            var expected = "File should be parsed with .csv";
            Assert.AreEqual(expected, fakeoutput.ToString());
        }

        [Test]
        public void GivenXmlFile_ShouldReturnXmlFileExtension()
        {
            //Arrange
            var fileName = "Spec.xml";

            var xml = new XmlFile();
            var csv = new CsvFile();
            var text = new TextFile();
            var json = new JSONFile();
           

            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            xml.Parse(fileName);

            //Assert
            var expected = "File should be parsed with .xml";
            Assert.AreEqual(expected, fakeoutput.ToString());
        }

        [Test]
        public void GivenFileWithWringExtension_ShouldReturnMessageError()
        {
            //Arrange
            var fileName = "Spec.vd";

            var xml = new XmlFile();
            var csv = new CsvFile();
            var text = new TextFile();
            var json = new JSONFile();


            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            xml.Parse(fileName);

            //Assert
            var expected = "File cannot be parsed !!!";
            Assert.AreEqual(expected, fakeoutput.ToString());
        }
    }
}
