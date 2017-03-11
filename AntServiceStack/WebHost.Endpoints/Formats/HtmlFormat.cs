﻿using System;
using System.IO;
using System.Linq;
using System.Web;
using AntServiceStack.Common;
using AntServiceStack.Common.Web;
using AntServiceStack.Common.Extensions;
using AntServiceStack.ServiceHost;
using AntServiceStack.ServiceModel.Serialization;
using AntServiceStack.Text;

namespace AntServiceStack.WebHost.Endpoints.Formats
{
    public class HtmlFormat : IPlugin
    {
        public static string TitleFormat
            = @"{0} Snapshot of {1}";

        public static string HtmlTitleFormat
            = @"Snapshot of <i>{0}</i> generated by <i>CTrip SOA 2.0 Service</i> on <b>{1}</b>";

        public static string HtmlTemplate;

        private IAppHost AppHost { get; set; }

        public void Register(IAppHost appHost)
        {
            AppHost = appHost;
            //Register this in ServiceStack with the custom formats
            appHost.ContentTypeFilters.Register(ContentType.Html, SerializeToStream, null);
            appHost.ContentTypeFilters.Register(ContentType.JsonReport, SerializeToStream, null);

            appHost.Config.IgnoreFormatsInMetadata.Add(ContentType.Html.ToContentFormat());
            appHost.Config.IgnoreFormatsInMetadata.Add(ContentType.JsonReport.ToContentFormat());
        }

        public void SerializeToStream(IRequestContext requestContext, object response, IHttpResponse httpRes)
        {
            var httpReq = requestContext.Get<IHttpRequest>();

            //if (httpReq != null && AppHost.ViewEngines.Any(x => x.ProcessRequest(httpReq, httpRes, response))) return;

            if (requestContext.ResponseContentType != ContentType.Html && httpReq != null
                && httpReq.ResponseContentType != ContentType.JsonReport) return;

            var html = response as string;
            if (html == null)
            {
                // Serialize then escape any potential script tags to avoid XSS when displaying as HTML
                var json = WrappedJsonSerializer.Instance.SerializeToString(response) ?? "null";
                json = json.Replace("<", "&lt;").Replace(">", "&gt;");

                string url = string.Empty;
                if (httpReq != null)
                {
                    url = httpReq.AbsoluteUri
                                 .Replace("format=html", "")
                                 .Replace("format=shtm", "")
                                 .TrimEnd('?', '&');

                    url += url.Contains("?") ? "&" : "?";
                }

                var now = DateTime.Now;
                string requestName = string.Empty;
                if (httpReq != null) requestName = httpReq.OperationName ?? response.GetType().Name;

                html = GetHtmlTemplate()
                        .Replace("${Dto}", json)
                        .Replace("${Title}", string.Format(TitleFormat, requestName, now))
                        .Replace("${Header}", string.Format(HtmlTitleFormat, requestName, now))
                        .Replace("${ServiceUrl}", url);

            }

            var utf8Bytes = html.ToUtf8Bytes();
            httpRes.OutputStream.Write(utf8Bytes, 0, utf8Bytes.Length);
        }

        private string GetHtmlTemplate()
        {
            if (string.IsNullOrEmpty(HtmlTemplate))
            {
                HtmlTemplate = LoadHtmlTemplateFromEmbeddedResource();
            }
            return HtmlTemplate;
        }

        private string LoadHtmlTemplateFromEmbeddedResource()
        {
            // ServiceStack.WebHost.Endpoints.Formats.HtmlFormat.html
            string embeddedResourceName = GetType().Namespace + ".HtmlFormat.html";
            var stream = GetType().Assembly.GetManifestResourceStream(embeddedResourceName);
            if (stream == null)
            {
                throw new FileNotFoundException(
                    "Could not load HTML template embedded resource " + embeddedResourceName,
                    embeddedResourceName);
            }
            using (var streamReader = new StreamReader(stream))
            {
                return streamReader.ReadToEnd();
            }
        }
    }

}