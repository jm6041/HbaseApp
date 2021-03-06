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



/// <summary>
/// Used to perform Get operations on a single row.
/// 
/// The scope can be further narrowed down by specifying a list of
/// columns or column families.
/// 
/// To get everything for a row, instantiate a Get object with just the row to get.
/// To further define the scope of what to get you can add a timestamp or time range
/// with an optional maximum number of versions to return.
/// 
/// If you specify a time range and a timestamp the range is ignored.
/// Timestamps on TColumns are ignored.
/// </summary>
public partial class TGet : TBase
{
  private List<TColumn> _columns;
  private long _timestamp;
  private TTimeRange _timeRange;
  private int _maxVersions;
  private byte[] _filterString;
  private Dictionary<byte[], byte[]> _attributes;
  private TAuthorization _authorizations;

  public byte[] Row { get; set; }

  public List<TColumn> Columns
  {
    get
    {
      return _columns;
    }
    set
    {
      __isset.columns = true;
      this._columns = value;
    }
  }

  public long Timestamp
  {
    get
    {
      return _timestamp;
    }
    set
    {
      __isset.timestamp = true;
      this._timestamp = value;
    }
  }

  public TTimeRange TimeRange
  {
    get
    {
      return _timeRange;
    }
    set
    {
      __isset.timeRange = true;
      this._timeRange = value;
    }
  }

  public int MaxVersions
  {
    get
    {
      return _maxVersions;
    }
    set
    {
      __isset.maxVersions = true;
      this._maxVersions = value;
    }
  }

  public byte[] FilterString
  {
    get
    {
      return _filterString;
    }
    set
    {
      __isset.filterString = true;
      this._filterString = value;
    }
  }

  public Dictionary<byte[], byte[]> Attributes
  {
    get
    {
      return _attributes;
    }
    set
    {
      __isset.attributes = true;
      this._attributes = value;
    }
  }

  public TAuthorization Authorizations
  {
    get
    {
      return _authorizations;
    }
    set
    {
      __isset.authorizations = true;
      this._authorizations = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool columns;
    public bool timestamp;
    public bool timeRange;
    public bool maxVersions;
    public bool filterString;
    public bool attributes;
    public bool authorizations;
  }

  public TGet()
  {
  }

  public TGet(byte[] row) : this()
  {
    this.Row = row;
  }

  public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_row = false;
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
            if (field.Type == TType.String)
            {
              Row = await iprot.ReadBinaryAsync(cancellationToken);
              isset_row = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.List)
            {
              {
                Columns = new List<TColumn>();
                TList _list8 = await iprot.ReadListBeginAsync(cancellationToken);
                for(int _i9 = 0; _i9 < _list8.Count; ++_i9)
                {
                  TColumn _elem10;
                  _elem10 = new TColumn();
                  await _elem10.ReadAsync(iprot, cancellationToken);
                  Columns.Add(_elem10);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.I64)
            {
              Timestamp = await iprot.ReadI64Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.Struct)
            {
              TimeRange = new TTimeRange();
              await TimeRange.ReadAsync(iprot, cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 5:
            if (field.Type == TType.I32)
            {
              MaxVersions = await iprot.ReadI32Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 6:
            if (field.Type == TType.String)
            {
              FilterString = await iprot.ReadBinaryAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 7:
            if (field.Type == TType.Map)
            {
              {
                Attributes = new Dictionary<byte[], byte[]>();
                TMap _map11 = await iprot.ReadMapBeginAsync(cancellationToken);
                for(int _i12 = 0; _i12 < _map11.Count; ++_i12)
                {
                  byte[] _key13;
                  byte[] _val14;
                  _key13 = await iprot.ReadBinaryAsync(cancellationToken);
                  _val14 = await iprot.ReadBinaryAsync(cancellationToken);
                  Attributes[_key13] = _val14;
                }
                await iprot.ReadMapEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 8:
            if (field.Type == TType.Struct)
            {
              Authorizations = new TAuthorization();
              await Authorizations.ReadAsync(iprot, cancellationToken);
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
      if (!isset_row)
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
      var struc = new TStruct("TGet");
      await oprot.WriteStructBeginAsync(struc, cancellationToken);
      var field = new TField();
      field.Name = "row";
      field.Type = TType.String;
      field.ID = 1;
      await oprot.WriteFieldBeginAsync(field, cancellationToken);
      await oprot.WriteBinaryAsync(Row, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      if (Columns != null && __isset.columns)
      {
        field.Name = "columns";
        field.Type = TType.List;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Struct, Columns.Count), cancellationToken);
          foreach (TColumn _iter15 in Columns)
          {
            await _iter15.WriteAsync(oprot, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (__isset.timestamp)
      {
        field.Name = "timestamp";
        field.Type = TType.I64;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(Timestamp, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (TimeRange != null && __isset.timeRange)
      {
        field.Name = "timeRange";
        field.Type = TType.Struct;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await TimeRange.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (__isset.maxVersions)
      {
        field.Name = "maxVersions";
        field.Type = TType.I32;
        field.ID = 5;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async(MaxVersions, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (FilterString != null && __isset.filterString)
      {
        field.Name = "filterString";
        field.Type = TType.String;
        field.ID = 6;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteBinaryAsync(FilterString, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (Attributes != null && __isset.attributes)
      {
        field.Name = "attributes";
        field.Type = TType.Map;
        field.ID = 7;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, Attributes.Count), cancellationToken);
          foreach (byte[] _iter16 in Attributes.Keys)
          {
            await oprot.WriteBinaryAsync(_iter16, cancellationToken);
            await oprot.WriteBinaryAsync(Attributes[_iter16], cancellationToken);
          }
          await oprot.WriteMapEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (Authorizations != null && __isset.authorizations)
      {
        field.Name = "authorizations";
        field.Type = TType.Struct;
        field.ID = 8;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await Authorizations.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
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
    var sb = new StringBuilder("TGet(");
    sb.Append(", Row: ");
    sb.Append(Row);
    if (Columns != null && __isset.columns)
    {
      sb.Append(", Columns: ");
      sb.Append(Columns);
    }
    if (__isset.timestamp)
    {
      sb.Append(", Timestamp: ");
      sb.Append(Timestamp);
    }
    if (TimeRange != null && __isset.timeRange)
    {
      sb.Append(", TimeRange: ");
      sb.Append(TimeRange== null ? "<null>" : TimeRange.ToString());
    }
    if (__isset.maxVersions)
    {
      sb.Append(", MaxVersions: ");
      sb.Append(MaxVersions);
    }
    if (FilterString != null && __isset.filterString)
    {
      sb.Append(", FilterString: ");
      sb.Append(FilterString);
    }
    if (Attributes != null && __isset.attributes)
    {
      sb.Append(", Attributes: ");
      sb.Append(Attributes);
    }
    if (Authorizations != null && __isset.authorizations)
    {
      sb.Append(", Authorizations: ");
      sb.Append(Authorizations== null ? "<null>" : Authorizations.ToString());
    }
    sb.Append(")");
    return sb.ToString();
  }
}

