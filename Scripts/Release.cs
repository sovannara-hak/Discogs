using System;
using System.Collections.Generic;

namespace Discogs
{
	public class Release
	{
		public string title;
		public int id;
		public IList<Artist> artists;
		public string data_quality;
		public string thumb;
		public Community community;
		public IList<Company> companies;
		public string country;
		public string date_added;
		public string date_changed;
		public int estimated_weight;
		public IList<Artist> extraartists;
		public int format_quantity;
		public IList<Format> formats;
		public IList<string> genres;
		public IList<Identifier> identifiers;
		public IList<Image> images;
		public IList<Label> labels;
		public string master_id;
		public string master_url;
		public string notes;
		public string released;
		public string released_formatted;
		public string resource_url;
		public IList<string> series;
		public string status;
		public IList<string> styles;
		public IList<Track> tracklist;
		public string uri;
		public IList<Video> videos;
		public int year;

		public Release ()
		{
		}
	}


}

