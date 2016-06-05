Module Moddatagridview

    Public Sub InitDataGridViewAxisPar(ByRef DataGridViewAxisPar As DataGridView)
        '设置行表头和列表头
        DataGridViewAxisPar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter      '设置列头内容居中
        DataGridViewAxisPar.ColumnHeadersDefaultCellStyle.Font = New Font("微软雅黑", 10, FontStyle.Bold)            '设置表头字体大小 
        DataGridViewAxisPar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing    '设备列表头高度自动调整为非自动
        DataGridViewAxisPar.ColumnHeadersHeight = 50                                                                 '设备列表头高度值 
        DataGridViewAxisPar.RowHeadersVisible = False                                                                '设置行表头不显示

        DataGridViewAxisPar.ReadOnly = True                                                                            '只读模式

        '此DefaultCellStyle要生效,是不能设置其它单无格格式的
        DataGridViewAxisPar.DefaultCellStyle.Font = New Font("微软雅黑", "9")                                        '设置默认单元格字体大小 
        DataGridViewAxisPar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter                   '设置单无格内容居中显示

        '设置列宽和行高的自动填充模式
        DataGridViewAxisPar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader                      '设置列宽根据列头的宽度
        DataGridViewAxisPar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

        DataGridViewAxisPar.RowTemplate.Height = 30                                                                 '设置行高

        '是否允许用户手动添加行和列
        DataGridViewAxisPar.AllowUserToAddRows = False                                                               '不允许用户增加行
        DataGridViewAxisPar.AllowUserToDeleteRows = False                                                            '不允许用户删除行
        DataGridViewAxisPar.AllowUserToResizeRows = False                                                              '不允许用户拖动修改行高

        '不让用户手动对其排序
        If DataGridViewAxisPar.ColumnCount > 0 Then
            For i = 0 To DataGridViewAxisPar.ColumnCount - 1
                DataGridViewAxisPar.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable                     '设置单元格不进行手动点击排序
            Next
        End If

        '进行排序
        If DataGridViewAxisPar.ColumnCount > 0 Then
            DataGridViewAxisPar.Sort(DataGridViewAxisPar.Columns(0), System.ComponentModel.ListSortDirection.Ascending)  '按第一列进行排序,升序排序
        End If
    End Sub
End Module
