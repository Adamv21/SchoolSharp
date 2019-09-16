using SchoolSharp.Abstractions.Components;
using SchoolSharp.Common.HtmlParsers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SchoolSharp.Platform.SchoolSoft.HtmlParsers
{
    internal class ScheduleHtmlParser : BaseHtmlParser<IWeekSchedule>
    {
        public override IWeekSchedule Parse(HttpContent html)
        {

        }
    }
}
