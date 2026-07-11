using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Items with different priorities are added.
    // Expected Result: Item with highest priority is returned first.
    // Defect(s) Found: None after fix.: 
    public void TestPriorityQueue_HighestPriority()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

    Assert.AreEqual("B", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Two items share the same highest priority.
    // Expected Result: First inserted item is removed first.
    // Defect(s) Found: Queue returned newest item instead of oldest.
    public void TestPriorityQueue_FIFO()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 1);

        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Remove item from empty queue.
    // Expected Result: InvalidOperationException with correct message.
    // Defect(s) Found: None after fix.
    public void TestPriorityQueue_Empty()
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
    }

    [TestMethod]
    // Scenario: Highest priority item is the last item in queue.
    // Expected Result: Last item should be returned.
    // Defect(s) Found: Last item was never examined.
    public void TestPriorityQueue_LastElementHighest()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 10);

        Assert.AreEqual("C", priorityQueue.Dequeue());
    }
}