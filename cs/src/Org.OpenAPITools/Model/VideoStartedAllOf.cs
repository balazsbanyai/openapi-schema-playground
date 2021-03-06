/* 
 * Events
 *
 * Polymorphism example
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// VideoStartedAllOf
    /// </summary>
    [DataContract]
    public partial class VideoStartedAllOf :  IEquatable<VideoStartedAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoStartedAllOf" /> class.
        /// </summary>
        /// <param name="videoUrl">videoUrl.</param>
        public VideoStartedAllOf(string videoUrl = default(string))
        {
            this.VideoUrl = videoUrl;
        }
        
        /// <summary>
        /// Gets or Sets VideoUrl
        /// </summary>
        [DataMember(Name="videoUrl", EmitDefaultValue=false)]
        public string VideoUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoStartedAllOf {\n");
            sb.Append("  VideoUrl: ").Append(VideoUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoStartedAllOf);
        }

        /// <summary>
        /// Returns true if VideoStartedAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoStartedAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoStartedAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VideoUrl == input.VideoUrl ||
                    (this.VideoUrl != null &&
                    this.VideoUrl.Equals(input.VideoUrl))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.VideoUrl != null)
                    hashCode = hashCode * 59 + this.VideoUrl.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
