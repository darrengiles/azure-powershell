// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>Base tracked resource type for PATCH updates</summary>
    public partial class TrackedResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.ITrackedResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.ITrackedResourceUpdateInternal
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="TrackedResourceUpdate" /> instance.</summary>
        public TrackedResourceUpdate()
        {

        }
    }
    /// Base tracked resource type for PATCH updates
    public partial interface ITrackedResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable
    {
        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The geo-location where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.ITags Tag { get; set; }

    }
    /// Base tracked resource type for PATCH updates
    internal partial interface ITrackedResourceUpdateInternal

    {
        /// <summary>The geo-location where the resource lives</summary>
        string Location { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.ITags Tag { get; set; }

    }
}