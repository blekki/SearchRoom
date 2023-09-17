first: SearchRoom.cs
	mcs -out:SearchRoom.exe SearchRoom.cs
	
run: SearchRoom.cs
	mono SearchRoom.exe
