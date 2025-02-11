// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatSharpEndToEndTests.Oracle.Flatc
{

public enum Union : byte
{
  NONE = 0,
  BasicTypes = 1,
  Location = 2,
  stringValue = 3,
};

public class UnionUnion {
  public Union Type { get; set; }
  public object Value { get; set; }

  public UnionUnion() {
    this.Type = Union.NONE;
    this.Value = null;
  }

  public T As<T>() where T : class { return this.Value as T; }
  public FlatSharpEndToEndTests.Oracle.Flatc.BasicTypesT AsBasicTypes() { return this.As<FlatSharpEndToEndTests.Oracle.Flatc.BasicTypesT>(); }
  public static UnionUnion FromBasicTypes(FlatSharpEndToEndTests.Oracle.Flatc.BasicTypesT _basictypes) { return new UnionUnion{ Type = Union.BasicTypes, Value = _basictypes }; }
  public FlatSharpEndToEndTests.Oracle.Flatc.LocationT AsLocation() { return this.As<FlatSharpEndToEndTests.Oracle.Flatc.LocationT>(); }
  public static UnionUnion FromLocation(FlatSharpEndToEndTests.Oracle.Flatc.LocationT _location) { return new UnionUnion{ Type = Union.Location, Value = _location }; }
  public string AsstringValue() { return this.As<string>(); }
  public static UnionUnion FromstringValue(string _stringvalue) { return new UnionUnion{ Type = Union.stringValue, Value = _stringvalue }; }

  public static int Pack(Google.FlatBuffers.FlatBufferBuilder builder, UnionUnion _o) {
    switch (_o.Type) {
      default: return 0;
      case Union.BasicTypes: return FlatSharpEndToEndTests.Oracle.Flatc.BasicTypes.Pack(builder, _o.AsBasicTypes()).Value;
      case Union.Location: return FlatSharpEndToEndTests.Oracle.Flatc.Location.Pack(builder, _o.AsLocation()).Value;
      case Union.stringValue: return builder.CreateString(_o.AsstringValue()).Value;
    }
  }
}


}
