/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocols;
using Thrift.Protocols.Entities;
using Thrift.Protocols.Utilities;
using Thrift.Transports;
using Thrift.Transports.Client;
using Thrift.Transports.Server;



public partial class THRegionLocation : TBase
{

  public TServerName ServerName { get; set; }

  public THRegionInfo RegionInfo { get; set; }

  public THRegionLocation()
  {
  }

  public THRegionLocation(TServerName serverName, THRegionInfo regionInfo) : this()
  {
    this.ServerName = serverName;
    this.RegionInfo = regionInfo;
  }

  public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_serverName = false;
      bool isset_regionInfo = false;
      TField field;
      await iprot.ReadStructBeginAsync(cancellationToken);
      while (true)
      {
        field = await iprot.ReadFieldBeginAsync(cancellationToken);
        if (field.Type == TType.Stop)
        {
          break;
        }

        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Struct)
            {
              ServerName = new TServerName();
              await ServerName.ReadAsync(iprot, cancellationToken);
              isset_serverName = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.Struct)
            {
              RegionInfo = new THRegionInfo();
              await RegionInfo.ReadAsync(iprot, cancellationToken);
              isset_regionInfo = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          default: 
            await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            break;
        }

        await iprot.ReadFieldEndAsync(cancellationToken);
      }

      await iprot.ReadStructEndAsync(cancellationToken);
      if (!isset_serverName)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_regionInfo)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
    }
    finally
    {
      iprot.DecrementRecursionDepth();
    }
  }

  public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
  {
    oprot.IncrementRecursionDepth();
    try
    {
      var struc = new TStruct("THRegionLocation");
      await oprot.WriteStructBeginAsync(struc, cancellationToken);
      var field = new TField();
      field.Name = "serverName";
      field.Type = TType.Struct;
      field.ID = 1;
      await oprot.WriteFieldBeginAsync(field, cancellationToken);
      await ServerName.WriteAsync(oprot, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      field.Name = "regionInfo";
      field.Type = TType.Struct;
      field.ID = 2;
      await oprot.WriteFieldBeginAsync(field, cancellationToken);
      await RegionInfo.WriteAsync(oprot, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      await oprot.WriteFieldStopAsync(cancellationToken);
      await oprot.WriteStructEndAsync(cancellationToken);
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override string ToString()
  {
    var sb = new StringBuilder("THRegionLocation(");
    sb.Append(", ServerName: ");
    sb.Append(ServerName== null ? "<null>" : ServerName.ToString());
    sb.Append(", RegionInfo: ");
    sb.Append(RegionInfo== null ? "<null>" : RegionInfo.ToString());
    sb.Append(")");
    return sb.ToString();
  }
}

