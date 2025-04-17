using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Power
{
	// Token: 0x02000519 RID: 1305
	public class PowerNode : MonoBehaviour
	{
		// Token: 0x0600743B RID: 29755 RVA: 0x001FAD68 File Offset: 0x001F8F68
		// Note: this type is marked as 'beforefieldinit'.
		static PowerNode()
		{
			Il2CppClassPointerStore<PowerNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Power", "PowerNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerNode>.NativeClassPtr);
			PowerNode.NativeFieldInfoPtr_poweredNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "poweredNode");
			PowerNode.NativeFieldInfoPtr_consumptionNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "consumptionNode");
			PowerNode.NativeFieldInfoPtr_isConnectedToPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "isConnectedToPower");
			PowerNode.NativeFieldInfoPtr_connectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "connectionPoint");
			PowerNode.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "connections");
			PowerNode.NativeMethodInfoPtr_get_pConnectionPoint_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100677913);
			PowerNode.NativeMethodInfoPtr_IsConnectedTo_Public_Boolean_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100677914);
			PowerNode.NativeMethodInfoPtr_RecalculatePowerNetwork_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100677915);
			PowerNode.NativeMethodInfoPtr_GetConnectedNodes_Public_List_1_PowerNode_List_1_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100677916);
			PowerNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100677917);
		}

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x0600743C RID: 29756 RVA: 0x001FAE60 File Offset: 0x001F9060
		public unsafe Transform pConnectionPoint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr_get_pConnectionPoint_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x001FAEA0 File Offset: 0x001F90A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227208, XrefRangeEnd = 227225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsConnectedTo(PowerNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr_IsConnectedTo_Public_Boolean_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600743E RID: 29758 RVA: 0x001FAEF0 File Offset: 0x001F90F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227257, RefRangeEnd = 227260, XrefRangeStart = 227225, XrefRangeEnd = 227257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculatePowerNetwork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr_RecalculatePowerNetwork_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x001FAF24 File Offset: 0x001F9124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227293, RefRangeEnd = 227295, XrefRangeStart = 227260, XrefRangeEnd = 227293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PowerNode> GetConnectedNodes(List<PowerNode> exclusions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exclusions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr_GetConnectedNodes_Public_List_1_PowerNode_List_1_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PowerNode>>(intPtr3) : null;
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x001FAF74 File Offset: 0x001F9174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227295, XrefRangeEnd = 227303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x00037333 File Offset: 0x00035533
		public PowerNode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x06007442 RID: 29762 RVA: 0x001FAFB0 File Offset: 0x001F91B0
		// (set) Token: 0x06007443 RID: 29763 RVA: 0x0003733C File Offset: 0x0003553C
		public unsafe bool poweredNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_poweredNode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_poweredNode)) = value;
			}
		}

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x06007444 RID: 29764 RVA: 0x001FAFD8 File Offset: 0x001F91D8
		// (set) Token: 0x06007445 RID: 29765 RVA: 0x00037357 File Offset: 0x00035557
		public unsafe bool consumptionNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_consumptionNode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_consumptionNode)) = value;
			}
		}

		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x06007446 RID: 29766 RVA: 0x001FB000 File Offset: 0x001F9200
		// (set) Token: 0x06007447 RID: 29767 RVA: 0x00037372 File Offset: 0x00035572
		public unsafe bool isConnectedToPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_isConnectedToPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_isConnectedToPower)) = value;
			}
		}

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x06007448 RID: 29768 RVA: 0x001FB028 File Offset: 0x001F9228
		// (set) Token: 0x06007449 RID: 29769 RVA: 0x0003738D File Offset: 0x0003558D
		public unsafe Transform connectionPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_connectionPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_connectionPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x0600744A RID: 29770 RVA: 0x001FB058 File Offset: 0x001F9258
		// (set) Token: 0x0600744B RID: 29771 RVA: 0x000373AC File Offset: 0x000355AC
		public unsafe List<PowerLine> connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PowerLine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F5F RID: 20319
		private static readonly IntPtr NativeFieldInfoPtr_poweredNode;

		// Token: 0x04004F60 RID: 20320
		private static readonly IntPtr NativeFieldInfoPtr_consumptionNode;

		// Token: 0x04004F61 RID: 20321
		private static readonly IntPtr NativeFieldInfoPtr_isConnectedToPower;

		// Token: 0x04004F62 RID: 20322
		private static readonly IntPtr NativeFieldInfoPtr_connectionPoint;

		// Token: 0x04004F63 RID: 20323
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x04004F64 RID: 20324
		private static readonly IntPtr NativeMethodInfoPtr_get_pConnectionPoint_Public_get_Transform_0;

		// Token: 0x04004F65 RID: 20325
		private static readonly IntPtr NativeMethodInfoPtr_IsConnectedTo_Public_Boolean_PowerNode_0;

		// Token: 0x04004F66 RID: 20326
		private static readonly IntPtr NativeMethodInfoPtr_RecalculatePowerNetwork_Public_Void_0;

		// Token: 0x04004F67 RID: 20327
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectedNodes_Public_List_1_PowerNode_List_1_PowerNode_0;

		// Token: 0x04004F68 RID: 20328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
