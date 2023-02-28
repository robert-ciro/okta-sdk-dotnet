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
    /// Defines RiskEventSubjectRiskLevel
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class RiskEventSubjectRiskLevel : StringEnum
    {
        /// <summary>
        /// StringEnum RiskEventSubjectRiskLevel for value: HIGH
        /// </summary>
        public static RiskEventSubjectRiskLevel HIGH = new RiskEventSubjectRiskLevel("HIGH");
        /// <summary>
        /// StringEnum RiskEventSubjectRiskLevel for value: LOW
        /// </summary>
        public static RiskEventSubjectRiskLevel LOW = new RiskEventSubjectRiskLevel("LOW");
        /// <summary>
        /// StringEnum RiskEventSubjectRiskLevel for value: MEDIUM
        /// </summary>
        public static RiskEventSubjectRiskLevel MEDIUM = new RiskEventSubjectRiskLevel("MEDIUM");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="RiskEventSubjectRiskLevel"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator RiskEventSubjectRiskLevel(string value) => new RiskEventSubjectRiskLevel(value);

        /// <summary>
        /// Creates a new <see cref="RiskEventSubjectRiskLevel"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public RiskEventSubjectRiskLevel(string value)
            : base(value)
        {
        }
    }


}