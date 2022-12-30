﻿namespace TeamServer.Events;

public sealed class WebLogEvent : SharpC2Event
{
    public override EventType Type
        => EventType.WEB_LOG;

    public string Method { get; set; }
    public string Uri { get; set; }
    public string UserAgent { get; set; }
    public string SourceAddress { get; set; }
    public int ResponseCode { get; set; }
}