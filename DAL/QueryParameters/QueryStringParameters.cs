﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.QueryParameters
{
    public abstract class QueryStringParameters
    {
		const int maxPageSize = 50;
		public int PageNumber { get; set; }

		private int _pageSize = 10;
		public int PageSize
		{
			get
			{
				return _pageSize;
			}
			set
			{
				_pageSize = (value > maxPageSize) ? maxPageSize : value;
			}
		}
		public string OrderBy { get; set; }
	}
}
