using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Caculator”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Caculator.svc 或 Caculator.svc.cs，然后开始调试。
    public class Caculator : ICaculator
    {
	//testting add some meaningless sentence 1
        public double add(double x, double y)
        {
            return x + y;
        }
        //this is a division method
        public double division(double x, double y)
        {
            if (y == 0)
            {
                return 0;
            }
            return x / y;
        }
        //this is a Multiplication method
        public double multiplication(double x, double y)
        {
            return x * y;
        }
        // this is a subtract method 5
        public double subtract(double x, double y)
        {
            return x - y;
        } 
	// add the 6th sentence 6
    }
}
