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
    /// <para>Downloaded export for a hold.</para>
    /// </summary>
    public class LegalHoldsExportDownloadedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LegalHoldsExportDownloadedDetails> Encoder = new LegalHoldsExportDownloadedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LegalHoldsExportDownloadedDetails> Decoder = new LegalHoldsExportDownloadedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="LegalHoldsExportDownloadedDetails" /> class.</para>
        /// </summary>
        /// <param name="legalHoldId">Hold ID.</param>
        /// <param name="name">Hold name.</param>
        /// <param name="exportName">Export name.</param>
        /// <param name="part">Part.</param>
        /// <param name="fileName">Filename.</param>
        public LegalHoldsExportDownloadedDetails(string legalHoldId,
                                                 string name,
                                                 string exportName,
                                                 string part = null,
                                                 string fileName = null)
        {
            if (legalHoldId == null)
            {
                throw new sys.ArgumentNullException("legalHoldId");
            }

            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            if (exportName == null)
            {
                throw new sys.ArgumentNullException("exportName");
            }

            this.LegalHoldId = legalHoldId;
            this.Name = name;
            this.ExportName = exportName;
            this.Part = part;
            this.FileName = fileName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="LegalHoldsExportDownloadedDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LegalHoldsExportDownloadedDetails()
        {
        }

        /// <summary>
        /// <para>Hold ID.</para>
        /// </summary>
        public string LegalHoldId { get; protected set; }

        /// <summary>
        /// <para>Hold name.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>Export name.</para>
        /// </summary>
        public string ExportName { get; protected set; }

        /// <summary>
        /// <para>Part.</para>
        /// </summary>
        public string Part { get; protected set; }

        /// <summary>
        /// <para>Filename.</para>
        /// </summary>
        public string FileName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LegalHoldsExportDownloadedDetails" />.</para>
        /// </summary>
        private class LegalHoldsExportDownloadedDetailsEncoder : enc.StructEncoder<LegalHoldsExportDownloadedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LegalHoldsExportDownloadedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("legal_hold_id", value.LegalHoldId, writer, enc.StringEncoder.Instance);
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("export_name", value.ExportName, writer, enc.StringEncoder.Instance);
                if (value.Part != null)
                {
                    WriteProperty("part", value.Part, writer, enc.StringEncoder.Instance);
                }
                if (value.FileName != null)
                {
                    WriteProperty("file_name", value.FileName, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LegalHoldsExportDownloadedDetails" />.</para>
        /// </summary>
        private class LegalHoldsExportDownloadedDetailsDecoder : enc.StructDecoder<LegalHoldsExportDownloadedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="LegalHoldsExportDownloadedDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LegalHoldsExportDownloadedDetails Create()
            {
                return new LegalHoldsExportDownloadedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LegalHoldsExportDownloadedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "legal_hold_id":
                        value.LegalHoldId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "export_name":
                        value.ExportName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "part":
                        value.Part = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "file_name":
                        value.FileName = enc.StringDecoder.Instance.Decode(reader);
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