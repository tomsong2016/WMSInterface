using System;
using FluentScheduler;
using Mlily.WMSInterface.Console.ViewModel;
using Mlily.WMSInterface.Service;

namespace Mlily.WMSInterface.Console.Jobs
{
    public class ReceivingInventoryJob : IJob
    {
        public void Execute()
        {
            InterfacePlatformService service = new InterfacePlatformService();
            var list = service.GetNowList();
            foreach (var item in list)
            {
                if (!item.Code.Equals("INT_MM002100001"))
                {
                    continue;
                }

                var viewModel = (RequestResultViewModel<ReceivingInventoryContent>)item.SendMessage.Deserialize(typeof(RequestResultViewModel<ReceivingInventoryContent>));

                var content = viewModel.ReqeustData.RequestInfo.Content;
                foreach (var itemDetail in content.Items)
                {
                    System.Console.WriteLine(itemDetail.MaterialCoding);
                }

                System.Console.WriteLine(content.Items.Count);
                System.Console.WriteLine(viewModel.Serializer(typeof(RequestResultViewModel<ReceivingInventoryContent>)));

                var responseModel = (ResponseResultViewModel)item.ReceivingMessage.Deserialize(typeof(ResponseResultViewModel));

                System.Console.WriteLine(responseModel.Data.ResultInfo.SubReturncode);
                System.Console.WriteLine(responseModel.Data.ResultInfo.SubReturninfo);
            }           

            System.Console.WriteLine("OK");
        }
    }
}