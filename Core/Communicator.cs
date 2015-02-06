using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slovní_fotbal;
using System.Windows.Forms;
using System.Management;
using System.Net;

namespace Slovní_fotbal.Core
{
    class Communicator
    {
        Licence licence = new Licence();

        private string _licence;
        private Task task;

        private const string SecurityKey = "9aw0a54hg14bpv5vwupef0oo7ojw2n";


        WqlObjectQuery objectQuery;
        ManagementObjectSearcher searcher;

        public void StartThread()
        {
            _licence = licence.getKey("licence");

            try
            {
                task = new Task(AsyncThread);
                task.Start();
            }
            catch (Exception) { }
        }

        private async void AsyncThread()
        {
            string username = "",
                os = "",
                cpuID = "";

            #region Uživatelské jméno
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT UserName FROM Win32_ComputerSystem");
                ManagementObjectCollection collection = searcher.Get();
                username = (string)collection.Cast<ManagementBaseObject>().First()["UserName"];
            }
            catch (Exception) { }
            #endregion

            #region Operační systém
            try
            {
                this.objectQuery = new WqlObjectQuery("select * from win32_OperatingSystem");
                this.searcher = new ManagementObjectSearcher(objectQuery);

                string _s, _os;

                foreach (ManagementObject MO in this.searcher.Get())
                {

                    _s = MO["name"].ToString();

                    string[] split1 = _s.Split('|');

                    _os = split1[0];
                    os = _os.ToString();
                }
            }
            catch (Exception) { }
            #endregion

            #region CPUID
            try
            {
                ManagementClass managClass = new ManagementClass("win32_processor");
                ManagementObjectCollection managCollec = managClass.GetInstances();

                foreach (ManagementObject managObj in managCollec)
                {
                    cpuID = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            catch (Exception) { }
            #endregion

            // -------------------------------------

            #region Zaslání dat na server
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://api.filipsedivy.cz/application/set");
                var postData = "username=" + username;
                postData += "&os=" + os;
                postData += "&cpuid=" + cpuID;

                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                request.Headers.Add("Appliction-Security: " + _licence);

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            catch (Exception)
            {

            }
            #endregion
        }
    }
}
