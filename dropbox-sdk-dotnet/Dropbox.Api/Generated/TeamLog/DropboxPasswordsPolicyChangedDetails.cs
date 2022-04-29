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
    /// <para>Changed Dropbox Passwords policy for team.</para>
    /// </summary>
    public class DropboxPasswordsPolicyChangedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DropboxPasswordsPolicyChangedDetails> Encoder = new DropboxPasswordsPolicyChangedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DropboxPasswordsPolicyChangedDetails> Decoder = new DropboxPasswordsPolicyChangedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DropboxPasswordsPolicyChangedDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">To.</param>
        /// <param name="previousValue">From.</param>
        public DropboxPasswordsPolicyChangedDetails(DropboxPasswordsPolicy newValue,
                                                    DropboxPasswordsPolicy previousValue)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DropboxPasswordsPolicyChangedDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DropboxPasswordsPolicyChangedDetails()
        {
        }

        /// <summary>
        /// <para>To.</para>
        /// </summary>
        public DropboxPasswordsPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>From.</para>
        /// </summary>
        public DropboxPasswordsPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DropboxPasswordsPolicyChangedDetails" />.</para>
        /// </summary>
        private class DropboxPasswordsPolicyChangedDetailsEncoder : enc.StructEncoder<DropboxPasswordsPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DropboxPasswordsPolicyChangedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.DropboxPasswordsPolicy.Encoder);
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.DropboxPasswordsPolicy.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DropboxPasswordsPolicyChangedDetails" />.</para>
        /// </summary>
        private class DropboxPasswordsPolicyChangedDetailsDecoder : enc.StructDecoder<DropboxPasswordsPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="DropboxPasswordsPolicyChangedDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DropboxPasswordsPolicyChangedDetails Create()
            {
                return new DropboxPasswordsPolicyChangedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DropboxPasswordsPolicyChangedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.DropboxPasswordsPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.DropboxPasswordsPolicy.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}