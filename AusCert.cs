using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AusCert
{
	public class Instrumentation
	{
		public static void Test()
		{
			MessageBox.Show("Test() Invoked", "AusCert");
		}


		public Instrumentation()
		{
			MessageBox.Show("Instrumentation Instantiated", "AusCert");
		}

		public void Test2()
		{
			MessageBox.Show("Test2() Invoked", "AusCert");
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
			return Interaction.InputBox(prompt, "AusCert", "", -1, -1);
		}

		public static void msgBox(string message)
		{
			MessageBox.Show(message, "AusCert");
		}

		public static bool boolBox(string query)
		{
			return MessageBox.Show(query, "AusCert", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes;
		}
	}
}
