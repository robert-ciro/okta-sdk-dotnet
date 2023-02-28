/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// ResourceSetBindingResponseLinks
    /// </summary>
    [DataContract(Name = "ResourceSetBindingResponse__links")]
    
    public partial class ResourceSetBindingResponseLinks : IEquatable<ResourceSetBindingResponseLinks>
    {
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public HrefObject Self { get; set; }

        /// <summary>
        /// Gets or Sets Bindings
        /// </summary>
        [DataMember(Name = "bindings", EmitDefaultValue = false)]
        public HrefObject Bindings { get; set; }

        /// <summary>
        /// Gets or Sets ResourceSet
        /// </summary>
        [DataMember(Name = "resource-set", EmitDefaultValue = false)]
        public HrefObject ResourceSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResourceSetBindingResponseLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Bindings: ").Append(Bindings).Append("\n");
            sb.Append("  ResourceSet: ").Append(ResourceSet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceSetBindingResponseLinks);
        }

        /// <summary>
        /// Returns true if ResourceSetBindingResponseLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceSetBindingResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceSetBindingResponseLinks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Bindings == input.Bindings ||
                    (this.Bindings != null &&
                    this.Bindings.Equals(input.Bindings))
                ) && 
                (
                    this.ResourceSet == input.ResourceSet ||
                    (this.ResourceSet != null &&
                    this.ResourceSet.Equals(input.ResourceSet))
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
                
                if (this.Self != null)
                {
                    hashCode = (hashCode * 59) + this.Self.GetHashCode();
                }
                if (this.Bindings != null)
                {
                    hashCode = (hashCode * 59) + this.Bindings.GetHashCode();
                }
                if (this.ResourceSet != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceSet.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}