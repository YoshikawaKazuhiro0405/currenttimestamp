Module Module1

    Function dt2unepocht(ByVal vbdate As DateTime) As Long
        ''VBで使用出来る日付を入力すると、UNIX エポック秒に変換する
        vbdate = vbdate.ToUniversalTime()

        Dim dt1 As New DateTime(1970, 1, 1, 0, 0, 0, 0)
        Dim elapsedTime As TimeSpan = vbdate - dt1

        Return CType(elapsedTime.TotalSeconds, Long)

    End Function

End Module
