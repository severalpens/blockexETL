using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blockex
{
    class HttpDataFeed
    {
        HttpClient client;
        private readonly  string defaultBaseAddress = "http://localhost:9002/";
        public HttpDataFeed()
        {
            Init(defaultBaseAddress);
        }
        public HttpDataFeed(string baseAddress)
        {
            Init(baseAddress);
        }

        private void Init(string baseAddress)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        public async Task<HttpResponseMessage> GetAsync(string path)
        {
            System.Net.Http.HttpResponseMessage response;
            response = await client.GetAsync(path);
            return response;
        }
    }
}
