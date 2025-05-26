
using System.Collections.Concurrent;
using System.ComponentModel.Design;

public class Exo24 : Exo
{
    /// <summary>
    /// list.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {

        // set list (both waye).
        List<string> ls1 = new()
        {
            "Thomas",
            "Benois",
            "Tom",
            "Bob",
            "Berthran"
        };
        List<string> ls2 = new();
        ls2.Add("philippe");
        ls2.Add("bob");


        // where example.
        List<string> listFilter = ls1.Where(name => name == "Tom").ToList();
        Console.WriteLine(" --- where --- ");
        Console.WriteLine($"{string.Join(", ", listFilter)}");


        // make a join (get match elements).
        List<string> joinMatch = ls1.Join(ls2,
            nameLs1 => nameLs1.ToLower(),
            nameLs2 => nameLs2,
            (nameLs1, nameLs2) => nameLs1.ToUpper()
        ).ToList();
        Console.WriteLine(" --- join --- ");
        Console.WriteLine($"{string.Join(", ", joinMatch)}");


        // linq example (like sql request).
        List<string> getByLinq = (
            from name in ls1
            orderby name.Length
            select $"name-{name.ToLower()}"
        ).ToList();
        Console.WriteLine(" --- linq --- ");
        Console.WriteLine($"{string.Join(", ", getByLinq)}");


        // how to make pagination with skip and take.
        const int elementsByPage = 2;
        Console.WriteLine(" --- skip and take --- ");
        for (int indexPage = 0; indexPage * elementsByPage < getByLinq.Count; indexPage++)
        {
            var page = getByLinq.Skip(elementsByPage * indexPage).Take(elementsByPage);
            Console.WriteLine($"page {indexPage} => {string.Join(", ", page)}");
        }


        // example of dictionary.
        Dictionary<string, string> ls1FamilyName = new();
        ls1FamilyName.Add("Thomas", "Brouette");
        ls1FamilyName.Add("Benois", "Piché");
        ls1FamilyName.Add("Tom", "Du-Pont");
        ls1FamilyName.Add("Bob", "Van-De-Ver");
        ls1FamilyName.Add("Berthran", "Du-Pont");

        Console.WriteLine(" --- dictionary --- ");
        Console.WriteLine($"FamilyName of Thomas : {ls1FamilyName["Thomas"]}"); // get value by acessor.

        // try get.
        string? getFamilyName;
        if (ls1FamilyName.TryGetValue("Thomas", out getFamilyName)) // try get value (return false if dictionary don't have the value).
            Console.WriteLine($"FamilyName of Thomas : {getFamilyName}");
        if (ls1FamilyName.TryGetValue("Toto", out getFamilyName))
            Console.WriteLine($"FamilyName of Toto : {getFamilyName}"); // (case when it's not on dictionary : if is not call).

        // example of key value pair (from dictionary).
        foreach (KeyValuePair<string, string> familyNames in ls1FamilyName)
        {
            if (familyNames.Key == "Thomas")
                Console.WriteLine(familyNames.Value);
        }



        // queue. (work like a queue, first in, last out)
        Queue<string> queueStr = new();
        queueStr.Enqueue("aaa");
        queueStr.Enqueue("bbb");
        queueStr.Enqueue("ccc");
        queueStr.Dequeue(); // remove and return.

        Console.Write(" --- queue --- ");
        foreach (string s in queueStr)
        {
            Console.Write(s);
        }
        Console.Write("\n");

        // stack. (work like a pill of plate, first in, first out)
        Stack<string> stackStr = new();
        stackStr.Push("aaa");
        stackStr.Push("bbb");
        stackStr.Push("ccc");

        Console.Write(" --- stack --- ");
        foreach (string s in stackStr)
        {
            Console.Write(s);
        }
        Console.Write("\n");



        // AsParallel. (make the process of the list async)
        List<string> listOfStr = ls1.AsParallel().Where((s) => s.Length > 5).ToList();
        // see also :
        //.AsOrdered() // for make sur it execute on the right order (as async).
        //.AsSequential() // re-do sequencial (un-async).

        // BlockingCollection (and other). -> using thread and async.
        BlockingCollection<string> bc = new BlockingCollection<string>(boundedCapacity: 3);
        bc.Add("aaa"); // add.
        bc.Add("bbb");
        bc.TryAdd("ccc"); // add with verification (if is valid, and return bool).
        bc.Take(); // take element from list (return value and drop from list).
        bc.TryTake(out getFamilyName); // take element from list (return bool isValid, afect param and drop from list).
        (new ConcurrentBag<string>()).TryPeek(out getFamilyName); // take element from list (return bool isValid, afect param and stay on list).
        (new ConcurrentDictionary<int, string>()).TryUpdate(0, "newValue", "no-value"); // try to edit a value (by sending index, the new value, and a value to compare to the row in list (if it match, it replace)).
        (new ConcurrentDictionary<int, string>()).TryRemove(0, out getFamilyName); // take element from list (return bool isValid, afect param and drop from list).
        bool isCompleted = bc.IsCompleted; // return a bool, if is full.
        bc.CompleteAdding(); // mark the list is lock (no more add can be alow).
        bc.GetConsumingEnumerable(); // return the list of elements (for loop on it, for example).

        //ls2.AddRange(new string[] { "aaa", "bbb" }); // example of push many.
        //stackStr.Pop(); // return and drop the last element.


    }
}