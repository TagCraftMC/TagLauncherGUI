Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Module MinecraftFont
    'PRIVATE FONT COLLECTION TO HOLD THE DYNAMIC FONT
    Private _pfc As PrivateFontCollection = Nothing


    Public ReadOnly Property GetInstance(ByVal Size As Single, _
                                         ByVal style As FontStyle) As Font
        Get
            'IF THIS IS THE FIRST TIME GETTING AN INSTANCE
            'LOAD THE FONT FROM RESOURCES
            If _pfc Is Nothing Then LoadFont()

            'RETURN A NEW FONT OBJECT BASED ON THE SIZE AND STYLE PASSED IN
            Return New Font(_pfc.Families(0), Size, style)

        End Get
    End Property

    Private Sub LoadFont()
        Try
            'INIT THE FONT COLLECTION
            _pfc = New PrivateFontCollection

            'LOAD MEMORY POINTER FOR FONT RESOURCE
            Dim fontMemPointer As IntPtr = _
                Marshal.AllocCoTaskMem( _
                My.Resources.minecraft_font_by_pwnage_block_d37t6nb.Length)

            'COPY THE DATA TO THE MEMORY LOCATION
            Marshal.Copy(My.Resources.minecraft_font_by_pwnage_block_d37t6nb, _
                         0, fontMemPointer, _
                         My.Resources.minecraft_font_by_pwnage_block_d37t6nb.Length)

            'LOAD THE MEMORY FONT INTO THE PRIVATE FONT COLLECTION
            _pfc.AddMemoryFont(fontMemPointer, _
                               My.Resources.minecraft_font_by_pwnage_block_d37t6nb.Length)

            'FREE UNSAFE MEMORY
            Marshal.FreeCoTaskMem(fontMemPointer)
        Catch ex As Exception
            'ERROR LOADING FONT. HANDLE EXCEPTION HERE
        End Try

    End Sub

End Module
