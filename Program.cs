using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;

namespace testSArun
{
    class Program
    {

        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                using (Application app = Application.CreateApplication())
                {
                    Perform(app);
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
                Console.Read();
                //  MessageBox.Show(e.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public static void Perform(Application app)
        {
            Console.WriteLine($"loggin {app.CurrentUser.ToString()}");
            Console.ReadLine();
        }
    }
}