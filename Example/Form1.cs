using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Example.DataParse;
using Example.Arguments;
using System.Collections;
using System.Threading;

namespace Example
{
    public partial class Form1 : Form
    {
        Args args = new Args();
        private IListed _listed;
        private IOTC _OTC;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IListed, Listed>();
            container.RegisterType<IOTC, OTC>();

            _listed = container.Resolve<IListed>();
            _OTC = container.Resolve<IOTC>();

        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            init();

            Thread Mission = new Thread(Run);
            Mission.Start();

        }

        void Run() 
        {
            var result = _listed.GetCapitalData("109");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Arguments initialization
        /// </summary>
        void init() 
        {
            args.Turnover = txt_turnover.Text.Trim();

            //args.UpDown = rdb_up.Checked  ? "Up" : "Down";

            //args.BuySell = rdb_buy.Checked  ? "Buy" : "Sell";
        }

    }
}
