using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Branchus
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			string exeName = Assembly.GetExecutingAssembly().GetName().Name + ".exe";
			string path = Assembly.GetExecutingAssembly().Location.Replace(exeName, "FileAssociation.bat");
			bool Found = false;
			try
			{
				new StreamReader(path);
				Found = true;
			}
			catch (FileNotFoundException){}
			if (!Found)
			{
				using (StreamWriter bat = new StreamWriter(path))
				{
					bat.WriteLine("assoc .brnch=BranchFile");
					bat.WriteLine("ftype BranchFile=" + System.Reflection.Assembly.GetExecutingAssembly().Location + " \"%1\"");
				}
				ProcessStartInfo info = new ProcessStartInfo(path);
				Process cmd = new Process() { StartInfo = info, };
				cmd.Start();
				cmd.WaitForExit();
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (args.Length == 0)
				Application.Run(new Branchus());
			else
				Application.Run(new Branchus(args[0]));
		}
	}
}
