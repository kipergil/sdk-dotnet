/* 
 * directus.io
 *
 * API for directus.io
 *
 * OpenAPI spec version: 1.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Directus.Client.SwaggerDateConverter;

namespace IO.Directus.Model
{
    /// <summary>
    /// GetGroupsDataData
    /// </summary>
    [DataContract]
    public partial class GetGroupsDataData :  IEquatable<GetGroupsDataData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGroupsDataData" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="RestrictToIpWhitelist">RestrictToIpWhitelist.</param>
        /// <param name="NavOverride">NavOverride.</param>
        /// <param name="ShowActivity">ShowActivity.</param>
        /// <param name="ShowMessages">ShowMessages.</param>
        /// <param name="ShowUsers">ShowUsers.</param>
        /// <param name="ShowFiles">ShowFiles.</param>
        public GetGroupsDataData(int? Id = default(int?), string Name = default(string), string Description = default(string), string RestrictToIpWhitelist = default(string), string NavOverride = default(string), int? ShowActivity = default(int?), int? ShowMessages = default(int?), int? ShowUsers = default(int?), int? ShowFiles = default(int?))
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.RestrictToIpWhitelist = RestrictToIpWhitelist;
            this.NavOverride = NavOverride;
            this.ShowActivity = ShowActivity;
            this.ShowMessages = ShowMessages;
            this.ShowUsers = ShowUsers;
            this.ShowFiles = ShowFiles;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RestrictToIpWhitelist
        /// </summary>
        [DataMember(Name="restrict_to_ip_whitelist", EmitDefaultValue=false)]
        public string RestrictToIpWhitelist { get; set; }

        /// <summary>
        /// Gets or Sets NavOverride
        /// </summary>
        [DataMember(Name="nav_override", EmitDefaultValue=false)]
        public string NavOverride { get; set; }

        /// <summary>
        /// Gets or Sets ShowActivity
        /// </summary>
        [DataMember(Name="show_activity", EmitDefaultValue=false)]
        public int? ShowActivity { get; set; }

        /// <summary>
        /// Gets or Sets ShowMessages
        /// </summary>
        [DataMember(Name="show_messages", EmitDefaultValue=false)]
        public int? ShowMessages { get; set; }

        /// <summary>
        /// Gets or Sets ShowUsers
        /// </summary>
        [DataMember(Name="show_users", EmitDefaultValue=false)]
        public int? ShowUsers { get; set; }

        /// <summary>
        /// Gets or Sets ShowFiles
        /// </summary>
        [DataMember(Name="show_files", EmitDefaultValue=false)]
        public int? ShowFiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetGroupsDataData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RestrictToIpWhitelist: ").Append(RestrictToIpWhitelist).Append("\n");
            sb.Append("  NavOverride: ").Append(NavOverride).Append("\n");
            sb.Append("  ShowActivity: ").Append(ShowActivity).Append("\n");
            sb.Append("  ShowMessages: ").Append(ShowMessages).Append("\n");
            sb.Append("  ShowUsers: ").Append(ShowUsers).Append("\n");
            sb.Append("  ShowFiles: ").Append(ShowFiles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as GetGroupsDataData);
        }

        /// <summary>
        /// Returns true if GetGroupsDataData instances are equal
        /// </summary>
        /// <param name="input">Instance of GetGroupsDataData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetGroupsDataData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.RestrictToIpWhitelist == input.RestrictToIpWhitelist ||
                    (this.RestrictToIpWhitelist != null &&
                    this.RestrictToIpWhitelist.Equals(input.RestrictToIpWhitelist))
                ) && 
                (
                    this.NavOverride == input.NavOverride ||
                    (this.NavOverride != null &&
                    this.NavOverride.Equals(input.NavOverride))
                ) && 
                (
                    this.ShowActivity == input.ShowActivity ||
                    (this.ShowActivity != null &&
                    this.ShowActivity.Equals(input.ShowActivity))
                ) && 
                (
                    this.ShowMessages == input.ShowMessages ||
                    (this.ShowMessages != null &&
                    this.ShowMessages.Equals(input.ShowMessages))
                ) && 
                (
                    this.ShowUsers == input.ShowUsers ||
                    (this.ShowUsers != null &&
                    this.ShowUsers.Equals(input.ShowUsers))
                ) && 
                (
                    this.ShowFiles == input.ShowFiles ||
                    (this.ShowFiles != null &&
                    this.ShowFiles.Equals(input.ShowFiles))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RestrictToIpWhitelist != null)
                    hashCode = hashCode * 59 + this.RestrictToIpWhitelist.GetHashCode();
                if (this.NavOverride != null)
                    hashCode = hashCode * 59 + this.NavOverride.GetHashCode();
                if (this.ShowActivity != null)
                    hashCode = hashCode * 59 + this.ShowActivity.GetHashCode();
                if (this.ShowMessages != null)
                    hashCode = hashCode * 59 + this.ShowMessages.GetHashCode();
                if (this.ShowUsers != null)
                    hashCode = hashCode * 59 + this.ShowUsers.GetHashCode();
                if (this.ShowFiles != null)
                    hashCode = hashCode * 59 + this.ShowFiles.GetHashCode();
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
