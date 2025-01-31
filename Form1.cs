using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Management;

namespace FixMyPing
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool pingtoggle = false;
        public bool pingtoggle2 = false;
        public bool pingtoggle3 = false;

        public string ping_address_1 = "";
        public string ping_address_2 = "";
        public string ping_address_3 = "";

        public string ping = "-";
        //dns stuffs
        public string prefDns = "-";
        public string altDns = "-";

        public int counter = 1;


        //cmd stuff
        public void ExecuteCommandSync(object command)
        {
            
            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();

                string result = proc.StandardOutput.ReadToEnd();

                Debug.WriteLine(result);
                

            }
            catch (Exception objException)
            {

            }
        }

        //pinging stuff
        private string pinger(string site)
        {

            if (site != null && site != "" && site != " ")
            {
                string latency;
                Ping pingClass = new Ping();
                try
                {
                    PingReply pingReply = pingClass.Send(site);
                    latency = (pingReply.RoundtripTime.ToString() + "ms");
                    return latency;
                }
                catch (PingException)
                {
                    return "!!!";
                }
            }
            else
            {
                return "!!!";
            }
        }

        //new ping stuff



        private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            // If an error occurred, display the exception to the user. 
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("Ping failed: {0}", e.Error.ToString()),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Let the main thread resume. 
                ((AutoResetEvent)e.UserState).Set();
            }

            DisplayReply(e.Reply);

            // Let the main thread resume.
            ((AutoResetEvent)e.UserState).Set();
        }

        public void DisplayReply(PingReply reply)
        {
            if (reply == null)
                return;

            if(counter == 1)
            {
                lbl_ping_1.Text = reply.RoundtripTime.ToString();
                counter++;
            }
            else if(counter == 2)
            {
                lbl_ping_2.Text = reply.RoundtripTime.ToString();
                counter++;
            }
            else if(counter == 3)
            {
                lbl_ping_3.Text = reply.RoundtripTime.ToString();
                counter = 1;
            }

        }





        /////




        private void Wait(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }


        //dns stuff start here


        public void DisplayDnsAddresses()//displays dnsaddress
        {
            var activeAdapter = GetActiveEthernetOrWifiNetworkInterface();
            var count = 0;

            IPInterfaceProperties adapterProperties = activeAdapter.GetIPProperties();
            IPAddressCollection dnsServers = adapterProperties.DnsAddresses;

            if (dnsServers.Count > 0)
            {
                //Debug.WriteLine("dns found");
                //Debug.WriteLine(activeAdapter.Name);
                foreach (IPAddress dns in dnsServers)
                {      
                    
                    Console.WriteLine("  DNS Servers ............................. : {0}",
                        dns.ToString());
                    if(count == 0)
                    {
                        prefDns = dns.ToString();
                        
                    }
                    if(count == 1)
                    {
                        altDns = dns.ToString();
                        count = 0;
                    }
                    if(dnsServers.Count == 1)
                    {
                        altDns = "-";
                    }

                    count++;
                    //Debug.WriteLine(dns);
                }
                   
                    
            }
            
        }

        public static NetworkInterface GetActiveEthernetOrWifiNetworkInterface()
        {
            var activeAdapter = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(
                a => a.OperationalStatus == OperationalStatus.Up &&
                (a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) && 
                 a.NetworkInterfaceType != NetworkInterfaceType.Tunnel && a.Name.StartsWith("Radmin") == false && a.Name.StartsWith("Hamachi") == false
                 && a.Name.StartsWith("Virtual") == false);

            return activeAdapter;
        }

        public static void SetDNS(string DnsString, string DnsString2)
        {
            string[] Dns = { DnsString,DnsString2 };
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Description"].ToString().Equals(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = Dns;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                            Debug.WriteLine("dns set to "+ Dns);
                        }
                    }
                }
            }
        }


        public string FindDnsName(string dns)
        {
            if(dns == "1.1.1.1")
            {
                return "Cloud Flare (fast)";
            }
            else if (dns == "8.8.8.8")
            {
                return "Google Dns (fast)";
            }
            else if (dns == "208.67.222.222")
            {
                return "Open Dns (reliable)";
            }
            else if (dns == "76.76.2.0")
            {
                return "ControD (Unblock sites)";
            }
            else
            {
                return "Name not in database";
            }
        }



        //speed test stuff start here





        //button stuff start here
        private void btn_ping_toggle_Click(object sender, EventArgs e)
        {
            if (pingtoggle == false)
            {
                pingtoggle = true;
                btn_ping_toggle_1.Text = ">>>";
                btn_ping_toggle_1.BackColor = Color.Green;


            }
            else
            {
                pingtoggle = false;
                btn_ping_toggle_1.Text = ">";
                btn_ping_toggle_1.BackColor = Color.Red;
            }
        }


        private void btn_refreshdns_Click(object sender, EventArgs e)
        {
            btn_refreshdns.Text = "Working...";
            ExecuteCommandSync("ipconfig/flushdns");
            lbl_flush.ForeColor = Color.Green;
            Wait(2);
            ExecuteCommandSync("ipconfig/release");
            lbl_flush.ForeColor = Color.Black;
            lbl_release.ForeColor = Color.Green;
            Wait(3);
            ExecuteCommandSync("ipconfig/renew");
            lbl_release.ForeColor = Color.Black;
            lbl_renew.ForeColor = Color.Green;
            Wait(3);
            btn_refreshdns.Text = "REFRESH DNS";
            lbl_renew.ForeColor = Color.Black;


        }

        private void time_ping_Tick(object sender, EventArgs e)
        {

            if (pingtoggle)
            {
                //lbl_ping_1.Text = pinger(ping_address_1);
                //lbl_ping_1.BackColor = Color.Green;

                //lbl_ping_2.Text = pinger(ping_address_2);
                //lbl_ping_2.BackColor = Color.Green;

                //lbl_ping_3.Text = pinger(ping_address_3);
                //lbl_ping_3.BackColor = Color.Green;

                if (counter == 1)
                {
                    try
                    {
                        AutoResetEvent waiter = new AutoResetEvent(false);
                        IPAddress ip = Dns.GetHostEntry(ping_address_1).AddressList.First(addr => addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                        var pingSender = new Ping();

                        pingSender.PingCompleted += PingCompletedCallback;

                        pingSender.SendAsync(ip, 1000, waiter);
                    }
                    catch (PingException)
                    {
                        lbl_ping_1.Text = "!!!";
                    }
                    catch (SocketException)
                    {
                        lbl_ping_1.Text = "!!!";
                    }
                }
                else if(counter == 2)
                {
                    try
                    {
                        AutoResetEvent waiter = new AutoResetEvent(false);
                        IPAddress ip = Dns.GetHostEntry(ping_address_2).AddressList.First(addr => addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                        var pingSender = new Ping();

                        pingSender.PingCompleted += PingCompletedCallback;

                        pingSender.SendAsync(ip, 1000, waiter);
                    }
                    catch (PingException)
                    {
                        lbl_ping_1.Text = "!!!";
                    }
                    catch (SocketException)
                    {
                        lbl_ping_1.Text = "!!!";
                    }
                }
                else if (counter == 3)
                {
                    try
                    {
                        AutoResetEvent waiter = new AutoResetEvent(false);
                        IPAddress ip = Dns.GetHostEntry(ping_address_3).AddressList.First(addr => addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                        var pingSender = new Ping();

                        pingSender.PingCompleted += PingCompletedCallback;

                        pingSender.SendAsync(ip, 1000, waiter);
                    }
                    catch (PingException)
                    {
                        lbl_ping_1.Text = "!!!";
                    }
                    catch (SocketException)
                    {
                        lbl_ping_1.Text = "!!!";
                    }
                }

            }
            else
            {
                lbl_ping_1.Text = "-";
                lbl_ping_1.BackColor = Color.Blue;

                lbl_ping_2.Text = "-";
                lbl_ping_2.BackColor = Color.Blue;

                lbl_ping_3.Text = "-";
                lbl_ping_3.BackColor = Color.Blue;
            }
        }

        private void timer_blink_Tick(object sender, EventArgs e)
        {
            ping_address_1 = textBox1.Text;
            ping_address_2 = textBox2.Text;
            ping_address_3 = textBox3.Text;

        }

        private void btn_switch_cloudflare_Click(object sender, EventArgs e)
        {
            SetDNS("1.1.1.1", "1.0.0.1");
        }

        private void btn_switch_google_Click(object sender, EventArgs e)
        {
            SetDNS("8.8.8.8", "8.8.4.4");
        }

        private void btn_switch_OpenDns_Click(object sender, EventArgs e)
        {
            SetDNS("208.67.222.222", "208.67.220.220");
        }

        private void btn_switch_ControlD_Click(object sender, EventArgs e)
        {
            SetDNS("76.76.2.0", "76.76.10.0");
        }

        private void lbl_flush_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void s_lbl_dnsnam_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dnsName_Click(object sender, EventArgs e)
        {

        }

        private void other_blink_Tick(object sender, EventArgs e)
        {
            DisplayDnsAddresses();
            lbl_currentDns.Text = prefDns;
            lbl_altDns.Text = altDns;
            lbl_dnsName.Text = FindDnsName(prefDns);
        }
    }




}
