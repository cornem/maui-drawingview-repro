using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Views;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace maui_drawingview_repro;

internal class MainViewModel
{
    public ObservableCollection<IDrawingLine> Lines { get; } = new();

    public MainViewModel()
    {
        var drawingLines = JsonSerializer.Deserialize<IEnumerable<DrawingLine>>(SerializedDrawingLines);

        foreach (var line in drawingLines)
        {
            Lines.Add(line);
        }
    }

    private const string SerializedDrawingLines =
        "[{\"LineColor\":{},\"LineWidth\":5,\"Points\":[{\"X\":16,\"Y\":47,\"IsEmpty\":false},{\"X\":16,\"Y\":49,\"IsEmpty\":false},{\"X\":16,\"Y\":51,\"IsEmpty\":false}," +
        "{\"X\":16,\"Y\":57,\"IsEmpty\":false},{\"X\":16,\"Y\":61,\"IsEmpty\":false},{\"X\":16,\"Y\":65,\"IsEmpty\":false},{\"X\":16,\"Y\":73,\"IsEmpty\":false}," +
        "{\"X\":17,\"Y\":79,\"IsEmpty\":false},{\"X\":18,\"Y\":88,\"IsEmpty\":false},{\"X\":19,\"Y\":97,\"IsEmpty\":false},{\"X\":20,\"Y\":102,\"IsEmpty\":false}," +
        "{\"X\":21,\"Y\":107,\"IsEmpty\":false},{\"X\":21,\"Y\":113,\"IsEmpty\":false},{\"X\":21,\"Y\":118,\"IsEmpty\":false},{\"X\":22,\"Y\":123,\"IsEmpty\":false}," +
        "{\"X\":23,\"Y\":125,\"IsEmpty\":false},{\"X\":24,\"Y\":128,\"IsEmpty\":false},{\"X\":24,\"Y\":130,\"IsEmpty\":false},{\"X\":24,\"Y\":132,\"IsEmpty\":false}," +
        "{\"X\":24,\"Y\":134,\"IsEmpty\":false},{\"X\":24,\"Y\":136,\"IsEmpty\":false},{\"X\":24,\"Y\":137,\"IsEmpty\":false},{\"X\":25,\"Y\":139,\"IsEmpty\":false}," +
        "{\"X\":25,\"Y\":140,\"IsEmpty\":false},{\"X\":25,\"Y\":142,\"IsEmpty\":false},{\"X\":25,\"Y\":144,\"IsEmpty\":false},{\"X\":25,\"Y\":146,\"IsEmpty\":false}," +
        "{\"X\":25,\"Y\":148,\"IsEmpty\":false},{\"X\":25,\"Y\":150,\"IsEmpty\":false},{\"X\":25,\"Y\":152,\"IsEmpty\":false},{\"X\":25,\"Y\":155,\"IsEmpty\":false}," +
        "{\"X\":25,\"Y\":156,\"IsEmpty\":false},{\"X\":25,\"Y\":159,\"IsEmpty\":false},{\"X\":26,\"Y\":160,\"IsEmpty\":false},{\"X\":26,\"Y\":162,\"IsEmpty\":false}," +
        "{\"X\":26,\"Y\":163,\"IsEmpty\":false},{\"X\":27,\"Y\":169,\"IsEmpty\":false},{\"X\":27,\"Y\":171,\"IsEmpty\":false},{\"X\":27,\"Y\":172,\"IsEmpty\":false}," +
        "{\"X\":27,\"Y\":176,\"IsEmpty\":false},{\"X\":27,\"Y\":178,\"IsEmpty\":false},{\"X\":27,\"Y\":182,\"IsEmpty\":false},{\"X\":27,\"Y\":186,\"IsEmpty\":false}," +
        "{\"X\":27,\"Y\":188,\"IsEmpty\":false},{\"X\":27,\"Y\":191,\"IsEmpty\":false},{\"X\":27,\"Y\":193,\"IsEmpty\":false},{\"X\":27,\"Y\":195,\"IsEmpty\":false}," +
        "{\"X\":27,\"Y\":196,\"IsEmpty\":false},{\"X\":27,\"Y\":197,\"IsEmpty\":false},{\"X\":27,\"Y\":199,\"IsEmpty\":false},{\"X\":27,\"Y\":200,\"IsEmpty\":false}," +
        "{\"X\":27,\"Y\":202,\"IsEmpty\":false},{\"X\":27,\"Y\":204,\"IsEmpty\":false},{\"X\":27,\"Y\":205,\"IsEmpty\":false},{\"X\":27,\"Y\":206,\"IsEmpty\":false}," +
        "{\"X\":27,\"Y\":207,\"IsEmpty\":false},{\"X\":27,\"Y\":208,\"IsEmpty\":false},{\"X\":27,\"Y\":209,\"IsEmpty\":false},{\"X\":27,\"Y\":210,\"IsEmpty\":false}," +
        "{\"X\":27,\"Y\":211,\"IsEmpty\":false},{\"X\":27,\"Y\":213,\"IsEmpty\":false},{\"X\":27,\"Y\":214,\"IsEmpty\":false}],\"Granularity\":5,\"ShouldSmoothPathWhenDrawn\":true}," +
        "{\"LineColor\":{},\"LineWidth\":5,\"Points\":[{\"X\":17,\"Y\":131,\"IsEmpty\":false},{\"X\":18,\"Y\":130,\"IsEmpty\":false},{\"X\":19,\"Y\":129,\"IsEmpty\":false}," +
        "{\"X\":21,\"Y\":129,\"IsEmpty\":false},{\"X\":24,\"Y\":129,\"IsEmpty\":false},{\"X\":27,\"Y\":128,\"IsEmpty\":false},{\"X\":32,\"Y\":127,\"IsEmpty\":false}," +
        "{\"X\":37,\"Y\":126,\"IsEmpty\":false},{\"X\":43,\"Y\":125,\"IsEmpty\":false},{\"X\":49,\"Y\":124,\"IsEmpty\":false},{\"X\":52,\"Y\":123,\"IsEmpty\":false}," +
        "{\"X\":54,\"Y\":123,\"IsEmpty\":false},{\"X\":55,\"Y\":122,\"IsEmpty\":false},{\"X\":56,\"Y\":122,\"IsEmpty\":false}],\"Granularity\":5,\"ShouldSmoothPathWhenDrawn\":true}," +
        "{\"LineColor\":{},\"LineWidth\":5,\"Points\":[{\"X\":57,\"Y\":54,\"IsEmpty\":false},{\"X\":57,\"Y\":55,\"IsEmpty\":false},{\"X\":57,\"Y\":57,\"IsEmpty\":false}," +
        "{\"X\":57,\"Y\":60,\"IsEmpty\":false},{\"X\":58,\"Y\":63,\"IsEmpty\":false},{\"X\":58,\"Y\":67,\"IsEmpty\":false},{\"X\":59,\"Y\":72,\"IsEmpty\":false}," +
        "{\"X\":60,\"Y\":82,\"IsEmpty\":false},{\"X\":60,\"Y\":91,\"IsEmpty\":false},{\"X\":62,\"Y\":106,\"IsEmpty\":false},{\"X\":63,\"Y\":116,\"IsEmpty\":false}," +
        "{\"X\":64,\"Y\":123,\"IsEmpty\":false},{\"X\":65,\"Y\":132,\"IsEmpty\":false},{\"X\":66,\"Y\":140,\"IsEmpty\":false},{\"X\":66,\"Y\":147,\"IsEmpty\":false}," +
        "{\"X\":67,\"Y\":158,\"IsEmpty\":false},{\"X\":68,\"Y\":161,\"IsEmpty\":false},{\"X\":68,\"Y\":164,\"IsEmpty\":false},{\"X\":68,\"Y\":167,\"IsEmpty\":false}," +
        "{\"X\":68,\"Y\":169,\"IsEmpty\":false},{\"X\":68,\"Y\":170,\"IsEmpty\":false},{\"X\":68,\"Y\":174,\"IsEmpty\":false},{\"X\":68,\"Y\":176,\"IsEmpty\":false}," +
        "{\"X\":68,\"Y\":177,\"IsEmpty\":false},{\"X\":68,\"Y\":180,\"IsEmpty\":false},{\"X\":68,\"Y\":182,\"IsEmpty\":false},{\"X\":68,\"Y\":183,\"IsEmpty\":false}," +
        "{\"X\":68,\"Y\":184,\"IsEmpty\":false},{\"X\":68,\"Y\":185,\"IsEmpty\":false},{\"X\":68,\"Y\":186,\"IsEmpty\":false},{\"X\":68,\"Y\":187,\"IsEmpty\":false}," +
        "{\"X\":68,\"Y\":188,\"IsEmpty\":false}],\"Granularity\":5,\"ShouldSmoothPathWhenDrawn\":true},{\"LineColor\":{},\"LineWidth\":5,\"Points\":[{\"X\":76,\"Y\":177,\"IsEmpty\":false}," +
        "{\"X\":77,\"Y\":177,\"IsEmpty\":false},{\"X\":77,\"Y\":176,\"IsEmpty\":false},{\"X\":79,\"Y\":176,\"IsEmpty\":false},{\"X\":80,\"Y\":175,\"IsEmpty\":false}," +
        "{\"X\":82,\"Y\":174,\"IsEmpty\":false},{\"X\":84,\"Y\":173,\"IsEmpty\":false},{\"X\":87,\"Y\":172,\"IsEmpty\":false},{\"X\":90,\"Y\":171,\"IsEmpty\":false}," +
        "{\"X\":93,\"Y\":168,\"IsEmpty\":false},{\"X\":95,\"Y\":167,\"IsEmpty\":false},{\"X\":98,\"Y\":165,\"IsEmpty\":false},{\"X\":101,\"Y\":163,\"IsEmpty\":false}," +
        "{\"X\":102,\"Y\":161,\"IsEmpty\":false},{\"X\":104,\"Y\":160,\"IsEmpty\":false},{\"X\":106,\"Y\":156,\"IsEmpty\":false},{\"X\":107,\"Y\":153,\"IsEmpty\":false}," +
        "{\"X\":108,\"Y\":152,\"IsEmpty\":false},{\"X\":108,\"Y\":150,\"IsEmpty\":false},{\"X\":109,\"Y\":148,\"IsEmpty\":false},{\"X\":109,\"Y\":147,\"IsEmpty\":false}," +
        "{\"X\":109,\"Y\":143,\"IsEmpty\":false},{\"X\":109,\"Y\":142,\"IsEmpty\":false},{\"X\":109,\"Y\":141,\"IsEmpty\":false},{\"X\":108,\"Y\":141,\"IsEmpty\":false}," +
        "{\"X\":108,\"Y\":140,\"IsEmpty\":false},{\"X\":105,\"Y\":140,\"IsEmpty\":false},{\"X\":103,\"Y\":140,\"IsEmpty\":false},{\"X\":101,\"Y\":140,\"IsEmpty\":false}," +
        "{\"X\":98,\"Y\":140,\"IsEmpty\":false},{\"X\":96,\"Y\":140,\"IsEmpty\":false},{\"X\":94,\"Y\":142,\"IsEmpty\":false},{\"X\":92,\"Y\":144,\"IsEmpty\":false}," +
        "{\"X\":90,\"Y\":146,\"IsEmpty\":false},{\"X\":88,\"Y\":148,\"IsEmpty\":false},{\"X\":86,\"Y\":151,\"IsEmpty\":false},{\"X\":86,\"Y\":154,\"IsEmpty\":false}," +
        "{\"X\":84,\"Y\":157,\"IsEmpty\":false},{\"X\":82,\"Y\":165,\"IsEmpty\":false},{\"X\":82,\"Y\":168,\"IsEmpty\":false},{\"X\":82,\"Y\":171,\"IsEmpty\":false}," +
        "{\"X\":82,\"Y\":174,\"IsEmpty\":false},{\"X\":82,\"Y\":177,\"IsEmpty\":false},{\"X\":82,\"Y\":179,\"IsEmpty\":false},{\"X\":82,\"Y\":182,\"IsEmpty\":false}," +
        "{\"X\":82,\"Y\":183,\"IsEmpty\":false},{\"X\":83,\"Y\":184,\"IsEmpty\":false},{\"X\":84,\"Y\":185,\"IsEmpty\":false},{\"X\":85,\"Y\":185,\"IsEmpty\":false}," +
        "{\"X\":86,\"Y\":185,\"IsEmpty\":false},{\"X\":87,\"Y\":185,\"IsEmpty\":false},{\"X\":88,\"Y\":185,\"IsEmpty\":false},{\"X\":90,\"Y\":184,\"IsEmpty\":false}," +
        "{\"X\":91,\"Y\":184,\"IsEmpty\":false},{\"X\":92,\"Y\":184,\"IsEmpty\":false},{\"X\":93,\"Y\":184,\"IsEmpty\":false}],\"Granularity\":5,\"ShouldSmoothPathWhenDrawn\":true}," +
        "{\"LineColor\":{},\"LineWidth\":5,\"Points\":[{\"X\":107,\"Y\":48,\"IsEmpty\":false},{\"X\":108,\"Y\":48,\"IsEmpty\":false},{\"X\":108,\"Y\":49,\"IsEmpty\":false}," +
        "{\"X\":108,\"Y\":50,\"IsEmpty\":false},{\"X\":109,\"Y\":54,\"IsEmpty\":false},{\"X\":111,\"Y\":61,\"IsEmpty\":false},{\"X\":111,\"Y\":64,\"IsEmpty\":false}," +
        "{\"X\":113,\"Y\":73,\"IsEmpty\":false},{\"X\":114,\"Y\":82,\"IsEmpty\":false},{\"X\":115,\"Y\":88,\"IsEmpty\":false},{\"X\":118,\"Y\":109,\"IsEmpty\":false}," +
        "{\"X\":119,\"Y\":113,\"IsEmpty\":false},{\"X\":121,\"Y\":125,\"IsEmpty\":false},{\"X\":122,\"Y\":136,\"IsEmpty\":false},{\"X\":122,\"Y\":140,\"IsEmpty\":false}," +
        "{\"X\":123,\"Y\":150,\"IsEmpty\":false},{\"X\":124,\"Y\":163,\"IsEmpty\":false},{\"X\":124,\"Y\":165,\"IsEmpty\":false},{\"X\":124,\"Y\":170,\"IsEmpty\":false}," +
        "{\"X\":124,\"Y\":174,\"IsEmpty\":false},{\"X\":124,\"Y\":175,\"IsEmpty\":false},{\"X\":125,\"Y\":178,\"IsEmpty\":false},{\"X\":125,\"Y\":180,\"IsEmpty\":false}," +
        "{\"X\":125,\"Y\":181,\"IsEmpty\":false},{\"X\":125,\"Y\":182,\"IsEmpty\":false},{\"X\":125,\"Y\":183,\"IsEmpty\":false}],\"Granularity\":5,\"ShouldSmoothPathWhenDrawn\":true}," +
        "{\"LineColor\":{},\"LineWidth\":5,\"Points\":[{\"X\":121,\"Y\":49,\"IsEmpty\":false},{\"X\":122,\"Y\":49,\"IsEmpty\":false},{\"X\":122,\"Y\":50,\"IsEmpty\":false}," +
        "{\"X\":122,\"Y\":51,\"IsEmpty\":false},{\"X\":123,\"Y\":56,\"IsEmpty\":false},{\"X\":125,\"Y\":63,\"IsEmpty\":false},{\"X\":127,\"Y\":68,\"IsEmpty\":false}," +
        "{\"X\":130,\"Y\":77,\"IsEmpty\":false},{\"X\":132,\"Y\":84,\"IsEmpty\":false},{\"X\":135,\"Y\":97,\"IsEmpty\":false},{\"X\":142,\"Y\":120,\"IsEmpty\":false}," +
        "{\"X\":145,\"Y\":130,\"IsEmpty\":false},{\"X\":150,\"Y\":149,\"IsEmpty\":false},{\"X\":154,\"Y\":170,\"IsEmpty\":false},{\"X\":156,\"Y\":180,\"IsEmpty\":false}," +
        "{\"X\":160,\"Y\":195,\"IsEmpty\":false},{\"X\":165,\"Y\":214,\"IsEmpty\":false},{\"X\":167,\"Y\":219,\"IsEmpty\":false},{\"X\":169,\"Y\":226,\"IsEmpty\":false}," +
        "{\"X\":170,\"Y\":229,\"IsEmpty\":false},{\"X\":170,\"Y\":231,\"IsEmpty\":false},{\"X\":170,\"Y\":235,\"IsEmpty\":false},{\"X\":171,\"Y\":238,\"IsEmpty\":false}," +
        "{\"X\":171,\"Y\":240,\"IsEmpty\":false},{\"X\":171,\"Y\":241,\"IsEmpty\":false},{\"X\":172,\"Y\":242,\"IsEmpty\":false}],\"Granularity\":5,\"ShouldSmoothPathWhenDrawn\":true}," +
        "{\"LineColor\":{},\"LineWidth\":5,\"Points\":[{\"X\":187,\"Y\":143,\"IsEmpty\":false},{\"X\":187,\"Y\":144,\"IsEmpty\":false},{\"X\":186,\"Y\":149,\"IsEmpty\":false}," +
        "{\"X\":185,\"Y\":152,\"IsEmpty\":false},{\"X\":185,\"Y\":159,\"IsEmpty\":false},{\"X\":184,\"Y\":162,\"IsEmpty\":false},{\"X\":184,\"Y\":166,\"IsEmpty\":false}," +
        "{\"X\":184,\"Y\":169,\"IsEmpty\":false},{\"X\":184,\"Y\":175,\"IsEmpty\":false},{\"X\":184,\"Y\":178,\"IsEmpty\":false},{\"X\":184,\"Y\":183,\"IsEmpty\":false}," +
        "{\"X\":184,\"Y\":186,\"IsEmpty\":false},{\"X\":184,\"Y\":188,\"IsEmpty\":false},{\"X\":184,\"Y\":189,\"IsEmpty\":false},{\"X\":185,\"Y\":191,\"IsEmpty\":false}," +
        "{\"X\":186,\"Y\":194,\"IsEmpty\":false},{\"X\":187,\"Y\":195,\"IsEmpty\":false},{\"X\":189,\"Y\":196,\"IsEmpty\":false},{\"X\":192,\"Y\":200,\"IsEmpty\":false}," +
        "{\"X\":194,\"Y\":201,\"IsEmpty\":false},{\"X\":197,\"Y\":203,\"IsEmpty\":false},{\"X\":198,\"Y\":203,\"IsEmpty\":false},{\"X\":199,\"Y\":203,\"IsEmpty\":false}," +
        "{\"X\":200,\"Y\":201,\"IsEmpty\":false},{\"X\":200,\"Y\":200,\"IsEmpty\":false},{\"X\":201,\"Y\":198,\"IsEmpty\":false},{\"X\":201,\"Y\":197,\"IsEmpty\":false}," +
        "{\"X\":202,\"Y\":194,\"IsEmpty\":false},{\"X\":202,\"Y\":192,\"IsEmpty\":false},{\"X\":203,\"Y\":189,\"IsEmpty\":false},{\"X\":203,\"Y\":187,\"IsEmpty\":false}," +
        "{\"X\":203,\"Y\":185,\"IsEmpty\":false},{\"X\":203,\"Y\":183,\"IsEmpty\":false},{\"X\":203,\"Y\":181,\"IsEmpty\":false},{\"X\":204,\"Y\":179,\"IsEmpty\":false}," +
        "{\"X\":204,\"Y\":175,\"IsEmpty\":false},{\"X\":204,\"Y\":173,\"IsEmpty\":false},{\"X\":204,\"Y\":172,\"IsEmpty\":false},{\"X\":204,\"Y\":171,\"IsEmpty\":false}," +
        "{\"X\":204,\"Y\":170,\"IsEmpty\":false},{\"X\":204,\"Y\":169,\"IsEmpty\":false},{\"X\":203,\"Y\":169,\"IsEmpty\":false},{\"X\":202,\"Y\":168,\"IsEmpty\":false}," +
        "{\"X\":201,\"Y\":167,\"IsEmpty\":false},{\"X\":200,\"Y\":166,\"IsEmpty\":false},{\"X\":199,\"Y\":164,\"IsEmpty\":false},{\"X\":198,\"Y\":163,\"IsEmpty\":false}," +
        "{\"X\":197,\"Y\":161,\"IsEmpty\":false},{\"X\":196,\"Y\":160,\"IsEmpty\":false},{\"X\":194,\"Y\":158,\"IsEmpty\":false},{\"X\":193,\"Y\":156,\"IsEmpty\":false}," +
        "{\"X\":191,\"Y\":155,\"IsEmpty\":false},{\"X\":191,\"Y\":154,\"IsEmpty\":false},{\"X\":190,\"Y\":153,\"IsEmpty\":false},{\"X\":190,\"Y\":152,\"IsEmpty\":false}," +
        "{\"X\":189,\"Y\":152,\"IsEmpty\":false}],\"Granularity\":5,\"ShouldSmoothPathWhenDrawn\":true}]";
}
