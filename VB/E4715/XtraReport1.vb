Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace E4715
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private GroupHeader1 As GroupHeaderBand
		Private xrLabel1 As XRLabel
		Private xrLabel3 As XRLabel
		Private xrLabel2 As XRLabel
		Private GroupHeader2 As GroupHeaderBand
		Private topMarginBand1 As TopMarginBand
		Private bottomMarginBand1 As BottomMarginBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		Public Sub New()
			InitializeComponent()
			'
			' TODO: Add constructor logic here
			'
		End Sub

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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
'INSTANT VB NOTE: The variable resources was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
			Dim resources_Conflict As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Dpi = 100F
			Me.Detail.HeightF = 0F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.GroupHeader1.Dpi = 100F
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.HeightF = 25F
			Me.GroupHeader1.Level = 1
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.Turquoise
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Product Sales for 1997.CategoryName")})
			Me.xrLabel1.Dpi = 100F
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(100F, 25F)
			Me.xrLabel1.StylePriority.UseBackColor = False
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Product Sales for 1997.ProductName")})
			Me.xrLabel2.Dpi = 100F
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(50F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(333F, 25F)
			' 
			' xrLabel3
			' 
			Me.xrLabel3.BackColor = System.Drawing.Color.Turquoise
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Product Sales for 1997.ProductSales")})
			Me.xrLabel3.Dpi = 100F
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(400F, 0F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(142F, 25F)
			Me.xrLabel3.StylePriority.UseBackColor = False
			xrSummary1.FormatString = "{0:#.00}"
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
			Me.xrLabel3.Summary = xrSummary1
			' 
			' GroupHeader2
			' 
			Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel2})
			Me.GroupHeader2.Dpi = 100F
			Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader2.HeightF = 25F
			Me.GroupHeader2.Name = "GroupHeader2"
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Dpi = 100F
			Me.topMarginBand1.HeightF = 100F
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Dpi = 100F
			Me.bottomMarginBand1.HeightF = 100F
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "E4715.Properties.Settings.NorthwindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "CategoryName"
			table1.Name = "Product Sales for 1997"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "ProductName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "ProductSales"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Name = "Product Sales for 1997"
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources_Conflict.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.GroupHeader1, Me.GroupHeader2, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Product Sales for 1997"
			Me.DataSource = Me.sqlDataSource1
			Me.Version = "16.1"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region
	End Class

End Namespace
