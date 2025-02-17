---
external help file: Az.StackHCIVM-help.xml
Module Name: Az.StackHCIVM
online version: https://learn.microsoft.com/powershell/module/az.stackhcivm/remove-azstackhcivmvirtualmachinenetworkinterface
schema: 2.0.0
---

# Remove-AzStackHCIVMVirtualMachineNetworkInterface

## SYNOPSIS
The operation to delete a network interface from a virtual machine.

## SYNTAX

### ByResourceId (Default)
```
Remove-AzStackHCIVMVirtualMachineNetworkInterface -ResourceId <String> [-NicId <String[]>]
 [-NicName <String[]>] [-NicResourceGroup <String>] [-NoWait] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### ByName
```
Remove-AzStackHCIVMVirtualMachineNetworkInterface -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String>] [-NicId <String[]>] [-NicName <String[]>] [-NicResourceGroup <String>] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The operation to delete a network interface from a  virtual machine.

## EXAMPLES

### EXAMPLE 1
```
Remove-AzStackHCIVMVirtualMachineNetworkInterface  -Name "testVm" -ResourceGroupName "test-rg"  -NicName 'testNic'
```

## PARAMETERS

### -Name
Name of the virtual machine

```yaml
Type: System.String
Parameter Sets: ByName
Aliases: VirtualMachineName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NicId
NetworkInterfaces - list of network interfaces to be attached from  the virtual machine in id format.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NicName
NetworkInterfaces - list of network interfaces to be removed from the virtual machine in name format.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NicResourceGroup
NetworkInterfaces - resource group of the network interfaces

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: ByName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceId
The ARM Resource ID of the virtual machine.

```yaml
Type: System.String
Parameter Sets: ByResourceId
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: ByName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstance
## NOTES

## RELATED LINKS

[https://learn.microsoft.com/powershell/module/az.stackhcivm/remove-azstackhcivmvirtualmachinenetworkinterface](https://learn.microsoft.com/powershell/module/az.stackhcivm/remove-azstackhcivmvirtualmachinenetworkinterface)
