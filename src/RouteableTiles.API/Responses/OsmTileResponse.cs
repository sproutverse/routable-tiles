using System.Collections.Generic;
using OsmSharp;
using RouteableTiles.IO.JsonLD.Tiles;

namespace RouteableTiles.API.Responses
{
    internal class OsmTileResponse
    {
        public OsmTileResponse(IEnumerable<OsmGeo> data, Tile tile)
        {
            this.Data = data;
            this.Tile = tile;
        }
        
        public IEnumerable<OsmGeo> Data { get; set; }

        public Tile Tile { get; set; }
    }
}