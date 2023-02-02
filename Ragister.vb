Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
   Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\LoginDB.accdb")
   Dim command As New OleDbCommand("INSERT INTO [Users] ([Username], [Password], [Email]) VALUES (@Username, @Password, @Email)", connection)
   command.Parameters.AddWithValue("@Username", TextBox1.Text)
   command.Parameters.AddWithValue("@Password", TextBox2.Text)
   command.Parameters.AddWithValue("@Email", TextBox3.Text)
   connection.Open()
   command.ExecuteNonQuery()
   connection.Close()
   MessageBox.Show("Registration Successful")
End Sub
