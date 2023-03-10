using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerBiEmbed.Models
{
    public class DashboardEmbedConfig
    {
        public Guid DashboardId { get; set; }

        public string EmbedUrl { get; set; }

      //  public EmbedToken EmbedToken { get; set; }
    }
}