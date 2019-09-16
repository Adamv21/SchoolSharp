using SchoolSharp.Abstractions.Components;
using SchoolSharp.Core.Components;
using SchoolSharp.Platform.SchoolSoft.HtmlParsers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Platform.SchoolSoft.Components.Schedule
{
    public class SchoolSoftScheduleComponent : BaseScheduleComponent<SchoolSoftSchoolPlatformClient>
    {
        private readonly HttpClient httpClient;
        public SchoolSoftScheduleComponent(HttpClient httpClient, SchoolSoftSchoolPlatformClient client) : base(client)
        {

        }

        public override async Task<IWeekSchedule> GetWeekScheduleAsync(byte week, ushort? term = null)
        {
            if (!term.HasValue)
                term = (ushort)CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);

            string scheduleUrl = "/student/right_student_schedule.jsp?term={term}";


            var result = await httpClient.GetAsync(scheduleUrl);

            var parser = new ScheduleHtmlParser();
            return parser.Parse(result.Content);
        }
    }
}
