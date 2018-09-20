// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The storage account credential
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageAccountCredential : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountCredential class.
        /// </summary>
        public StorageAccountCredential()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountCredential class.
        /// </summary>
        /// <param name="cloudType">The cloud service provider. Possible values
        /// include: 'Azure', 'S3', 'S3_RRS', 'OpenStack', 'HP'</param>
        /// <param name="endPoint">The storage endpoint</param>
        /// <param name="login">The storage account login</param>
        /// <param name="enableSSL">SSL needs to be enabled or not. Possible
        /// values include: 'Enabled', 'Disabled'</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="location">The storage account's geo location</param>
        /// <param name="accessKey">The details of the storage account
        /// password</param>
        public StorageAccountCredential(CloudType cloudType, string endPoint, string login, SslStatus enableSSL, string id = default(string), string name = default(string), string type = default(string), string location = default(string), AsymmetricEncryptedSecret accessKey = default(AsymmetricEncryptedSecret))
            : base(id, name, type)
        {
            CloudType = cloudType;
            EndPoint = endPoint;
            Login = login;
            Location = location;
            EnableSSL = enableSSL;
            AccessKey = accessKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the cloud service provider. Possible values include:
        /// 'Azure', 'S3', 'S3_RRS', 'OpenStack', 'HP'
        /// </summary>
        [JsonProperty(PropertyName = "properties.cloudType")]
        public CloudType CloudType { get; set; }

        /// <summary>
        /// Gets or sets the storage endpoint
        /// </summary>
        [JsonProperty(PropertyName = "properties.endPoint")]
        public string EndPoint { get; set; }

        /// <summary>
        /// Gets or sets the storage account login
        /// </summary>
        [JsonProperty(PropertyName = "properties.login")]
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets the storage account's geo location
        /// </summary>
        [JsonProperty(PropertyName = "properties.location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets SSL needs to be enabled or not. Possible values
        /// include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableSSL")]
        public SslStatus EnableSSL { get; set; }

        /// <summary>
        /// Gets or sets the details of the storage account password
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessKey")]
        public AsymmetricEncryptedSecret AccessKey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EndPoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EndPoint");
            }
            if (Login == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Login");
            }
            if (AccessKey != null)
            {
                AccessKey.Validate();
            }
        }
    }
}
