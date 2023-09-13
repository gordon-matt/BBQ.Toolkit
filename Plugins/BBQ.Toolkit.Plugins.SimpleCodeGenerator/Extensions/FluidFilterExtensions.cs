using Fluid;
using Fluid.Values;
using System.Threading.Tasks;

namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator.Extensions;

public static class FluidFilterExtensions
{
    public static void AddCustomFilters(this FilterCollection filters)
    {
        filters.AddFilter("REPLACE", Replace);
    }

    public static ValueTask<FluidValue> Replace(FluidValue input, FilterArguments arguments, TemplateContext context)
    {
        string inputValue = input.ToStringValue();
        string oldValue = arguments.At(0).ToStringValue();
        string newValue = arguments.At(1).ToStringValue();

        return new StringValue(inputValue.Replace(oldValue, newValue));
    }
}