using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace WebEnterprise_mssql.Api.Dtos
{
    public class UpdatedPostDto
    {
        public Guid postId { get; set; }
        public string title { get; set; }
        public string Desc { get; set; }
        public string content { get; set; }
        public DateTimeOffset LastModifiedDate { get; set; }
        public int ViewsCount { get; set; } 
        public int CategoryId { get; set; }
        public int SubmissionId { get; set; }
        public List<IFormFile> files { get; set; }
    }
}