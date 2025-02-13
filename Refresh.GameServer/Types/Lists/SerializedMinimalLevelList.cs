using System.Xml.Serialization;
using JetBrains.Annotations;
using Refresh.GameServer.Types.Levels;

namespace Refresh.GameServer.Types.Lists;

#nullable disable

[XmlRoot("slots")]
[XmlType("slots")]
public class SerializedMinimalLevelList : SerializedList<GameMinimalLevel>
{
    public SerializedMinimalLevelList() {}
    
    public SerializedMinimalLevelList(IEnumerable<GameMinimalLevel> list, int total)
    {
        this.Total = total;
        this.Items = list.ToList();
    }

    [XmlElement("slot")]
    public override List<GameMinimalLevel> Items { get; set; }
}