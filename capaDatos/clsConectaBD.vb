Imports System.Data
Imports System.Data.SqlClient

Public Class clsConectaBD
    Private cn As SqlConnection

    Sub New()
        cn = New SqlConnection()
        cn.ConnectionString = "workstation id=BDDistribuidos_4.mssql.somee.com;packet size=4096;user id=giankarlo6077_SQLLogin_4;pwd=bprg6leldj;data source=BDDistribuidos_4.mssql.somee.com;persist security info=False;initial catalog=BDDistribuidos_4;TrustServerCertificate=True;language=spanish"
    End Sub

    Public Sub conectar()
        Try
            If cn.State = Data.ConnectionState.Closed Then
                cn.Open()
            End If
        Catch ex As Exception
            Throw New Exception("Error al conectar a BD")
        End Try
    End Sub

    Public Sub desconectar()
        Try
            If cn.State <> Data.ConnectionState.Closed Then
                cn.Close()
            End If
        Catch ex As Exception
            Throw New Exception("Error al desconectar a BD")
        End Try
    End Sub

    Public ReadOnly Property estadoCN() As String
        Get
            If cn.State = Data.ConnectionState.Open Then
                Return "BD está abierta."
            Else
                Return "BD está cerrada."
            End If
        End Get
    End Property

    Public ReadOnly Property miConexion() As SqlConnection
        Get
            Return cn
        End Get
    End Property

    Public ReadOnly Property Servidor() As String
        Get
            Return cn.DataSource.ToString
        End Get
    End Property

    Public Sub abrirconexion()
        Try
            If cn.State <> Data.ConnectionState.Open Then
                cn.Open()
            End If
        Catch Ex As Exception
            Err.Raise(Err.Number, Err.Source, Err.Description)
        End Try
    End Sub

    Public Sub cerrarconexion()
        Try
            If cn.State = Data.ConnectionState.Open Then
                cn.Close()
                cn.Dispose()
            End If
        Catch Ex As Exception
            Err.Raise(Err.Number, Err.Source, Err.Description)
        End Try
    End Sub

    Public Sub abrirconexionTrans()
        'Try
        '    If transaccion <> True Then
        '        abrirconexion()
        '        tsql = cn.BeginTransaction()
        '        transaccion = True
        '    End If
        'Catch ex As Exception
        '    Err.Raise(Err.Number, Err.Source, Err.Description)
        'End Try
    End Sub

    Public Sub cerrarconexionTrans()
        'Try
        '    If transaccion = True Then
        '        tsql.Commit()
        '        cerrarconexion()
        '        transaccion = False
        '    End If
        'Catch ex As Exception
        '    Err.Raise(Err.Number, Err.Source, Err.Description)
        'End Try
    End Sub

    Public Sub cancelarconexionTrans()
        'Try
        '    If transaccion = True Then
        '        tsql.Rollback()
        '        cerrarconexion()
        '        transaccion = False
        '    End If
        'Catch ex As Exception
        '    Err.Raise(Err.Number, Err.Source, Err.Description)
        'End Try
    End Sub

    Public Function consultarBD(ByVal strSQL As String) As DataTable
        Dim dt As New DataTable()
        Try
            conectar()
            Dim cmd As New SqlCommand(strSQL, cn)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al ejecutar consulta -> " & ex.Message)
        Finally
            desconectar()
        End Try
    End Function

    Public Sub ejecutarBD(ByVal strSQL As String)
        Try
            conectar()
            Dim cmd As New SqlCommand(strSQL, cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al ejecutar BD -> " & ex.Message)
        Finally
            desconectar()
        End Try
    End Sub

    Public Sub ejecutarBDTransacciones(ByVal str() As String)
        If str.Length < 1 Then Return
        Dim tran As SqlTransaction = Nothing
        Try
            conectar()
            tran = cn.BeginTransaction()
            For i As Integer = 0 To str.Length - 1
                Dim cmd As New SqlCommand(str(i), cn, tran)
                cmd.ExecuteNonQuery()
            Next
            tran.Commit()
        Catch ex As Exception
            If tran IsNot Nothing Then tran.Rollback()
            Throw New Exception("Error al ejecutar Transaccion " & ex.Message)
        Finally
            desconectar()
        End Try
    End Sub

End Class