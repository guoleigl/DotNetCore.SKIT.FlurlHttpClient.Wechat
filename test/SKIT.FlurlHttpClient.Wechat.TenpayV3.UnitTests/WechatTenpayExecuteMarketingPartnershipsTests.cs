﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class WechatTenpayExecuteMarketingPartnershipsTests
    {
        [Fact(DisplayName = "[POST] /marketing/partnerships/build")]
        public async Task BuildMarketingPartnershipTest()
        {
            var request = new Models.BuildMarketingPartnershipRequest()
            { 
                Partner = new Models.BuildMarketingPartnershipRequest.Types.Partner()
                { 
                    Type = "MERCHANT",
                    MerchantId = TestConfigs.WechatMerchantId
                },
                AuthorizedData = new Models.BuildMarketingPartnershipRequest.Types.AuthorizedData()
                { 
                    BusinessType = "FAVOR_STOCK"
                }
            };
            var response = await TestClients.Instance.ExecuteBuildMarketingPartnershipAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.State);
        }

        [Fact(DisplayName = "[GET] /marketing/partnerships")]
        public async Task QueryMarketingPartnershipsTest()
        {
            var request = new Models.QueryMarketingPartnershipsRequest()
            {
                Partner = new Models.QueryMarketingPartnershipsRequest.Types.Partner()
                {
                    Type = "MERCHANT",
                    MerchantId = TestConfigs.WechatMerchantId
                },
                AuthorizedData = new Models.QueryMarketingPartnershipsRequest.Types.AuthorizedData()
                {
                    BusinessType = "FAVOR_STOCK"
                }
            };
            var response = await TestClients.Instance.ExecuteQueryMarketingPartnershipsAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.PartnershipList);

            if (response.PartnershipList.Any())
            {
                Assert.NotNull(response.PartnershipList.First().Partner);
                Assert.NotNull(response.PartnershipList.First().Partner.Type);
                Assert.NotNull(response.PartnershipList.First().AuthorizedData);
                Assert.NotNull(response.PartnershipList.First().AuthorizedData.BusinessType);
                Assert.NotNull(response.PartnershipList.First().State);
            }
        }
    }
}
