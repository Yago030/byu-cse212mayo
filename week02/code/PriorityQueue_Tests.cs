using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with unique priorities and dequeue until empty.
    // Expected Result: The item with the highest priority is removed first, then the next highest, then the lowest.
    // Defect(s) Found: 
    public void TestPriorityQueue_DequeueHighestPriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("medium", 5);
        priorityQueue.Enqueue("high", 10);

        Assert.AreEqual("high", priorityQueue.Dequeue());
        Assert.AreEqual("medium", priorityQueue.Dequeue());
        Assert.AreEqual("low", priorityQueue.Dequeue());
    }



    [TestMethod]
    // Scenario: Enqueue items with the same highest priority and verify FIFO behavior among them.
    // Expected Result: The first enqueued highest-priority item is removed before the later one.
    // Defect(s) Found: 



    public void TestPriorityQueue_EqualPriorityRetainsFifo()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("firstHigh", 7);
        priorityQueue.Enqueue("low", 3);
        priorityQueue.Enqueue("secondHigh", 7);

        Assert.AreEqual("firstHigh", priorityQueue.Dequeue());
        Assert.AreEqual("secondHigh", priorityQueue.Dequeue());
        Assert.AreEqual("low", priorityQueue.Dequeue());
    }




    [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: InvalidOperationException is thrown with message "The queue is empty."
    // Defect(s) Found: 
    public void TestPriorityQueue_EmptyThrows()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            //read about design patterns for testing exceptions and use the one you think is best here.  You can also use the ExpectedException attribute if you want, but it is not required.
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail($"Unexpected exception of type {e.GetType()} caught: {e.Message}");
        }
    }

    // Add more test cases as needed below.
    //no no its okay XD
}