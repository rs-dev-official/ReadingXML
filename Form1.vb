Public Class Form1

   
    Private Sub ReadXmlButton_Click(sender As System.Object, e As System.EventArgs) Handles ReadXmlButton.Click
        AuthorsDataSet.Clear()
        Dim filePath As String = Application.StartupPath & "\authors.xml"
        AuthorsDataSet.ReadXml(filePath)
        DataGridView1.DataSource = AuthorsDataSet
        DataGridView1.DataMember = "authors"
    End Sub

    Private Sub ShowSchemaButton_Click(sender As System.Object, e As System.EventArgs) Handles ShowSchemaButton.Click
        Dim swXML As New System.IO.StringWriter()
        AuthorsDataSet.WriteXmlSchema(swXML)
        TextBox1.Text = swXML.ToString
    End Sub
End Class
