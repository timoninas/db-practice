using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_operator
{
    public partial class FormConfigCar : Form
    {
        private ConfigCar configCar;
        public FormConfigCar(ConfigCar car)
        {
            InitializeComponent();
            this.configCar = car;
            setupButtons();
        }

        public void setupButtons()
        {
            ConfigCar tmpConfig = this.configCar;

            if (tmpConfig.butterfly_doors == 0)
            {
                disableButterflyButtons();
            }

            if (tmpConfig.doors == 0)
            {
                disableDoorsButtons();
            }

            if (tmpConfig.engine == 0)
            {
                disableEngineButtons();
            }

            if (tmpConfig.clutch == 0)
            {
                disableClutchButtons();
            }

            if (tmpConfig.hood_car == 0)
            {
                disableHoodButtons();
            }

            if (tmpConfig.trunk_car == 0)
            {
                disableTrunkButtons();
            }
        }

        public void disableButterflyButtons()
        {
            openButterflyButton.Enabled = false;
            closeButterflyButton.Enabled = false;
        }

        public void disableDoorsButtons()
        {
            openDoorsButton.Enabled = false;
            closeDoorsButton.Enabled = false;
        }

        public void disableEngineButtons()
        {
            startEngineButton.Enabled = false;
            stopEngineButton.Enabled = false;
        }

        public void disableClutchButtons()
        {
            unlockClutchButton.Enabled = false;
            lockClutchButton.Enabled = false;
        }

        public void disableHoodButtons()
        {
            OpenHoodCarButton.Enabled = false;
            CloseHoodCarButton.Enabled = false;
        }

        public void disableTrunkButtons()
        {
            OpenTrunkCarButton.Enabled = false;
            CloseTrunkCarButton.Enabled = false;
        }
    }
}
