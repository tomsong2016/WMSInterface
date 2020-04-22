using FluentScheduler;
using System.Runtime.InteropServices;
using Mlily.WMSInterface.Console.Jobs;

namespace Mlily.WMSInterface.Console
{
    public class JobRegistry : Registry
    {
        public JobRegistry()
        {
#if DEBUG
            //this.Schedule<ReceivingInventoryJob>().WithName("收货清点送检").ToRunEvery(1).Minutes();
            Schedule<ReceivingInventoryJob>().WithName("收货清点送检").ToRunNow().AndEvery(200).Seconds();
            //this.Schedule<Worker>().WithName("导入数据").ToRunNow();
            //this.Schedule<JsonJob>().WithName("Json导入数据").ToRunNow();
#else         
            //this.Schedule<Worker>().WithName("导入数据").ToRunEvery(1).Days().At(14, 0);
            //this.Schedule<JsonJob>().WithName("导入数据").ToRunEvery(1).Days().At(14, 0);
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                //this.Schedule<OptimizeWorker>().WithName("导入数据").ToRunNow();
                //this.Schedule<JsonJob>().WithName("Json导入数据").ToRunEvery(1).Days().At(Config.Instance.Get<BaseSetting>().RunHour, Config.Instance.Get<BaseSetting>().RunMinute);
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                //this.Schedule<FtpJob>().WithName("Ftp文件处理").ToRunEvery(1).Days().At(15, 0);
                //this.Schedule<Worker>().WithName("导入数据").ToRunEvery(1).Days().At(15, 0);
                //this.Schedule<JsonJob>().WithName("Json导入数据").ToRunEvery(1).Days().At(Config.Instance.Get<BaseSetting>().RunHour, Config.Instance.Get<BaseSetting>().RunMinute);
            }
#endif
        }
    }
}