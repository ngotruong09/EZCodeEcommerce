using Volo.Abp.Settings;

namespace EZCode.CustomerService.Settings;

public class CustomerServiceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CustomerServiceSettings.MySetting1));
    }
}
