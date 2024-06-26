﻿using BLL.Models;
namespace TALPA.Models
{
    public class SuggestionsViewModel
	{
		public List<Suggestion> Suggestions { get; set; }
		public List<string> Categories { get; set; }
		public List<string> Limitations { get; set; }
		public string Search { get; set; }
		public string Sort { get; set; }
		public List<string> Filter { get; set; }
		public List<string> Selected { get; set; }
		public List<int> SelectedIds { get; set; }
		public List<string> Closed { get; set; }
		public int Results { get; set; }
	}
}