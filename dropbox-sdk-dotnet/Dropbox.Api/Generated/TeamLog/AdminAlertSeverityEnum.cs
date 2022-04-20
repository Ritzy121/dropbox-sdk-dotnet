// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Alert severity</para>
    /// </summary>
    public class AdminAlertSeverityEnum
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AdminAlertSeverityEnum> Encoder = new AdminAlertSeverityEnumEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AdminAlertSeverityEnum> Decoder = new AdminAlertSeverityEnumDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AdminAlertSeverityEnum" />
        /// class.</para>
        /// </summary>
        public AdminAlertSeverityEnum()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is High</para>
        /// </summary>
        public bool IsHigh
        {
            get
            {
                return this is High;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a High, or <c>null</c>.</para>
        /// </summary>
        public High AsHigh
        {
            get
            {
                return this as High;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Info</para>
        /// </summary>
        public bool IsInfo
        {
            get
            {
                return this is Info;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Info, or <c>null</c>.</para>
        /// </summary>
        public Info AsInfo
        {
            get
            {
                return this as Info;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Low</para>
        /// </summary>
        public bool IsLow
        {
            get
            {
                return this is Low;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Low, or <c>null</c>.</para>
        /// </summary>
        public Low AsLow
        {
            get
            {
                return this as Low;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Medium</para>
        /// </summary>
        public bool IsMedium
        {
            get
            {
                return this is Medium;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Medium, or <c>null</c>.</para>
        /// </summary>
        public Medium AsMedium
        {
            get
            {
                return this as Medium;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Na</para>
        /// </summary>
        public bool IsNa
        {
            get
            {
                return this is Na;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Na, or <c>null</c>.</para>
        /// </summary>
        public Na AsNa
        {
            get
            {
                return this as Na;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AdminAlertSeverityEnum" />.</para>
        /// </summary>
        private class AdminAlertSeverityEnumEncoder : enc.StructEncoder<AdminAlertSeverityEnum>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AdminAlertSeverityEnum value, enc.IJsonWriter writer)
            {
                if (value is High)
                {
                    WriteProperty(".tag", "high", writer, enc.StringEncoder.Instance);
                    High.Encoder.EncodeFields((High)value, writer);
                    return;
                }
                if (value is Info)
                {
                    WriteProperty(".tag", "info", writer, enc.StringEncoder.Instance);
                    Info.Encoder.EncodeFields((Info)value, writer);
                    return;
                }
                if (value is Low)
                {
                    WriteProperty(".tag", "low", writer, enc.StringEncoder.Instance);
                    Low.Encoder.EncodeFields((Low)value, writer);
                    return;
                }
                if (value is Medium)
                {
                    WriteProperty(".tag", "medium", writer, enc.StringEncoder.Instance);
                    Medium.Encoder.EncodeFields((Medium)value, writer);
                    return;
                }
                if (value is Na)
                {
                    WriteProperty(".tag", "na", writer, enc.StringEncoder.Instance);
                    Na.Encoder.EncodeFields((Na)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AdminAlertSeverityEnum" />.</para>
        /// </summary>
        private class AdminAlertSeverityEnumDecoder : enc.UnionDecoder<AdminAlertSeverityEnum>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AdminAlertSeverityEnum"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AdminAlertSeverityEnum Create()
            {
                return new AdminAlertSeverityEnum();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override AdminAlertSeverityEnum Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "high":
                        return High.Decoder.DecodeFields(reader);
                    case "info":
                        return Info.Decoder.DecodeFields(reader);
                    case "low":
                        return Low.Decoder.DecodeFields(reader);
                    case "medium":
                        return Medium.Decoder.DecodeFields(reader);
                    case "na":
                        return Na.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The high object</para>
        /// </summary>
        public sealed class High : AdminAlertSeverityEnum
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<High> Encoder = new HighEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<High> Decoder = new HighDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="High" /> class.</para>
            /// </summary>
            private High()
            {
            }

            /// <summary>
            /// <para>A singleton instance of High</para>
            /// </summary>
            public static readonly High Instance = new High();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="High" />.</para>
            /// </summary>
            private class HighEncoder : enc.StructEncoder<High>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(High value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="High" />.</para>
            /// </summary>
            private class HighDecoder : enc.StructDecoder<High>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="High" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override High Create()
                {
                    return High.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The info object</para>
        /// </summary>
        public sealed class Info : AdminAlertSeverityEnum
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Info> Encoder = new InfoEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Info> Decoder = new InfoDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Info" /> class.</para>
            /// </summary>
            private Info()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Info</para>
            /// </summary>
            public static readonly Info Instance = new Info();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Info" />.</para>
            /// </summary>
            private class InfoEncoder : enc.StructEncoder<Info>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Info value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Info" />.</para>
            /// </summary>
            private class InfoDecoder : enc.StructDecoder<Info>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Info" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Info Create()
                {
                    return Info.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The low object</para>
        /// </summary>
        public sealed class Low : AdminAlertSeverityEnum
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Low> Encoder = new LowEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Low> Decoder = new LowDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Low" /> class.</para>
            /// </summary>
            private Low()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Low</para>
            /// </summary>
            public static readonly Low Instance = new Low();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Low" />.</para>
            /// </summary>
            private class LowEncoder : enc.StructEncoder<Low>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Low value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Low" />.</para>
            /// </summary>
            private class LowDecoder : enc.StructDecoder<Low>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Low" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Low Create()
                {
                    return Low.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The medium object</para>
        /// </summary>
        public sealed class Medium : AdminAlertSeverityEnum
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Medium> Encoder = new MediumEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Medium> Decoder = new MediumDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Medium" /> class.</para>
            /// </summary>
            private Medium()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Medium</para>
            /// </summary>
            public static readonly Medium Instance = new Medium();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Medium" />.</para>
            /// </summary>
            private class MediumEncoder : enc.StructEncoder<Medium>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Medium value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Medium" />.</para>
            /// </summary>
            private class MediumDecoder : enc.StructDecoder<Medium>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Medium" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Medium Create()
                {
                    return Medium.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The na object</para>
        /// </summary>
        public sealed class Na : AdminAlertSeverityEnum
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Na> Encoder = new NaEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Na> Decoder = new NaDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Na" /> class.</para>
            /// </summary>
            private Na()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Na</para>
            /// </summary>
            public static readonly Na Instance = new Na();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Na" />.</para>
            /// </summary>
            private class NaEncoder : enc.StructEncoder<Na>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Na value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Na" />.</para>
            /// </summary>
            private class NaDecoder : enc.StructDecoder<Na>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Na" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Na Create()
                {
                    return Na.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : AdminAlertSeverityEnum
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}