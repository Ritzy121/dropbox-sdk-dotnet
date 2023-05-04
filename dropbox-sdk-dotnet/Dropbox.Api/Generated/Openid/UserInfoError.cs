// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Openid
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The user info error object</para>
    /// </summary>
    public class UserInfoError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UserInfoError> Encoder = new UserInfoErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UserInfoError> Decoder = new UserInfoErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserInfoError" /> class.</para>
        /// </summary>
        public UserInfoError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is OpenidError</para>
        /// </summary>
        public bool IsOpenidError
        {
            get
            {
                return this is OpenidError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a OpenidError, or <c>null</c>.</para>
        /// </summary>
        public OpenidError AsOpenidError
        {
            get
            {
                return this as OpenidError;
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
        /// <para>Encoder for  <see cref="UserInfoError" />.</para>
        /// </summary>
        private class UserInfoErrorEncoder : enc.StructEncoder<UserInfoError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UserInfoError value, enc.IJsonWriter writer)
            {
                if (value is OpenidError)
                {
                    WriteProperty(".tag", "openid_error", writer, enc.StringEncoder.Instance);
                    OpenidError.Encoder.EncodeFields((OpenidError)value, writer);
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
        /// <para>Decoder for  <see cref="UserInfoError" />.</para>
        /// </summary>
        private class UserInfoErrorDecoder : enc.UnionDecoder<UserInfoError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UserInfoError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UserInfoError Create()
            {
                return new UserInfoError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override UserInfoError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "openid_error":
                        return OpenidError.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The openid error object</para>
        /// </summary>
        public sealed class OpenidError : UserInfoError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<OpenidError> Encoder = new OpenidErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<OpenidError> Decoder = new OpenidErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="OpenidError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public OpenidError(OpenIdError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="OpenidError" />
            /// class.</para>
            /// </summary>
            private OpenidError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public OpenIdError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="OpenidError" />.</para>
            /// </summary>
            private class OpenidErrorEncoder : enc.StructEncoder<OpenidError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(OpenidError value, enc.IJsonWriter writer)
                {
                    WriteProperty("openid_error", value.Value, writer, global::Dropbox.Api.Openid.OpenIdError.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="OpenidError" />.</para>
            /// </summary>
            private class OpenidErrorDecoder : enc.StructDecoder<OpenidError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="OpenidError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override OpenidError Create()
                {
                    return new OpenidError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(OpenidError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "openid_error":
                            value.Value = global::Dropbox.Api.Openid.OpenIdError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : UserInfoError
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