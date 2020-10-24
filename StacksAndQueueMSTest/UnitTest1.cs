using Microsoft.VisualStudio.TestTools.UnitTesting;
using StacksAndQueues;

namespace StacksAndQueueMSTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Testing peek by giving expected value and taking actual value from method
        /// </summary>
        [TestMethod]
        public void TestingPeekinStacks()
        {
            //creating stacks set up, which will run for every test case
            //adding values in stacks
            //arrange
            Stacks stacks = new Stacks();
            stacks.Push(56);
            stacks.Push(53);
            stacks.Push(45);
            //Add
            int actual= stacks.Peek();
            int expected = 45;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing peek by giving expected value and taking actual value from method for queue
        /// </summary>
        [TestMethod]
        public void TestingPeekinQueue()
        {
            //creating queue set up, which will run for every test case
            //adding values in queue
            //arrange
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(53);
            queue.Enqueue(45);
            //Add
            int actual = queue.QueuePeek();
            int expected = 56;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
