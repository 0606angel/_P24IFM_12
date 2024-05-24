Option Strict On
Option Infer Off
Option Explicit On


Public Class Form1

    Private Structure ransomware_rec
        Public ransomware_name As String
        Public ransomware_paid_per_incidents() As Integer
        Public total_ransomware_paid As Integer
    End Structure

    Private Structure month_rec
        Public month_name As String
        Public total_incidents_of_cyberattack As Integer
        Public ransom_info() As ransomware_rec
        Public average As Double
        Public impact As String
    End Structure

    Private monthly_info() As month_rec


    Private Sub set_grid()

        ' Ask user for the number of months, ransomware, and incidents
        Dim Month_input As Integer = CInt(InputBox("Enter the number of months"))
        Dim ransomware_input As Integer = CInt(InputBox("Enter the number of ransomware"))
        Dim incidence As Integer = CInt(InputBox("Enter the number of incidents"))

        ReDim monthly_info(Month_input - 1)

        For i As Integer = 0 To Month_input - 1
            ReDim monthly_info(i).ransom_info(ransomware_input - 1)
            For r As Integer = 0 To ransomware_input - 1
                ReDim monthly_info(i).ransom_info(r).ransomware_paid_per_incidents(incidence - 1)
            Next
        Next

        grd_ransomware.Rows = Month_input + 1
        grd_ransomware.Cols = ransomware_input + 4

        For i As Integer = 1 To Month_input
            grd_ransomware.Row = i
            grd_ransomware.Col = 0
            grd_ransomware.Text = "Month " + CStr(i)
        Next

        For r As Integer = 1 To ransomware_input
            grd_ransomware.Row = 0
            grd_ransomware.Col = r
            grd_ransomware.Text = "Ransomware " + CStr(r)
        Next

        grd_ransomware.Row = 0
        grd_ransomware.Col = ransomware_input + 1
        grd_ransomware.Text = "total"

        grd_ransomware.Row = 0
        grd_ransomware.Col = ransomware_input + 2
        grd_ransomware.Text = "average"

        grd_ransomware.Row = 0
        grd_ransomware.Col = ransomware_input + 3
        grd_ransomware.Text = "impact"

    End Sub


    Private Sub btn_month_and_ransomware_Click(sender As Object, e As EventArgs) Handles btn_month_and_ransomware.Click

        set_grid()

    End Sub

    Private Sub btn_month_and_incidents_Click(sender As Object, e As EventArgs) Handles btn_month_and_incidents.Click

        For i As Integer = 0 To monthly_info.Length - 1

            Dim month_name_input As String = InputBox("Enter the name of the month")

            If month_name_input <> "" Then
                monthly_info(i).month_name = month_name_input

            End If

            Dim total_incidents_input As Integer = CInt(InputBox("Enter the total incidents of cyberattacks"))

            If CStr(total_incidents_input) <> "" Then
                monthly_info(i).total_incidents_of_cyberattack = total_incidents_input
            End If

        Next
        update_grid()
    End Sub

    Private Sub update_grid()
        For i As Integer = 0 To monthly_info.Length - 1

            grd_ransomware.Row = i + 1
            grd_ransomware.Col = 0
            grd_ransomware.Text = monthly_info(i).month_name

            For m As Integer = 0 To monthly_info(i).ransom_info.Length - 1

                grd_ransomware.Row = 0
                grd_ransomware.Col = m + 1
                grd_ransomware.Text = monthly_info(i).ransom_info(m).ransomware_name


                For r As Integer = 0 To monthly_info(i).ransom_info(m).ransomware_paid_per_incidents.Length - 1
                    grd_ransomware.Row = i + 1 ' Update row index
                    grd_ransomware.Col = m + 1 ' Update column index
                    grd_ransomware.Text = CStr(monthly_info(i).ransom_info(m).ransomware_paid_per_incidents(r))

                Next

            Next
        Next

        For i As Integer = 0 To monthly_info.Length - 1
            For b As Integer = 0 To monthly_info(i).ransom_info.Length - 1
                grd_ransomware.Col = monthly_info(i).ransom_info.Length + 1
                grd_ransomware.Row = i + 1
                grd_ransomware.Text = CStr(monthly_info(i).ransom_info(b).total_ransomware_paid)

            Next
        Next

        For i As Integer = 0 To monthly_info.Length - 1
            For c As Integer = 0 To monthly_info(i).ransom_info.Length - 1
                grd_ransomware.Row = i + 2
                grd_ransomware.Col = monthly_info(i).ransom_info.Length + 1
                grd_ransomware.Text = CStr(monthly_info(i).average)


            Next

        Next


    End Sub

    Private Sub btn_register_ransomware_info_Click(sender As Object, e As EventArgs) Handles btn_register_ransomware_info.Click
        For i As Integer = 0 To monthly_info.Length - 1

            For m As Integer = 0 To monthly_info(i).ransom_info.Length - 1
                Dim ransomware_name_input As String = InputBox("Enter the name of the ransomware")

                If ransomware_name_input <> "" Then
                    monthly_info(i).ransom_info(m).ransomware_name = ransomware_name_input
                End If

                For r As Integer = 0 To monthly_info(i).ransom_info(m).ransomware_paid_per_incidents.Length - 1
                    Dim ransomware_paid_input As Integer = CInt(InputBox("Enter the ransomware paid per incidents"))
                    If CStr(ransomware_paid_input) <> "" Then
                        monthly_info(i).ransom_info(m).ransomware_paid_per_incidents(r) = ransomware_paid_input

                    End If

                Next

            Next

        Next

        update_grid()
    End Sub

    Private Sub btn_calc_total_Click(sender As Object, e As EventArgs) Handles btn_calc_total.Click
        Dim total As Integer = 0

        For t As Integer = 0 To monthly_info.Length - 1
            For m As Integer = 0 To monthly_info(t).ransom_info.Length - 1
                total = monthly_info(t).ransom_info(m).ransomware_paid_per_incidents.Sum
                monthly_info(t).ransom_info(m).total_ransomware_paid = total

            Next




        Next
        update_grid()


    End Sub

    Private Function calc_sum(ByVal sum_array() As Integer) As Integer
        Dim sum As Integer = 0


        For t As Integer = 0 To sum_array.Length - 1
            sum = sum + sum_array(t)




        Next
        Return sum


    End Function

    Private Sub btn_calc_average_Click(sender As Object, e As EventArgs) Handles btn_calc_average.Click

        Dim average As Double = 0
        For j As Integer = 0 To monthly_info.Length - 1
            For h As Integer = 0 To monthly_info(j).ransom_info.Length - 1
                average = calc_ave(monthly_info(j).ransom_info(h).ransomware_paid_per_incidents)

                monthly_info(j).average = average
            Next


        Next
        update_grid()


    End Sub

    Private Function calc_ave(ByVal ave_array() As Integer) As Double

        Dim total As Integer = calc_sum(ave_array)


        For i As Double = 0 To ave_array.Length - 1

            Return total / ave_array.Length - 1
        Next
    End Function
End Class
