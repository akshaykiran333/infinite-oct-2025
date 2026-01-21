Create procedure GetCustomersByCountry
    @Country NVARCHAR(50)
As
Begin
    Select * From Customers Where Country = @Country
End

EXEC GetCustomersByCountry 'USA'