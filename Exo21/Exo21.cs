
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