Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\LoginDB.accdb")
Dim command As New OleDbCommand("INSERT INTO [Users] ([Username], [Password], [Email]) VALUES (@Username, @Password, @Email)", connection)
command.Parameters.AddWithValue("@Username", TextBox1.Text)
command.Parameters.AddWithValue("@Password", TextBox2.Text)
command.Parameters.AddWithValue("@Email", TextBox3.Text)
connection.Open()
Dim rowsAffected As Integer = command.ExecuteNonQuery()
connection.Close()
MessageBox.Show(rowsAffected & " rows inserted.")
