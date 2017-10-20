Imports System.IO
Imports System.IO.Compression
Imports System.Security.Cryptography
Imports System.Text
Imports System.Xml.Serialization

Public Class CrSubtitleDecrypt

    Public Shared Function Decrypt(ByVal id As Integer, ByVal iv As String, ByVal data As String) As Byte()
        Dim _loc_5 As Byte() = _GenerateKey(id)
        Dim _loc_6 As Rijndael = Rijndael.Create()
        _loc_6.BlockSize = 128
        _loc_6.KeySize = 128
        _loc_6.Mode = CipherMode.CBC
        _loc_6.Padding = PaddingMode.None
        Using ms1 As New MemoryStream
            Using ms2 As New MemoryStream
                Using streamDescriptografada As New CryptoStream(New MemoryStream(Convert.FromBase64String(data)), _loc_6.CreateDecryptor(_loc_5, Convert.FromBase64String(iv)), CryptoStreamMode.Read)
                    streamDescriptografada.CopyTo(ms1)
                End Using
                ms1.Position = 0
                ms1.ReadByte()
                ms1.ReadByte()
                Using streamdescompactada As New DeflateStream(ms1, CompressionMode.Decompress)
                    streamdescompactada.CopyTo(ms2)
                End Using
                ms2.Position = 0
                Return ms2.ToArray
            End Using
        End Using
    End Function

    Public Shared Function ConvertToAss(ByVal input As Byte()) As Byte()
        Dim xml As New XmlSerializer(GetType(subtitle_script))
        Dim classxml As subtitle_script = CTypeDynamic(Of subtitle_script)(xml.Deserialize(New MemoryStream(input)))
        Dim header As String = String.Format("[Script Info]{4}Title: {0}{4}ScriptType: v4.00+{4}WrapStyle: {1}{4}PlayResX: {2}{4}PlayResY: {3}{4}{4}", classxml.title, classxml.wrap_style, classxml.play_res_x, classxml.play_res_y, vbCr)
        Dim styles As String = "[V4+ Styles]" + vbCr + "Format: Name, Fontname, Fontsize, PrimaryColour, SecondaryColour, OutlineColour, BackColour, Bold, Italic, Underline, StrikeOut, ScaleX, ScaleY, Spacing, Angle, BorderStyle, Outline, Shadow, Alignment, MarginL, MarginR, MarginV, Encoding" + vbCr
        Dim events As String = vbCr + "[Events]" + vbCr + "Format: Layer, Start, End, Style, Name, MarginL, MarginR, MarginV, Effect, Text" + vbCr
        For Each style As subtitle_scriptStyle In classxml.styles
            If style.scale_x = 0 Or style.scale_y = 0 Then
                style.scale_x = 100
                style.scale_y = 100
            End If
            styles = styles + String.Format("Style:  {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22}{23}", style.name, style.font_name, style.font_size, style.primary_colour, style.secondary_colour, style.outline_colour, style.back_colour, style.bold, style.italic, style.underline, style.strikeout, style.scale_x, style.scale_y, style.spacing, style.angle, style.border_style, style.outline, style.shadow, style.alignment, style.margin_l, style.margin_r, style.margin_v, style.encoding, vbCr)
        Next
        For Each event1 As subtitle_scriptEvent In classxml.events
            events = events + String.Format("Dialogue: 0,{0},{1},{2},{3},{4},{5},{6},{7},{8}{9}", event1.start, event1.end, event1.style, event1.name, event1.margin_l, event1.margin_r, event1.margin_v, event1.effect, event1.text, vbCr)
        Next
        Return Encoding.UTF8.GetBytes(header + styles + events)
    End Function

    Private Shared Function _GenerateKey(ByVal id As Integer) As Byte()
        Dim _loc_3 As Long = _Obfuscate(id)
        Dim _loc_5 As New SHA1CryptoServiceProvider
        Dim _loc_6 As Byte() = Encoding.UTF8.GetBytes("$&).6CXzPHw=2N_+isZK" + _loc_3.ToString())
        Dim _loc_7 As Byte() = _loc_5.ComputeHash(_loc_6).Concat(Convert.FromBase64String("AAAAAAAAAAAAAAAA")).ToList.ToArray
        Return _loc_7
    End Function

    Private Shared Function _Obfuscate(id As Integer) As Long
        Return (Convert.ToInt64(id) Xor 88140282) Xor (Convert.ToInt64(id) Xor 88140282) >> 3 Xor Convert.ToInt64(88140282 Xor Convert.ToInt64(id)) * 32
    End Function
End Class
