namespace LeetCode75.Solutions.Stacks;

public class MyStack
{
    private readonly Queue<int> queue;

    public MyStack()
    {
        queue = new Queue<int>();
    }

    public void Push(int x)
    {
        queue.Enqueue(x);

        for (int i = 0; i < queue.Count - 1; i++)
        {
            queue.Enqueue(queue.Dequeue());
        }
    }

    // Removes the element on the top of the stack and returns it.
    public int Pop()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        // No special handling needed as we already maintain the order in Push. 
        return queue.Dequeue();
    }

    // Returns the element on the top of the stack.
    public int Top()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        // The front of the queue is the top of the stack.
        return queue.Peek();
    }

    // Returns whether the stack is empty.
    public bool Empty()
    {
        return queue.Count == 0;
    }
}