using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_EmptyQueue()
    {

        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }

    [TestMethod]
    // Scenario: Add items with mixed priorities and ensure the Dequeue() function will always retrieve the highest priority item.
    // Expected Result: "F3"
    // Defect(s) Found: 
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("F1", -10);
        priorityQueue.Enqueue("F2", -2);
        priorityQueue.Enqueue("F3", 5);
        priorityQueue.Enqueue("F4", 1);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("F3", result);
    }

    // Add more test cases as needed below.
    [TestMethod]
    //Scenario: Add items with same priority and ensure the Dequeue() function will follow the FIFO behavior for the items with the same priority
    //Expected Result: "F2", then "F5"
    //Defect(s) Found:
    public void TestPriorityQueue_EqualPriorities()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("F1", 1);
        priorityQueue.Enqueue("F2", 5);
        priorityQueue.Enqueue("F3", 2);
        priorityQueue.Enqueue("F4", 3);
        priorityQueue.Enqueue("F5", 5);

        var firstResult = priorityQueue.Dequeue();
        var secondResult = priorityQueue.Dequeue(); //Checking if the FIFO Behavior is working

        Assert.AreEqual("F2", firstResult); //Highest priority first
        Assert.AreEqual("F5", secondResult);//FIFO for the same priority
    }
    // Add more test cases as needed below.

}
