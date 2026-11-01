using System;
using System.Windows.Forms;

namespace app_xem_phim_DINH_CAO_DANH_LOI;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Application.Run(new fchinh());
	}
}
