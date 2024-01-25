using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace HackedClient
{
	public class Instrumentation
	{
		public static void Test()
		{
			MessageBox.Show("Test() Invoked", "HackedClient");
		}


		public Instrumentation()
		{
			MessageBox.Show("Instrumentation Instantiated", "HackedClient");
		}

		public void Test2()
		{
			MessageBox.Show("Test2() Invoked", "HackedClient");
		}

		public void Invoke()
		{
			Instrumentation.Test();

			Instrumentation i = new Instrumentation();
			i.Test2();
			i.Test2();
		}

	}
	
	public class Utils
	{
		public static string strBox(string prompt)
		{
			return Interaction.InputBox(prompt, "HackedClient", "", -1, -1);
		}

		public static string strBox(string prompt, string current)
		{
			return Interaction.InputBox(prompt, "HackedClient", current, -1, -1);
		}

		public static void msgBox(string message)
		{
			MessageBox.Show(message, "HackedClient");
		}

		public static bool boolBox(string query)
		{
			return MessageBox.Show(query, "HackedClient", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes;
		}
	}
}
