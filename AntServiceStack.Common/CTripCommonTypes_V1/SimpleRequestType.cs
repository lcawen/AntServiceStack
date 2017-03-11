﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntServiceStack.Common.Types
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    using AntServiceStack.ProtoBuf;
    using AntServiceStack.ServiceHost;
    using AntServiceStack.Baiji.Specific;
    using System.Linq;
    
    
    /// <summary>
    /// Simplest request type without request data.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/common/types/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ctrip.com/common/types/v1", IsNullable=true)]
    [DataContract(Namespace="http://soa.ctrip.com/common/types/v1")]
    [ProtoContract()]
    public partial class SimpleRequestType : ISpecificRecord
    {
        
        public static readonly AntServiceStack.Baiji.Schema.Schema SCHEMA = AntServiceStack.Baiji.Schema.Schema.Parse((("{\"type\":\"record\",\"name\":\"SimpleRequestType\",\"namespace\":\"" + typeof(SimpleRequestType).Namespace) 
                        + "\",\"doc\":null,\"fields\":[]}"));
        
        public virtual AntServiceStack.Baiji.Schema.Schema GetSchema()
        {
            return SCHEMA;
        }
        
        public virtual object Get(int fieldPos)
        {
            switch(fieldPos)
            {
                default: throw new AntServiceStack.Baiji.Exceptions.BaijiRuntimeException("Bad index " + fieldPos + " in Get()");
            }
        }
        
        public virtual void Put(int fieldPos, object fieldValue)
        {
            switch(fieldPos)
            {
                default: throw new AntServiceStack.Baiji.Exceptions.BaijiRuntimeException("Bad index " + fieldPos + " in Put()");
            }
        }
        
        public virtual object Get(string fieldName)
        {
            var recordSchema = GetSchema() as AntServiceStack.Baiji.Schema.RecordSchema;
            if (recordSchema == null)
            {
                return null;
            }
            AntServiceStack.Baiji.Schema.Field field;
            if (!recordSchema.TryGetField(fieldName, out field))
            {
                return null;
            }
            return Get(field.Pos);
        }
        
        public virtual void Put(string fieldName, object fieldValue)
        {
            var recordSchema = GetSchema() as AntServiceStack.Baiji.Schema.RecordSchema;
            if (recordSchema == null)
            {
                return ;
            }
            AntServiceStack.Baiji.Schema.Field field;
            if (!recordSchema.TryGetField(fieldName, out field))
            {
                return ;
            }
            Put(field.Pos, fieldValue);
        }
    }
}
