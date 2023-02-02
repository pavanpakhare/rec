Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\LoginDB.accdb")
Dim command As New OleDbCommand("SELECT [Username], [Email] FROM [Users]", connection)
connection.Open()
Dim reader As OleDbDataReader = command.ExecuteReader()
While reader.Read()
   Console.WriteLine("Username: " & reader("Username").ToString() & ", Email: " & reader("Email").ToString())
End While
reader.Close()
connection.Close()
