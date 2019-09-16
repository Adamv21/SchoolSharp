using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SchoolSharp.Common.HtmlParsers
{
    public abstract class BaseHtmlParser<TResult>
    {
        public abstract TResult Parse(HttpContent html);
    }
}
