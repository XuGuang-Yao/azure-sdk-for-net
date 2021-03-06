// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines modifiable attributes of an Experiment
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ExperimentUpdateModel
    {
        /// <summary>
        /// Initializes a new instance of the ExperimentUpdateModel class.
        /// </summary>
        public ExperimentUpdateModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExperimentUpdateModel class.
        /// </summary>
        /// <param name="tags">Resource tags.</param>
        /// <param name="description">The description of the intent or details
        /// of the Experiment</param>
        /// <param name="enabledState">The state of the Experiment. Possible
        /// values include: 'Enabled', 'Disabled'</param>
        public ExperimentUpdateModel(IDictionary<string, string> tags = default(IDictionary<string, string>), string description = default(string), string enabledState = default(string))
        {
            Tags = tags;
            Description = description;
            EnabledState = enabledState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the description of the intent or details of the
        /// Experiment
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the state of the Experiment. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledState")]
        public string EnabledState { get; set; }

    }
}
