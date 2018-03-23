# Rust-Cheat-Template
Start developing your own cheat with this template

# Getting started
To add more features to your cheat download a .NET decompiler (dnSpy, ILSpy, etc).
Go to Rust/RustClient_Data/Managed and disassemble Assembly-CSharp.dll, it contains most of the game code.

# Example: DebugCamera / Freecam
1. Disassemble Assembly-CSharp.dll
2. Navigate to ConVar namespace
3. Select 'Debugging' class
4. Search for the function 'debugcamera'
5. Copy-paste the code that toggles/creates the debugcamera prefab in a toggle in your code

			if (!SingletonComponent<CameraMan>.Instance)
			{
				GameManager.client.CreatePrefab("assets/bundled/prefabs/system/debug/debug_camera.prefab", true);
			}
			else
			{
				SingletonComponent<CameraMan>.Instance.enabled = !SingletonComponent<CameraMan>.Instance.enabled;
			}

# Help
Don't forget to include Rust's references, (Assembly-CSharp.dll, everything in Managed folder besides mscorlib and System dlls) or it will error on compiling.

# Useful information

https://docs.unity3d.com/ScriptReference/
