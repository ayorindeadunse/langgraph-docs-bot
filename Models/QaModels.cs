using System;

namespace LangGraphDocsBot.Models;

public class QuestionRequest
{
    public string Question { get; set; } = string.Empty;
}

public class SourceMetadata
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Source { get; set; }
    public string Language { get; set; }
}

public class QaResponse
{
    public string Answer { get; set; }
    public List<SourceMetadata> Sources { get; set; } = new();
}