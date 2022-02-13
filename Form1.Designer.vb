<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ReadXmlButton = New System.Windows.Forms.Button()
        Me.ShowSchemaButton = New System.Windows.Forms.Button()
        Me.AuthorsDataSet = New System.Data.DataSet()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Location = New System.Drawing.Point(23, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(543, 312)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 343)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(451, 52)
        Me.TextBox1.TabIndex = 1
        '
        'ReadXmlButton
        '
        Me.ReadXmlButton.Location = New System.Drawing.Point(480, 343)
        Me.ReadXmlButton.Name = "ReadXmlButton"
        Me.ReadXmlButton.Size = New System.Drawing.Size(86, 23)
        Me.ReadXmlButton.TabIndex = 2
        Me.ReadXmlButton.Text = "Read XML"
        Me.ReadXmlButton.UseVisualStyleBackColor = True
        '
        'ShowSchemaButton
        '
        Me.ShowSchemaButton.Location = New System.Drawing.Point(480, 372)
        Me.ShowSchemaButton.Name = "ShowSchemaButton"
        Me.ShowSchemaButton.Size = New System.Drawing.Size(86, 23)
        Me.ShowSchemaButton.TabIndex = 3
        Me.ShowSchemaButton.Text = "Show Schema"
        Me.ShowSchemaButton.UseVisualStyleBackColor = True
        '
        'AuthorsDataSet
        '
        Me.AuthorsDataSet.DataSetName = "AuthorsDataSet"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 419)
        Me.Controls.Add(Me.ShowSchemaButton)
        Me.Controls.Add(Me.ReadXmlButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ReadXmlButton As System.Windows.Forms.Button
    Friend WithEvents ShowSchemaButton As System.Windows.Forms.Button
    Friend WithEvents AuthorsDataSet As System.Data.DataSet

End Class
