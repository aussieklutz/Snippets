using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace HackedClient
{
	public class HackILExamples
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

		public void Test3()
		{
			String testString = ReturnsString();
			testString = HackUtils.strBox("Change the String value: ", testString);
			HackUtils.msgBox("New String value is " + testString);
			
			bool testBool = HackUtils.boolBox("Allow the thing?");
			if(testBool)
			{
				HackUtils.msgBox("Allowed");
			} else {
				HackUtils.msgBox("Denied");
			}
		}

		private bool ReturnsTrue()
		{
			return true;
		}

		private string ReturnsString()
		{
			return "String";
		}

	}
	
	public class HackUtils
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
