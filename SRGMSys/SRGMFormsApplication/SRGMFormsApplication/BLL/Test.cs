using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;

namespace SRGMFormsApplication.BLL
{
    class Test
    {
        static MWMCR mcr;
        public static void other(MWCharArray modelName, MWCharArray dataSetName, MWCharArray xmd0)
        {
            #region 首先使用PlotTest.dll来初始化mcr,因为这个dll是混编“合法”产生的，只有这样才能顺利启动mcr
            if (MWMCR.MCRAppInitialized)
            {
                string path = Path.Combine(System.Environment.CurrentDirectory, "Test.dll");
                Assembly assembly = Assembly.LoadFile(path);
                string ctfFilePath = assembly.Location;
                int lastDelimiter = ctfFilePath.LastIndexOf(@"\");
                ctfFilePath = ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));
                string ctfFileName = "Test.ctf";
                Stream embeddedCtfStream = null;
                String[] resourceStrings = assembly.GetManifestResourceNames();

                foreach (String name in resourceStrings)
                {
                    if (name.Contains(ctfFileName))
                    {
                        embeddedCtfStream = assembly.GetManifestResourceStream(name);
                        break;
                    }
                }
                mcr = new MWMCR("", ctfFilePath, embeddedCtfStream, true);
            }
            else
            {
                throw new ApplicationException("MWArray assembly could not be initialized");
            }
            #endregion

            #region 直接调用混编dll中的封装函数进行测试
            MWArray[] shuru =  {modelName,dataSetName,xmd0};
            mcr.EvaluateFunction(0, "T1MnDSn", shuru);

            #endregion
        }
    }
}
