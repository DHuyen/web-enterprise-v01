using System.Collections.Generic;

namespace WebEnterprise_mssql.Dtos
{
    public class PostResponseDto
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
        public string Message { get; set; }
    }
}