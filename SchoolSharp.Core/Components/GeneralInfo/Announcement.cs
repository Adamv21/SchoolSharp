using JetBrains.Annotations;
using SchoolSharp.Abstractions.Components;
 using SchoolSharp.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core.Components
{
    public class Announcement : BaseComponentInittiated, IAnnouncement
    {
        private Announcement(IClientComponent source, IDictionary<string, object> metadata) : base(source, metadata)
        {
        }
        public string Title => (string)Metadata.GetOrDefault(nameof(Title));
        public string Message => (string)Metadata.GetOrDefault(nameof(Message));

        public static Announcement Build(IClientComponent source, IDictionary<string, object> metadata,
            [NotNull] string title, [NotNull] string message)
        {
            metadata.AddOrReplace(nameof(Title), title.GuardNotNull(nameof(Title)));
            metadata.AddOrReplace(nameof(Message), message.GuardNotNull(nameof(message)));

            return new Announcement(source, metadata);
        }
        
    }
}
