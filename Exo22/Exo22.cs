
public class Exo22 : Exo
{
    /// <summary>
    /// conection DB.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        /*/ --- Sql obj not found ---
        string conection = (
            "Data Source=MyServor" +
            "Initial Calatog=MyDB" +
            "User Id=MyIdUser" +
            "Password=MyPassword"
        );

        using (SqlConnection sqlCon = new SqlConnection(conection))
        {
            sqlCon.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Movie", sqlCon))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"id: {reader.GetInt32(0)}");
                        Console.WriteLine($"name: {reader.GetString(1)}");
                        Console.WriteLine($"age: {reader.GetInt32(2)}");
                    }
                }
            }
        }
        //*/
    }
}