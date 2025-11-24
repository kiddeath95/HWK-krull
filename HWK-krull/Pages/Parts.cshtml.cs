using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HWK_krull.Pages;

public class Parts : PageModel
{
	public string PartName { get; set; }
	public string? Description { get; set; }
	public string? CompatKey { get; set; }

	public void OnGet(string partName, string? description, string? compatKey)
	{
		PartName = partName;
		Description = description;
		CompatKey = compatKey;
	}
}