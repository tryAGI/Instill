
#nullable enable

namespace Instill
{
    /// <summary>
    /// - CHUNK_TYPE_TEXT: text<br/>
    ///  - CHUNK_TYPE_IMAGE: image<br/>
    ///  - CHUNK_TYPE_AUDIO: audio<br/>
    ///  - CHUNK_TYPE_VIDEO: video
    /// </summary>
    public enum GetFileCatalogResponseChunkType
    {
        /// <summary>
        /// text
        /// </summary>
        CHUNKTYPETEXT,
        /// <summary>
        /// image
        /// </summary>
        CHUNKTYPEIMAGE,
        /// <summary>
        /// audio
        /// </summary>
        CHUNKTYPEAUDIO,
        /// <summary>
        /// video
        /// </summary>
        CHUNKTYPEVIDEO,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFileCatalogResponseChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFileCatalogResponseChunkType value)
        {
            return value switch
            {
                GetFileCatalogResponseChunkType.CHUNKTYPETEXT => "CHUNK_TYPE_TEXT",
                GetFileCatalogResponseChunkType.CHUNKTYPEIMAGE => "CHUNK_TYPE_IMAGE",
                GetFileCatalogResponseChunkType.CHUNKTYPEAUDIO => "CHUNK_TYPE_AUDIO",
                GetFileCatalogResponseChunkType.CHUNKTYPEVIDEO => "CHUNK_TYPE_VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFileCatalogResponseChunkType? ToEnum(string value)
        {
            return value switch
            {
                "CHUNK_TYPE_TEXT" => GetFileCatalogResponseChunkType.CHUNKTYPETEXT,
                "CHUNK_TYPE_IMAGE" => GetFileCatalogResponseChunkType.CHUNKTYPEIMAGE,
                "CHUNK_TYPE_AUDIO" => GetFileCatalogResponseChunkType.CHUNKTYPEAUDIO,
                "CHUNK_TYPE_VIDEO" => GetFileCatalogResponseChunkType.CHUNKTYPEVIDEO,
                _ => null,
            };
        }
    }
}