using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    /// <summary>
    /// Summary description for tstRooms
    /// </summary>
    [TestClass]
    public class tstRooms
    {
        public tstRooms()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsRooms ARoom = new clsRooms(); //create an instance of our class clsRooms
            Assert.IsNotNull(ARoom); //check to see that the class is not null
        }
    }
}
