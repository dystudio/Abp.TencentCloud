﻿using Volo.Abp;
using Volo.Abp.Modularity;
using Zony.Abp.TencentCloudSdk.Common;

namespace Zony.Abp.TencentCloudSdk.COS
{
    [DependsOn(typeof(AbpTencentCloudSdkCommonModule))]
    public class AbpTencentCloudSdkCOSModule : AbpModule
    {
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            base.OnApplicationInitialization(context);
        }
    }
}