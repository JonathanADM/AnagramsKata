using NUnit.Framework;
using Anagrams;
using System.Collections.Generic;
using System.IO;

namespace AnagramsTest
{
    public class ManageFileTest
    {
        [Test]
        public void GetPath_Argument_IsNull()
        {
            ManageFile manageFile = new ManageFile();
            string[] args = { null };
            Assert.That(() => manageFile.GetPath(args), Throws.ArgumentNullException.And.Message.EqualTo("Debe especificar alguna direccion de archivo de texto"));
        }

        [Test]
        public void Input_File_NotFound()
        {
            ManageFile manageFile = new ManageFile();
            string[] args = { "hola" };
            Assert.That(() => manageFile.GetPath(args), Throws.Exception.TypeOf<FileNotFoundException>().And.Message.EqualTo("No se encontro el archivo de texto"));
        }
    }
}
