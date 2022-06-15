using BEMaterial.Config;

namespace BEMaterial.Models;

public class BEMColor
{
	public string Name { get; set; } = "";
	public string CssClass { get; set; } = "";
	public ColorTypes ColorType { get; set; } = ColorTypes.KeyColor;

	public BEMColor(string name, string cssClass, ColorTypes colorType)
	{
		Name = name;
		CssClass = cssClass;
		ColorType = colorType;
	}
}