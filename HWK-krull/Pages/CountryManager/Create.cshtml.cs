using HWK_krull.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HWK_krull.Pages.CountryManager;

public class CreateModel : PageModel
{
	[BindProperty]
	public List<InputModel> Inputs { get; set; }
	public List<Country> Countries { get; set; } = new List<Country>();
	public void OnGet()
	{
	}
	public void OnPost()
	{
		Countries = Inputs.Where(x => !string.IsNullOrWhiteSpace(x.CountryCode)).Select(x => new Country
		{
			CountryName = x.CountryName,
			CountryCode = x.CountryCode,
		}).ToList();
	}
	public class InputModel
	{
		public string CountryName { get; set; }
		public string CountryCode { get; set; }
	}
}