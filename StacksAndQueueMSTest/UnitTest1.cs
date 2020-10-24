using Microsoft.VisualStudio.TestTools.UnitTesting;
using StacksAndQueues;

namespace StacksAndQueueMSTest
{
    [TestClass]
    public class UnitTest1
    {
        Stacks stacks = new Stacks();
        /// <summary>
        /// creating stacks set up, which will run for every test case
        /// adding values in stacks
        /// </summary>
        [TestInitialize]
        public void StackSetUp()
        {
            //Arrange
            stacks.Push(56);
            stacks.Push(53);
            stacks.Push(45);
        }
        /// <summary>
        /// Testing peek by giving expected value and taking actual value from method
        /// </summary>
        [TestMethod]
        public void TestingPeekinStacks()
        {
            //Add
            int actual= stacks.Peek();
            int expected = 45;
            //Assert
            Assert.AreEqual(expected, actual);

            

        }
    }
}
