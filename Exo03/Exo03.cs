using System.Text.RegularExpressions;

public class Exo03 : Exo
{
    /// <summary>
    /// read.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {

        // open folder and get files info.
        const string pathFolder = "Exo03";
        const string extantion = "txt";
        DirectoryInfo folder = new DirectoryInfo(pathFolder); //TODO: try catch for open folder and get files.
        String[] files = folder.GetFiles("*.txt").Select(f => Regex.Replace(f.Name, ".txt$", "")).ToArray();

        // print files names.
        Console.WriteLine("--- files ---");
        foreach (var file in files)
        {
            Console.WriteLine($" - {file}");
        }
        Console.WriteLine("-------------");

        // ask user to prompt a name.
        Console.WriteLine("choose a file name to open.");
        string fileChoose = "";
        while (!files.Contains(fileChoose))
        {
            fileChoose = Console.ReadLine() ?? "";
        }

        // read the file.
        string pathFileToRead = $"{pathFolder}/{fileChoose}.{extantion}";
        using (StreamReader sr = File.OpenText(pathFileToRead)) //TODO: catch excepion on open text.
        {
            string? s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }


        // example for create file.
        //var myFile = File.Create(path);
        //File.Exists(path); // check if exit.
        //File.Delete(path); // delete a file.
        //File.Move(pathFrom, pathTo); // move file.
        //myFile.MoveTo(pathTo); // move a file (call from a file instance).

        // example for create directory.
        //DirectoryInfo myDirectory = Directory.CreateDirectory(path);
        //Directory.Exists(path); // check if exit.
        //Directory.Delete(path); // delete a directory.
        //Directory.Move(pathFrom, pathTo); // move a directory.
        //myDirectory.MoveTo(pathTo); // move a directory (call from a directory instance).

        // example path.
        //string pathString = Path.Combine("C:\\User\\Documents", "myFile.txt"); // combine a path.
        //Console.WriteLine(Path.GetPathRoot(pathString)); // get root directory. -> "C:\\"
        //Console.WriteLine(Path.GetDirectoryName(pathString)); // get folder from string path. -> "C:\\User\\Documents"
        //Console.WriteLine(Path.GetFileName(pathString)); // get file name from a string path. -> "myFile.txt"
        //Console.WriteLine(Path.GetExtension(pathString)); // get extantion from string path. -> ".txt"

    }
}