Imports System.Threading

Public Class ThreadTimer
#Region "私有变量"
    Private _iInterval As Integer
    Private _tThread As New Thread(New ThreadStart(AddressOf StartProcess))
#End Region

#Region "属性"
    ''' <summary>
    ''' 设置时间
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property iInterval() As Integer
        Get
            Return _iInterval
        End Get
        Set(value As Integer)
            _iInterval = value
        End Set
    End Property 
#End Region

#Region "事件"
    ''' <summary>
    ''' 异常数据
    ''' </summary>
    ''' <param name="ex"></param>
    ''' <remarks></remarks>
    Public Event Exception(ByVal ex As Exception)
#End Region

#Region "方法"
    ''' <summary>
    ''' 构造函数：给属性赋初值
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.iInterval = 10
    End Sub

    Public Sub StartTimer()
        Try 
            _tThread.Start()
        Catch ex As Exception
            RaiseEvent Exception(ex)
        End Try
    End Sub

    Public Sub StopTimer()
        Try 
            _tThread.Abort()
            _tThread = Nothing
        Catch ex As Exception
            RaiseEvent Exception(ex)
        End Try
    End Sub

    Private Sub StartProcess()

    End Sub
#End Region
End Class
