﻿using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Nop.Plugin.Api.ActionResults
{
    public class RawJsonActionResult : IHttpActionResult
    {
        private readonly string _jsonString;

        public RawJsonActionResult(string jsonString)
        {
            _jsonString = jsonString;
        }

        public string JsonContent
        {
            get { return _jsonString; }
        }

        // TODO: check invalid property
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var content = new StringContent(JsonContent);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = new HttpResponseMessage(HttpStatusCode.OK) { Content = content };
            return Task.FromResult(response);
        }
    }
}
