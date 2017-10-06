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
    /// <para>Merged this team into another team.</para>
    /// </summary>
    public class TeamMergeToDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamMergeToDetails> Encoder = new TeamMergeToDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamMergeToDetails> Decoder = new TeamMergeToDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamMergeToDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="teamName">The name of the team that this team was merged into.</param>
        public TeamMergeToDetails(string teamName)
        {
            if (teamName == null)
            {
                throw new sys.ArgumentNullException("teamName");
            }

            this.TeamName = teamName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamMergeToDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamMergeToDetails()
        {
        }

        /// <summary>
        /// <para>The name of the team that this team was merged into.</para>
        /// </summary>
        public string TeamName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamMergeToDetails" />.</para>
        /// </summary>
        private class TeamMergeToDetailsEncoder : enc.StructEncoder<TeamMergeToDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamMergeToDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("team_name", value.TeamName, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamMergeToDetails" />.</para>
        /// </summary>
        private class TeamMergeToDetailsDecoder : enc.StructDecoder<TeamMergeToDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamMergeToDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamMergeToDetails Create()
            {
                return new TeamMergeToDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamMergeToDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "team_name":
                        value.TeamName = enc.StringDecoder.Instance.Decode(reader);
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