﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Warehouse.Data.Attribute;

namespace Warehouse.Data.Dto
{
    [BsonCollection("Package")]
    public class Package
    {
        #region Properties

        public ObjectId Id { get; set; }

        [BsonElementAttribute("Name")]
        public string Name { get; set; }

        [BsonElementAttribute("Width")]
        public int Width { get; set; }

        [BsonElementAttribute("Height")]
        public int Height { get; set; }

        [BsonElementAttribute("Length")]
        public int Length { get; set; }

        public int Volume
        {
            get { return Width*Height*Length; }
        }

        #endregion
    }
}