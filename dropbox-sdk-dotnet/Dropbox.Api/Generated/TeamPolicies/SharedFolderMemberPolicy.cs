// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamPolicies
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Policy governing who can be a member of a folder shared by a team member.</para>
    /// </summary>
    public class SharedFolderMemberPolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderMemberPolicy> Encoder = new SharedFolderMemberPolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderMemberPolicy> Decoder = new SharedFolderMemberPolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderMemberPolicy" />
        /// class.</para>
        /// </summary>
        public SharedFolderMemberPolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Team</para>
        /// </summary>
        public bool IsTeam
        {
            get
            {
                return this is Team;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Team, or <c>null</c>.</para>
        /// </summary>
        public Team AsTeam
        {
            get
            {
                return this as Team;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Anyone</para>
        /// </summary>
        public bool IsAnyone
        {
            get
            {
                return this is Anyone;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Anyone, or <c>null</c>.</para>
        /// </summary>
        public Anyone AsAnyone
        {
            get
            {
                return this as Anyone;
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
        /// <para>Encoder for  <see cref="SharedFolderMemberPolicy" />.</para>
        /// </summary>
        private class SharedFolderMemberPolicyEncoder : enc.StructEncoder<SharedFolderMemberPolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderMemberPolicy value, enc.IJsonWriter writer)
            {
                if (value is Team)
                {
                    WriteProperty(".tag", "team", writer, enc.StringEncoder.Instance);
                    Team.Encoder.EncodeFields((Team)value, writer);
                    return;
                }
                if (value is Anyone)
                {
                    WriteProperty(".tag", "anyone", writer, enc.StringEncoder.Instance);
                    Anyone.Encoder.EncodeFields((Anyone)value, writer);
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
        /// <para>Decoder for  <see cref="SharedFolderMemberPolicy" />.</para>
        /// </summary>
        private class SharedFolderMemberPolicyDecoder : enc.UnionDecoder<SharedFolderMemberPolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedFolderMemberPolicy"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderMemberPolicy Create()
            {
                return new SharedFolderMemberPolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SharedFolderMemberPolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "team":
                        return Team.Decoder.DecodeFields(reader);
                    case "anyone":
                        return Anyone.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Only a teammate can be a member of a folder shared by a team member.</para>
        /// </summary>
        public sealed class Team : SharedFolderMemberPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Team> Encoder = new TeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Team> Decoder = new TeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Team" /> class.</para>
            /// </summary>
            private Team()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Team</para>
            /// </summary>
            public static readonly Team Instance = new Team();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Team" />.</para>
            /// </summary>
            private class TeamEncoder : enc.StructEncoder<Team>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Team value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Team" />.</para>
            /// </summary>
            private class TeamDecoder : enc.StructDecoder<Team>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Team" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Team Create()
                {
                    return Team.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Anyone can be a member of a folder shared by a team member.</para>
        /// </summary>
        public sealed class Anyone : SharedFolderMemberPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Anyone> Encoder = new AnyoneEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Anyone> Decoder = new AnyoneDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Anyone" /> class.</para>
            /// </summary>
            private Anyone()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Anyone</para>
            /// </summary>
            public static readonly Anyone Instance = new Anyone();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Anyone" />.</para>
            /// </summary>
            private class AnyoneEncoder : enc.StructEncoder<Anyone>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Anyone value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Anyone" />.</para>
            /// </summary>
            private class AnyoneDecoder : enc.StructDecoder<Anyone>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Anyone" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Anyone Create()
                {
                    return Anyone.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : SharedFolderMemberPolicy
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