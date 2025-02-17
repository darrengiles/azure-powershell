// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ItemLevelRecoveryConnectionsOperations operations.
    /// </summary>
    public partial interface IItemLevelRecoveryConnectionsOperations
    {
        /// <summary>
        /// Provisions a script which invokes an iSCSI connection to the backup data.
        /// Executing this script opens a file
        /// explorer displaying all the recoverable files and folders. This is an
        /// asynchronous operation. To know the status of
        /// provisioning, call GetProtectedItemOperationResult API.
        /// </summary>
        /// <remarks>
        /// Provisions a script which invokes an iSCSI connection to the backup data.
        /// Executing this script opens a file
        /// explorer displaying all the recoverable files and folders. This is an
        /// asynchronous operation. To know the status of
        /// provisioning, call GetProtectedItemOperationResult API.
        /// </remarks>
        /// <param name='vaultName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name associated with the backed up items.
        /// </param>
        /// <param name='containerName'>
        /// Container name associated with the backed up items.
        /// </param>
        /// <param name='protectedItemName'>
        /// Backed up item name whose files/folders are to be restored.
        /// </param>
        /// <param name='recoveryPointId'>
        /// Recovery point ID which represents backed up data. iSCSI connection will be
        /// provisioned
        /// for this backed up data.
        /// </param>
        /// <param name='parameters'>
        /// resource ILR request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> ProvisionWithHttpMessagesAsync(string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, ILRRequestResource parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Revokes an iSCSI connection which can be used to download a script.
        /// Executing this script opens a file explorer
        /// displaying all recoverable files and folders. This is an asynchronous
        /// operation.
        /// </summary>
        /// <remarks>
        /// Revokes an iSCSI connection which can be used to download a script.
        /// Executing this script opens a file explorer
        /// displaying all recoverable files and folders. This is an asynchronous
        /// operation.
        /// </remarks>
        /// <param name='vaultName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name associated with the backed up items.
        /// </param>
        /// <param name='containerName'>
        /// Container name associated with the backed up items.
        /// </param>
        /// <param name='protectedItemName'>
        /// Backed up item name whose files/folders are to be restored.
        /// </param>
        /// <param name='recoveryPointId'>
        /// Recovery point ID which represents backed up data. iSCSI connection will be
        /// revoked for
        /// this backed up data.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> RevokeWithHttpMessagesAsync(string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}