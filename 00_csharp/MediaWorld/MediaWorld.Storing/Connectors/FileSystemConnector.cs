using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Storing.Connectors 
{
  public class FileSystemConnector 
  {
    private const string _path = @"storage.xml";
    public List<AMedia> ReadXml(string path = _path)
    {
      var xml = new XmlSerializer(typeof(List<AMedia>)); //telling serializer which type of language to read
      var reader = new StreamReader(path);  //document to translate
      return xml.Deserialize(reader) as List<AMedia>; //French person translating text into English . . . resembling list of AMedia
    }

    public void WriteXml(List<AMedia> data, string path = _path)
    {
      var xml = new XmlSerializer(typeof(List<AMedia>));
      var writer = new StreamWriter(path);
      xml.Serialize(writer, data);
    }
  }
}