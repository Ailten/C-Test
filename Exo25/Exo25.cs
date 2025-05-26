
public class Exo25 : Exo
{
    /// <summary>
    /// thread.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // Thread.
        Thread wait5 = new Thread(new ParameterizedThreadStart(AVoidCallWithParam)); // set methode to a thread (with parameter).
        Thread wait2 = new Thread(new ParameterizedThreadStart(AVoidCallWithParam)); // set methode (without parameter).
        Thread noParam = new Thread(new ThreadStart(AVoidCall));

        wait5.Start(5); // call the thread to execute it.
        wait2.Start(2);
        noParam.Name = "NoParam"; // set a name to a thread.
        noParam.Priority = ThreadPriority.AboveNormal; // set a priority (ordre of priority execution).
        noParam.Start();

        Thread wait8 = new Thread(new ParameterizedThreadStart(AVoidCallWithParam));
        wait8.Start(8);
        wait8.Join(); // force this current process to wait thread is end.


        // also see :
        //ThreadLocal<>
        //ThreadPool.QueueUserWorkItem(wait2); // for manage many thread.
        //lock // key word for make a block who and element is only editable on the execution (not another thread).
        //volatile // a key word for mark a variable "is acessible by many tread simultaneous", say to the compilator.
        //Interlocked // make sure to access to the right value of an element (not the value edited during an execution of other thread).
        //CancellationToken // for manage cancel action of a thread.
        //CancellationTokenSource
        //CancellationToken myToken = myCancellationTokenSource.token; // generate a token.
        //myToken.isCancellationRequested // get bool isCancelRequested.
        //myCancellationTokenSource.Cancel(); // action of cancel.
        //myToken.ThrowIfCancellationRequest(); // throw an exception when token source is canceled.

    }


    public void AVoidCallWithParam(object? waitSeconde)
    {
        if (waitSeconde is int)
        {
            int waitS = (int)waitSeconde;
            Thread.Sleep(waitS); // wait.
            int currentThreadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"End of void call (wait{waitS}) (id: {currentThreadId})");
        }
        else
        {
            throw new ObjectCast();
        }
    }
    public void AVoidCall()
    {
        int currentThreadId = Thread.CurrentThread.ManagedThreadId;
        Console.WriteLine($"End of void call (noParam) (id: {currentThreadId})");
    }
}

