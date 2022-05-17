using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Fbx;

namespace FbxTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var reader = new FbxAsciiReader(new FileStream(Directory.GetCurrentDirectory() + "/Test/test_ascii.fbx", FileMode.Open));
			var doc = reader.Read();
			FbxIO.WriteAscii(doc, Directory.GetCurrentDirectory() + "/Test/test_ascii_2.fbx");
			Console.WriteLine("end");
			Console.ReadKey();
		}
	}
}
