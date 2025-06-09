using System;

namespace LangGraphDocsBot.Models;

public class QuestionRequest
{
    public string Question { get; set; } = string.Empty;
}

public class QaResponse
{
    public string Response { get; set; } = string.Empty;
}