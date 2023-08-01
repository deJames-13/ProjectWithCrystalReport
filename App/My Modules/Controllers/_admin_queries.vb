Module _admin_queries
    Dim query As String = ""
    Dim values As String = ""
    Dim msg As String = ""
    Public orders_query As String = $"
    SELECT 
    o.id,
    ohp.status as 'Status',
    CONCAT(c.first_name,' ',c.last_name) as 'Ordered By',
    p.item_name as 'Item Name',
    ohp.quantity as 'Quantity',
    ohp.cost as 'Total Cost',
    c.address as 'Shipping Address',
    o.ship_date as 'Shipping Date'
    FROM order_has_product as ohp
    INNER JOIN product as p
    ON ohp.product_id = p.id
    INNER JOIN `order` as o
    ON ohp.order_id = o.id
    INNER JOIN customer as c
    ON o.customer_id = c.id
    ;
    "

    '
    ' FILTERS and SELECT QUERIES
    '
    Public Sub SortGrid()

    End Sub

    '
    ' SET ORDER STATUS
    '
    Public Sub SetOrderStatus(id As Integer, status As String)
        query = $"
        UPDATE `order_has_product` SET
        status = ""{status}""
        WHERE order_id = {id};
        "
        ExecuteQuery(query)
    End Sub


    '
    ' HANDLES Admin Queries
    '
    Public Function AdminTransactions(data As Dictionary(Of String, Object)) As Integer
        '
        '  DATA dictionary should have
        '  (0) - Action
        '  (1) - User Data Dict Object
        '
        If Not data.Keys.Contains("action") Then Return 0

        query = ""

        Select Case data("action")
            '
            ' QUERY FOR CREATING NEW ITEM
            '
            Case "new_item"
                values = GetValues(data("item"))
                query &= $"
                INSERT INTO product SET
                {values},
                created_at = NOW(),
                created_by = ""dev"",
                last_modified_at = NOW(),
                last_modified_by = ""dev""
                ;
                "

                msg = "Item Added Successfully!"

            Case "update_item"
                values = GetValues(data("item"))

                query &= $"
                UPDATE product SET
                {values},
                last_modified_at = NOW(),
                last_modified_by = ""dev""
                WHERE id = {data("id")};
                "


                msg = "Item Updated Successfully!"

            Case "delete_item"

                query &= $"
                DELETE FROM order_has_product WHERE  product_id = {data("id")};
                DELETE FROM cart WHERE product_id = {data("id")};
                DELETE FROM product WHERE id = {data("id")};
                "

                msg = "Item Deleted Successfully!"


            '
            ' Query FOR CREATING NEW USER
            ' 
            ' USER DATA dictionary should have
            ' (0) - User Data Dict Object
            ' (1) - User Pass 
            Case "new_user"
                values = GetValues(data("user"))
                query &= $"
                INSERT INTO user SET 
                {values},
                created_at = NOW()
                ;
                INSERT INTO login
                SET 
                id = {data("user")("id")},
                username = ""{data("user")("username")}"",
                password = ""{data("password")}"";
                ;
                "
                msg = "User Created Successfully!"

            '
            ' Query for Updating User Info
            '
            Case "update_user"
                values = GetValues(data("user"))
                query &= $"
                UPDATE user SET {values} WHERE id = {data("id")};    
                UPDATE login SET username = ""{data("user")("username")}"", password = ""{data("password")}"" WHERE id = {data("id")};
                "
                msg = "User Info Updated Successfully!"
            '
            ' Query for Deleting User
            '
            Case "delete_user"
                query &= $"
                DELETE FROM user_has_schedule WHERE user_id = {data("id")};
                DELETE FROM user_has_salary WHERE user_id = {data("id")};
                DELETE FROM login WHERE id = {data("id")};
                DELETE FROM user WHERE id = {data("id")};   
                "
                msg = "User Deleted Successfully!"

        End Select

        MsgBox(query)

        '
        ' Executes Non Query with transactions auto commit
        '
        Try
            ExecuteNonQuery(query)

            MsgBox(msg, MsgBoxStyle.Information, "Action Success")
        Catch ex As Exception
            msg = ex.Message
            If ex.Message.Contains("You have an error in your SQL syntax") Then
                msg = "Invalid Input Detected!"
            End If

            MsgBox(msg, MsgBoxStyle.Exclamation, "Application Error")
            Return -1
        End Try
        Return 1
    End Function


    '
    ' Provides Employee info in String
    '
    Private Function GetValues(data As Dictionary(Of String, Object)) As String
        Dim values As String = ""
        For Each key In data.Keys
            If key = "created_at" Then Continue For
            values &= $"{key}=""{data(key).ToString.Replace("""", """""")}"","
        Next
        values = values.TrimEnd(",")

        Return values
    End Function



End Module
