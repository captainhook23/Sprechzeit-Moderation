﻿using Sprechzeit.CalculateOperations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprechzeit.Config
{
    public class SpeakFlowConfig
    {
        static SpeakFlowConfig instance = null;
        List<ConfigItem>configItems= new List<ConfigItem>();
        //CalculateCharsNeeded ccn = new CalculateCharsNeeded();

        public SpeakFlowConfig()
        {
            GetConfigValues();
            
        }
        public static SpeakFlowConfig GetInstance(CalculateTimeBeingUsed c)
        {
            if (instance == null)
            {
                instance = new SpeakFlowConfig();
            }
            return instance;
        }
        
        public double GetSpeakFlow()
        {
            double factor = 0.0;
            for (int i = 0; i < configItems.Count; i++)
            {
                factor = factor + (configItems[i].SpeakFlow); // or equivalently r *= mult[i];
            }
            factor = factor / Convert.ToDouble(configItems.Count());
            return factor;
            
                
        }
        public void GetConfigValues()
        {
            string[] lines = File.ReadAllLines("Config/Config.csv");
            foreach (string line in lines)
            {
                ConfigItem config = new ConfigItem();
                config.SpeakFlow = double.Parse(line);
                configItems.Add(config);
            }
        }
        
        private class ConfigItem
        {
            public double SpeakFlow;
        }
    }
}
