Set objVideo = CreateObject("Tangra.DirectShow.Video")
'Set objVideo = CreateObject("ASCOM.Simulator.Video")

Wscript.Echo("Created driver OK")
objVideo.Connected = True

Wscript.Echo("Connected OK")
objVideo.ConfigureDeviceProperties()

Wscript.Echo("Called ConfigureDeviceProperties OK")


objVideo.Connected = False

Wscript.Echo("Disconnected OK")

Set objVideo = Nothing
