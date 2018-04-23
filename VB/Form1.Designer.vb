Namespace StandaloneQueryBuilderSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.fillButton = New DevExpress.XtraEditors.SimpleButton()
            Me.runQBButton = New DevExpress.XtraEditors.SimpleButton()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.cbHidePreview = New System.Windows.Forms.CheckBox()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.cbHidePreview)
            Me.layoutControl1.Controls.Add(Me.fillButton)
            Me.layoutControl1.Controls.Add(Me.runQBButton)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(626, 205, 727, 596)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(732, 493)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' fillButton
            ' 
            Me.fillButton.Location = New System.Drawing.Point(360, 435)
            Me.fillButton.Name = "fillButton"
            Me.fillButton.Size = New System.Drawing.Size(360, 22)
            Me.fillButton.StyleController = Me.layoutControl1
            Me.fillButton.TabIndex = 6
            Me.fillButton.Text = "Fill"
            ' 
            ' runQBButton
            ' 
            Me.runQBButton.Location = New System.Drawing.Point(12, 435)
            Me.runQBButton.Name = "runQBButton"
            Me.runQBButton.Size = New System.Drawing.Size(344, 22)
            Me.runQBButton.StyleController = Me.layoutControl1
            Me.runQBButton.TabIndex = 5
            Me.runQBButton.Text = "Run Query Builder..."
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Location = New System.Drawing.Point(12, 12)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(708, 419)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(732, 493)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(712, 423)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.runQBButton
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 423)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(348, 26)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.fillButton
            Me.layoutControlItem3.Location = New System.Drawing.Point(348, 423)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(364, 26)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "CategoryID"
            table1.Name = "Categories"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CategoryName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Description"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Picture"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Name = "Categories"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' cbHidePreview
            ' 
            Me.cbHidePreview.Location = New System.Drawing.Point(12, 461)
            Me.cbHidePreview.Name = "cbHidePreview"
            Me.cbHidePreview.Size = New System.Drawing.Size(708, 20)
            Me.cbHidePreview.TabIndex = 7
            Me.cbHidePreview.Text = "Hide Preview"
            Me.cbHidePreview.UseVisualStyleBackColor = True
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbHidePreview
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 449)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(712, 24)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(732, 493)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private WithEvents fillButton As DevExpress.XtraEditors.SimpleButton
        Private WithEvents runQBButton As DevExpress.XtraEditors.SimpleButton
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private cbHidePreview As System.Windows.Forms.CheckBox
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

