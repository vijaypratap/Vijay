using Microsoft.AspNetCore.Mvc;
using QueryBotWeb.Models;
using QueryBotWeb.Services;

namespace QueryBotWeb.Controllers
{
    public class QueryController : Controller
    {
        private readonly OpenAiService _openAiService;
        private readonly SqlService _sqlService;

        public QueryController(OpenAiService openAiService, SqlService sqlService)
        {
            _openAiService = openAiService;
            _sqlService = sqlService;
        }

        [HttpPost]
        public IActionResult ExecuteQuery([FromBody] QueryRequest request)
        {
            // TODO: Replace with OpenAI integration to generate SQL from natural language
            // For now, treat input as raw SQL for demo purposes (DANGEROUS in production)
            string sql = request.NaturalLanguageQuery;
            string result = _sqlService.ExecuteQuery(sql);
            return Ok(new { response = sql, result });
        }
    }
}
