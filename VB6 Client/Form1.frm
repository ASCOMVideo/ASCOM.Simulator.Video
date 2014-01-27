VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   7140
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   5160
   LinkTopic       =   "Form1"
   ScaleHeight     =   7140
   ScaleWidth      =   5160
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Interval        =   100
      Left            =   4680
      Top             =   5880
   End
   Begin VB.PictureBox Picture1 
      Height          =   3855
      Left            =   120
      ScaleHeight     =   3795
      ScaleWidth      =   4395
      TabIndex        =   3
      Top             =   3120
      Width           =   4455
   End
   Begin VB.TextBox Text1 
      Height          =   2295
      Left            =   120
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   2
      Text            =   "Form1.frx":0000
      Top             =   720
      Width           =   4455
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Connect"
      Height          =   375
      Left            =   3240
      TabIndex        =   0
      Top             =   240
      Width           =   1215
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "ASCOM.Simulator.Video"
      Height          =   255
      Left            =   120
      TabIndex        =   1
      Top             =   240
      Width           =   3015
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' used to create a stdPicture from a byte array
Private Declare Function CreateStreamOnHGlobal Lib "ole32" (ByVal hGlobal As Long, ByVal fDeleteOnRelease As Long, ppstm As Any) As Long
Private Declare Function GlobalAlloc Lib "kernel32" (ByVal uFlags As Long, ByVal dwBytes As Long) As Long
Private Declare Function GlobalLock Lib "kernel32" (ByVal hMem As Long) As Long
Private Declare Function GlobalUnlock Lib "kernel32" (ByVal hMem As Long) As Long
Private Declare Function OleLoadPicture Lib "olepro32" (pStream As Any, ByVal lSize As Long, ByVal fRunmode As Long, riid As Any, ppvObj As Any) As Long
Private Declare Sub CopyMemory Lib "kernel32.dll" Alias "RtlMoveMemory" (ByRef Destination As Any, ByRef Source As Any, ByVal Length As Long)

Private video As ASCOM_DeviceInterfaces.IVideo

' chooses a video device, creates it, connects and shows the ConfigureDeviceProperties window
Private Sub Command1_Click()
    Dim chsr As ASCOM_Utilities.Chooser
    Set chsr = New ASCOM_Utilities.Chooser
    chsr.DeviceType = "Video"
    Dim id As String
    id = chsr.Choose(Label1.Caption)
    Label1.Caption = id
    If id = "" Then
        Exit Sub
    End If
    Set video = CreateObject(id)
    
    video.Connected = True
    Text1.Text = video.DriverInfo
    If video.CanConfigureDeviceProperties Then
        video.ConfigureDeviceProperties
        ' this returns immediately, not sure what thread it's running in
    End If
End Sub

' gets the last video frame and displays it
Private Sub showVideo()
    Dim frame As IVideoFrame
    Set frame = video.LastVideoFrame
    Dim bmp() As Byte
    bmp = frame.PreviewBitmap
    
    Picture1.Picture = ArrayToPicture(bmp, 0, UBound(bmp) + 1)
End Sub

' timer to get the frame.
'VB6 is single threaded so timers tend to be used a lot to keep things responsive
Private Sub Timer1_Timer()
    If video Is Nothing Then Exit Sub
    If Not video.Connected Then Exit Sub
    showVideo
End Sub

' http://www.vbforums.com/showthread.php?493209-How-to-display-a-byte-array-bitmap-on-Picturebox
Public Function ArrayToPicture(inArray() As Byte, Offset As Long, Size As Long) As IPicture
    
    ' function creates a stdPicture from the passed array
    ' Offset is first item in array: 0 for 0 bound arrays
    ' Size is how many bytes comprise the image
    Dim o_hMem  As Long
    Dim o_lpMem  As Long
    Dim aGUID(0 To 3) As Long
    Dim IIStream As IUnknown
    
    aGUID(0) = &H7BF80980    ' GUID for stdPicture
    aGUID(1) = &H101ABF32
    aGUID(2) = &HAA00BB8B
    aGUID(3) = &HAB0C3000
    
    o_hMem = GlobalAlloc(&H2&, Size)
    If Not o_hMem = 0& Then
        o_lpMem = GlobalLock(o_hMem)
        If Not o_lpMem = 0& Then
            CopyMemory ByVal o_lpMem, inArray(Offset), Size
            Call GlobalUnlock(o_hMem)
            If CreateStreamOnHGlobal(o_hMem, 1&, IIStream) = 0& Then
                  Call OleLoadPicture(ByVal ObjPtr(IIStream), 0&, 0&, aGUID(0), ArrayToPicture)
            End If
        End If
    End If
End Function
