' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Public Class Service1
    Implements IService1

    Public Sub New()
    End Sub

    Public Function HelloWorld() As String Implements IService1.HelloWorld
        Return "Hello WCF Service"
    End Function

    Public Function GetUserObject(ByVal pUserCode As String) As WCFUser Implements IService1.GetUserObject
        Try
            Return New WCFUser With {.UserCode = "xxxx", .FirstName = ".NET Develper", .LastName = "WCF Service", .Age = 27, .IsActive = True}
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetAllUser() As List(Of WCFUser) Implements IService1.GetAllUser
        Try
            Dim objUser As WCFUser
            Dim ListUser As New List(Of WCFUser)


            objUser = New WCFUser
            objUser.FirstName = "Sompetch"
            objUser.LastName = "Chanhom"
            objUser.Age = 27
            objUser.IsActive = True
            ListUser.Add(objUser)



            objUser = New WCFUser
            objUser.FirstName = "Tankhun"
            objUser.LastName = "Chanhom"
            objUser.Age = 2
            objUser.IsActive = True
            ListUser.Add(objUser)


            objUser = New WCFUser
            objUser.FirstName = "Thanongsak"
            objUser.LastName = "Chanhom"
            objUser.Age = 30
            objUser.IsActive = True
            ListUser.Add(objUser)

            Return ListUser
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
