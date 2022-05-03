using System.Windows.Forms;

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
	}
