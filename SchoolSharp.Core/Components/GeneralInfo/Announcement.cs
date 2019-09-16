using SchoolSharp.Abstractions.Components;
using SchoolSharp.Abstractions.Components.GeneralInfo;
using SchoolSharp.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core.Components.GeneralInfo
{
    public class Announcement : BaseComponentInittiated, IAnnouncment
    {
        private Announcement(IClientComponent source, string title, string message, IDictionary<string, object> metadata) : base(source, metadata)
        {
            title.GuardNotNull(nameof(title));
            message.GuardNotNull(nameof(message));

            this.Title = title;
            this.Message = message;
        }
        public string Title { get; }
        public string Message { get; }
        
        public static Announcement Build(IClientComponent source, string title, string message, IDictionary<string, object> metadata) 
            => new Announcement(source, title, message, metadata);
        
    }
}
