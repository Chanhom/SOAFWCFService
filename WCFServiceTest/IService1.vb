' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract(Namespace:="http://Microsoft.ServiceModel.WCFServiceTest")>
Public Interface IService1
    <OperationContract()>
    Function HelloWorld() As String


    <OperationContract()>
    Function GetUserObject(ByVal pUserCode As String) As WCFUser

    <OperationContract()>
    Function GetAllUser() As List(Of WCFUser)
    ' TODO: Add your service operations here

End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.



<DataContract()>
Public Class WCFUser
    <DataMember()>
    Public Property UserCode As String
    <DataMember()>
    Public Property FirstName As String
    <DataMember()>
    Public Property LastName As String
    <DataMember()>
    Public Property Age As Integer
    <DataMember()>
    Public Property IsActive As Boolean

End Class
