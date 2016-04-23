using System;
using System.Collections.Generic;

namespace Discogs
{
	public class Community
	{
		public IList<Contributor> contributors;
		public string data_quality;
		public int have;
		public Rating rating;
		public string status;
		public Submitter submitter;
		public int want;

		public Community ()
		{
		}
	}
}

