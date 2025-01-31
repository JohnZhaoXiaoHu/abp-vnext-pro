using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Lion.AbpPro.FileManagement;

[DependsOn(
    typeof(FileManagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
)]
public class FileManagementApplicationContractsModule : AbpModule
{
}