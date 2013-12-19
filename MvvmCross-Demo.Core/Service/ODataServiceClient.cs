using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Simple.OData;
using Simple.OData.Client;

namespace MvvmCross_Demo.Core.Service
{
    public class ODataServiceClient
    {
        private static readonly string SERVICE_ENDPOINT = "https://tfsodata.visualstudio.com";
        private static readonly string USERNAME = "andyattebery";
        private static readonly string PASSWORD = "6&/s3:#9}L^n2CZ6,4{@2Fbw8h?78KBj";
        private static readonly string ACCOUNT = "wmp";

        private ODataClient _client;

        public ODataServiceClient()
        {
            var credential = new NetworkCredential(USERNAME, PASSWORD, ACCOUNT);
            _client = new ODataClient(new ODataClientSettings(SERVICE_ENDPOINT, credential));
        }
    }
}
