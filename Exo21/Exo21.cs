
public class Exo21 : Exo
{
    /// <summary>
    /// Task, async and http call.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // path of my web page.
        const string path = "https://www.w3schools.com/python/demopage.htm";

        // call my function async, and stock the Task.
        Task<string> myTaskToWait = ExecAsync(path);

        // wait until the task was end.
        myTaskToWait.Wait();

        // print the result (page web contend).
        Console.WriteLine(myTaskToWait.Result);


        //await Task.WhenAll(myTaskOne, myTaskTwo); // wait for many task are all finish.

        //Task myT = Task.Run(() => {}); // for create a task base on a lambda.
        //Task<string> myT = Task.Run(() => { return "test"; }); // for create a task (with return value).
        //myT.Status // get state of a Task : OnCanceled for is canceled, or OnFaulted for an Exception find on it.
        //TaskFactory // class for create many task easily.
        //Task.WaitAll(listOfTask) // make wait for end of many task.
        //Task.WaitAny(listOfTask) // make wait for end of one task on the list (only one, the first who end).

        /*/ -- Task Contuie With --
        Task<string> myTParam = Task.Run(() => // process.
        {
            return "test";
        });
        myTParam.ContinueWith((result) => // add process before task end.
        {
            return result;
        });
        myTParam.ContinueWith((result) => // add process if find an exception.
        {
            return result;
        }, TaskContinuationOptions.OnlyOnFaulted);
        myTParam.ContinueWith((result) => // add process if canceled.
        {
            return result;
        }, TaskContinuationOptions.OnlyOnCanceled);
        //*/

        //Parallel // class for manage many Task on loop.
        //ParallelLoopState // class for manage many Task on loop (and can stop the loop). include Stop and Break.

    }

    /// <summary>
    /// function async (run a baralel process execution), for call a web page.
    /// </summary>
    /// <returns>return a Task, object to evalue the async execution.</returns>
    private async Task<string> ExecAsync(string path)
    {
        // get data from internet with HTTP call.
        HttpClient client = new HttpClient();
        string responce = await client.GetStringAsync(path); // call in await, for make the execution pause until this function was end.
        return responce;
    }
}