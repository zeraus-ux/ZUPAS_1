Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module ServerServices


#Region "GET-POST (sync)"

    Public Function GetSJson(ByVal URL As String) As JObject

        Dim _ResponseString As String
        Dim _Error As String = Nothing
        Dim webClient As New System.Net.WebClient

        Try
            _ResponseString = webClient.DownloadString(URL)
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

        If _ResponseString IsNot Nothing Then
            Dim _Json As JObject
            Dim _Result As Boolean

            _Json = JObject.Parse(_ResponseString)
            _Result = _Json("Result")
            If _Result Then
                Return _Json
            Else

                Dim _Message As String = ""
                _Message += String.Format("URL: {0}", URL) & vbCrLf
                _Message += GetIndentedText(String.Format("Message: {0}", _Json("Message")))

                MessageBox.Show(_Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

               '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------
                'Return
               '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------

                Return Nothing
            End If

        Else


            Dim _Message As String = ""
            _Message += String.Format("URL: {0}", URL) & vbCrLf
            _Message += GetIndentedText(String.Format("Message: {0}", _Error))

            MessageBox.Show(_Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

           '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------
            'Return
           '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------

            Return Nothing
        End If
        Return Nothing
    End Function

    Public Function GetSJson(ByVal URL As String, ByVal SJsonValues As JObject) As JObject


        Dim response As JObject = Nothing
        Dim _Error As String = Nothing
        Dim _stringJson As String
        Dim webClient As New System.Net.WebClient
        Dim _Result As Boolean

        'Test---------------------------------------------------------------------
        '_stringJson = JsonConvert.SerializeObject(SJsonValues)
        'webClient.Headers("Content-Type") = "application/json"
        'Dim responseBytes As Byte() = webClient.UploadData(URL, "POST", Encoding.UTF8.GetBytes(_stringJson))
        'Dim responseJson As String = Encoding.UTF8.GetString(responseBytes)
        'response = JsonConvert.DeserializeObject(Of JObject)(responseJson)
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-----


        Try
            _stringJson = JsonConvert.SerializeObject(SJsonValues)
            webClient.Headers("Content-Type") = "application/json"

            Dim responseBytes As Byte() = webClient.UploadData(URL, "POST", Encoding.UTF8.GetBytes(_stringJson))
            Dim responseJson As String = Encoding.UTF8.GetString(responseBytes)
            response = JsonConvert.DeserializeObject(Of JObject)(responseJson)

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try


        If response IsNot Nothing Then

            _Result = response("Result")

            If _Result Then
                Return response
            Else

                Dim _Message As String = ""
                '_Message += String.Format("URL: {0}", URL) & vbCrLf
                '_Message += GetIndentedText(String.Format("Message: {0}", response("Message")))
                _Message += String.Format("Message: {0}", response("Message"))

                MessageBox.Show(_Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

               '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------
                'Return
               '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------

                Return Nothing
            End If

        Else
           '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------
            'Option 2
           '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~---------------------------------

            Dim _Message As String = ""
            _Message += String.Format("URL: {0}", URL) & vbCrLf
            _Message += GetIndentedText(String.Format("Message: {0}", _Error))

            MessageBox.Show(_Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing

        End If


    End Function

#End Region


    Public Function Login(ByVal UserName As String, ByVal Password As String) As Boolean

        'Test----------------------------------------
        Return True
       '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-----------------------------

        Dim _URL As String = String.Format("{0}/UPAZ/Loging", My.Settings.URLBase)
        Dim _JObject As New JObject()
        _JObject("UserName") = UserName
        _JObject("Password") = Password

        Dim _JObject1 As JObject = GetSJson(_URL, _JObject)
        If _JObject1 Is Nothing Then
            Return False
        Else
            Return _JObject1("Data")
        End If
    End Function




End Module
