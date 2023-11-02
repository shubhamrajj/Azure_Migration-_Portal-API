using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ctrlspec.Models;
using ctrlspec.Data;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SankeyController : ControllerBase
    {
        private readonly CtrlSpecDbContext _context;

        public SankeyController(CtrlSpecDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SankeyData>> GetSankeyData()
        {
            var applicationList = _context.ApplicationLists.ToList();
            var serverList = _context.ServerLists.ToList();

            // Format the data into the required format for the Sankey diagram
            var sankeyData = FormatDataForSankey(applicationList, serverList);

            return Ok(sankeyData);
        }

        private List<SankeyData> FormatDataForSankey(List<ApplicationList> applicationList, List<ServerList> serverList)
        {
            var mapping = applicationList.Select(a => new { a.AppId, a.ApplicationLabel})
                                         .Join(serverList.Select(s => new { s.Id, s.ServerLabel }), a => a.AppId, s => s.Id,
                                               (a, s) => new { a.ApplicationLabel, s.ServerLabel })
                                         .ToList();

            var nodes = new List<string>();
            var links = new List<SankeyLink>();

            foreach (var item in mapping)
            {
                // Add unique nodes
                if (!nodes.Contains(item.ApplicationLabel))
                    nodes.Add(item.ApplicationLabel);
                if (!nodes.Contains(item.ServerLabel))
                    nodes.Add(item.ServerLabel);

                // Add link between application and server
                links.Add(new SankeyLink { Source = item.ApplicationLabel, Target = item.ServerLabel });
            }

            var nodeDictionary = new Dictionary<string, int>();
            for (int i = 0; i < nodes.Count; i++)
            {
                nodeDictionary.Add(nodes[i], i);
            }

            foreach (var link in links)
            {
                link.SourceIndex = nodeDictionary[link.Source];
                link.TargetIndex = nodeDictionary[link.Target];
            }

            var sankeyData = new List<SankeyData>
            {
                new SankeyData { Nodes = nodes, Links = links }
            };

            return sankeyData;
        }
    }
}

public class SankeyData
{
    public required List<string> Nodes { get; set; }
    public required List<SankeyLink> Links { get; set; }
}

public class SankeyLink
{
    public  string Source { get; set; }
    public  string Target { get; set; }
    public int SourceIndex { get; set; }
    public int TargetIndex { get; set; }
}

