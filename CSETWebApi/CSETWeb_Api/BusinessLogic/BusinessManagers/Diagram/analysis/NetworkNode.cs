﻿using System;
using System.Collections.Generic;
using CSETWeb_Api.BusinessManagers.Diagram.Analysis;

namespace CSETWeb_Api.BusinessManagers
{
    public abstract class NetworkNode
    {
        public string ID { get; set; }
        public string ComponentType { get; set; }
        public Guid ComponentGuid { get; internal set; }
        public bool IsVisible { get; internal set; }
        public string ComponentName { get; internal set; }
        public NetworkGeometry Geometry { get; internal set; }        
        public string Parent_id { get; internal set; }
        /// <summary>
        /// This can be either a Layer or zone change.  Components in a zone 
        /// have a different parent then their layer.
        /// </summary>
        public bool ParentChanged { get; set; }
    }
}