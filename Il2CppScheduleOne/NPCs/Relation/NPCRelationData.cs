using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x020002F1 RID: 753
	[Serializable]
	public class NPCRelationData : Object
	{
		// Token: 0x060038DB RID: 14555 RVA: 0x00129410 File Offset: 0x00127610
		// Note: this type is marked as 'beforefieldinit'.
		static NPCRelationData()
		{
			Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "NPCRelationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr);
			NPCRelationData.NativeFieldInfoPtr_MinDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "MinDelta");
			NPCRelationData.NativeFieldInfoPtr_MaxDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "MaxDelta");
			NPCRelationData.NativeFieldInfoPtr_DEFAULT_RELATION_DELTA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "DEFAULT_RELATION_DELTA");
			NPCRelationData.NativeFieldInfoPtr__RelationDelta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<RelationDelta>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr__Unlocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<Unlocked>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr__UnlockType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<UnlockType>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<NPC>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr_FullGameConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "FullGameConnections");
			NPCRelationData.NativeFieldInfoPtr_DemoConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "DemoConnections");
			NPCRelationData.NativeFieldInfoPtr_onRelationshipChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "onRelationshipChange");
			NPCRelationData.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "onUnlocked");
			NPCRelationData.NativeMethodInfoPtr_get_RelationDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669906);
			NPCRelationData.NativeMethodInfoPtr_set_RelationDelta_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669907);
			NPCRelationData.NativeMethodInfoPtr_get_NormalizedRelationDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669908);
			NPCRelationData.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669909);
			NPCRelationData.NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669910);
			NPCRelationData.NativeMethodInfoPtr_get_UnlockType_Public_get_EUnlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669911);
			NPCRelationData.NativeMethodInfoPtr_set_UnlockType_Protected_set_Void_EUnlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669912);
			NPCRelationData.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669913);
			NPCRelationData.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669914);
			NPCRelationData.NativeMethodInfoPtr_get_Connections_Public_get_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669915);
			NPCRelationData.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669916);
			NPCRelationData.NativeMethodInfoPtr_Init_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669917);
			NPCRelationData.NativeMethodInfoPtr_ChangeRelationship_Public_Virtual_New_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669918);
			NPCRelationData.NativeMethodInfoPtr_SetRelationship_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669919);
			NPCRelationData.NativeMethodInfoPtr_Unlock_Public_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669920);
			NPCRelationData.NativeMethodInfoPtr_UnlockConnections_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669921);
			NPCRelationData.NativeMethodInfoPtr_GetSaveData_Public_RelationshipData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669922);
			NPCRelationData.NativeMethodInfoPtr_GetAverageMutualRelationship_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669923);
			NPCRelationData.NativeMethodInfoPtr_IsKnown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669924);
			NPCRelationData.NativeMethodInfoPtr_IsMutuallyKnown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669925);
			NPCRelationData.NativeMethodInfoPtr_GetLockedConnections_Public_List_1_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669926);
			NPCRelationData.NativeMethodInfoPtr_GetLockedDealers_Public_List_1_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669927);
			NPCRelationData.NativeMethodInfoPtr_GetLockedSuppliers_Public_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669928);
			NPCRelationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669929);
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060038DC RID: 14556 RVA: 0x001296FC File Offset: 0x001278FC
		// (set) Token: 0x060038DD RID: 14557 RVA: 0x00129738 File Offset: 0x00127938
		public unsafe float RelationDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_RelationDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 29949, RefRangeEnd = 29953, XrefRangeStart = 29949, XrefRangeEnd = 29953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_RelationDelta_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060038DE RID: 14558 RVA: 0x00129778 File Offset: 0x00127978
		public unsafe float NormalizedRelationDelta
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 141630, RefRangeEnd = 141640, XrefRangeStart = 141630, XrefRangeEnd = 141630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_NormalizedRelationDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x001297B4 File Offset: 0x001279B4
		// (set) Token: 0x060038E0 RID: 14560 RVA: 0x001297F0 File Offset: 0x001279F0
		public unsafe bool Unlocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060038E1 RID: 14561 RVA: 0x00129830 File Offset: 0x00127A30
		// (set) Token: 0x060038E2 RID: 14562 RVA: 0x0012986C File Offset: 0x00127A6C
		public unsafe NPCRelationData.EUnlockType UnlockType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_UnlockType_Public_get_EUnlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29996, RefRangeEnd = 29998, XrefRangeStart = 29996, XrefRangeEnd = 29998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_UnlockType_Protected_set_Void_EUnlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x001298AC File Offset: 0x00127AAC
		// (set) Token: 0x060038E4 RID: 14564 RVA: 0x001298EC File Offset: 0x00127AEC
		public unsafe NPC NPC
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x00129930 File Offset: 0x00127B30
		public unsafe List<NPC> Connections
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_Connections_Public_get_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
			}
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x00129970 File Offset: 0x00127B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x001299B4 File Offset: 0x00127BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141664, RefRangeEnd = 141665, XrefRangeStart = 141640, XrefRangeEnd = 141664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_Init_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x001299F8 File Offset: 0x00127BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141665, XrefRangeEnd = 141667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChangeRelationship(float deltaChange, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deltaChange;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_ChangeRelationship_Public_Virtual_New_Void_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x00129A50 File Offset: 0x00127C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141667, XrefRangeEnd = 141668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRelationship(float newDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_SetRelationship_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x00129A9C File Offset: 0x00127C9C
		[CallerCount(0)]
		public unsafe virtual void Unlock(NPCRelationData.EUnlockType type, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_Unlock_Public_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x00129AF4 File Offset: 0x00127CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141668, XrefRangeEnd = 141675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnlockConnections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_UnlockConnections_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x00129B30 File Offset: 0x00127D30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141679, RefRangeEnd = 141680, XrefRangeStart = 141675, XrefRangeEnd = 141679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetSaveData_Public_RelationshipData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RelationshipData>(intPtr3) : null;
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x00129B70 File Offset: 0x00127D70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141687, RefRangeEnd = 141689, XrefRangeStart = 141680, XrefRangeEnd = 141687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageMutualRelationship()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetAverageMutualRelationship_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x00129BAC File Offset: 0x00127DAC
		[CallerCount(0)]
		public unsafe bool IsKnown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_IsKnown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x00129BE8 File Offset: 0x00127DE8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 141700, RefRangeEnd = 141708, XrefRangeStart = 141689, XrefRangeEnd = 141700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMutuallyKnown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_IsMutuallyKnown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x00129C24 File Offset: 0x00127E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141708, XrefRangeEnd = 141722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetLockedConnections(bool excludeCustomers = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref excludeCustomers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetLockedConnections_Public_List_1_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x00129C70 File Offset: 0x00127E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141736, RefRangeEnd = 141737, XrefRangeStart = 141722, XrefRangeEnd = 141736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetLockedDealers(bool excludeRecommended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref excludeRecommended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetLockedDealers_Public_List_1_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x00129CBC File Offset: 0x00127EBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141756, RefRangeEnd = 141757, XrefRangeStart = 141737, XrefRangeEnd = 141756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetLockedSuppliers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetLockedSuppliers_Public_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x00129CFC File Offset: 0x00127EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141757, XrefRangeEnd = 141770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCRelationData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x0001D415 File Offset: 0x0001B615
		public NPCRelationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x00129D38 File Offset: 0x00127F38
		// (set) Token: 0x060038F6 RID: 14582 RVA: 0x0001D41E File Offset: 0x0001B61E
		public unsafe static float MinDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCRelationData.NativeFieldInfoPtr_MinDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCRelationData.NativeFieldInfoPtr_MinDelta, (void*)(&value));
			}
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x00129D54 File Offset: 0x00127F54
		// (set) Token: 0x060038F8 RID: 14584 RVA: 0x0001D42C File Offset: 0x0001B62C
		public unsafe static float MaxDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCRelationData.NativeFieldInfoPtr_MaxDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCRelationData.NativeFieldInfoPtr_MaxDelta, (void*)(&value));
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x00129D70 File Offset: 0x00127F70
		// (set) Token: 0x060038FA RID: 14586 RVA: 0x0001D43A File Offset: 0x0001B63A
		public unsafe static float DEFAULT_RELATION_DELTA
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCRelationData.NativeFieldInfoPtr_DEFAULT_RELATION_DELTA, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCRelationData.NativeFieldInfoPtr_DEFAULT_RELATION_DELTA, (void*)(&value));
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x00129D8C File Offset: 0x00127F8C
		// (set) Token: 0x060038FC RID: 14588 RVA: 0x0001D448 File Offset: 0x0001B648
		public unsafe float _RelationDelta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__RelationDelta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__RelationDelta_k__BackingField)) = value;
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x00129DB4 File Offset: 0x00127FB4
		// (set) Token: 0x060038FE RID: 14590 RVA: 0x0001D463 File Offset: 0x0001B663
		public unsafe bool _Unlocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__Unlocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__Unlocked_k__BackingField)) = value;
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x00129DDC File Offset: 0x00127FDC
		// (set) Token: 0x06003900 RID: 14592 RVA: 0x0001D47E File Offset: 0x0001B67E
		public unsafe NPCRelationData.EUnlockType _UnlockType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__UnlockType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__UnlockType_k__BackingField)) = value;
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x06003901 RID: 14593 RVA: 0x00129E04 File Offset: 0x00128004
		// (set) Token: 0x06003902 RID: 14594 RVA: 0x0001D499 File Offset: 0x0001B699
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__NPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x06003903 RID: 14595 RVA: 0x00129E34 File Offset: 0x00128034
		// (set) Token: 0x06003904 RID: 14596 RVA: 0x0001D4B8 File Offset: 0x0001B6B8
		public unsafe List<NPC> FullGameConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_FullGameConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_FullGameConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06003905 RID: 14597 RVA: 0x00129E64 File Offset: 0x00128064
		// (set) Token: 0x06003906 RID: 14598 RVA: 0x0001D4D7 File Offset: 0x0001B6D7
		public unsafe List<NPC> DemoConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_DemoConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_DemoConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x06003907 RID: 14599 RVA: 0x00129E94 File Offset: 0x00128094
		// (set) Token: 0x06003908 RID: 14600 RVA: 0x0001D4F6 File Offset: 0x0001B6F6
		public unsafe Action<float> onRelationshipChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_onRelationshipChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_onRelationshipChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06003909 RID: 14601 RVA: 0x00129EC4 File Offset: 0x001280C4
		// (set) Token: 0x0600390A RID: 14602 RVA: 0x0001D515 File Offset: 0x0001B715
		public unsafe Action<NPCRelationData.EUnlockType, bool> onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NPCRelationData.EUnlockType, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002586 RID: 9606
		private static readonly IntPtr NativeFieldInfoPtr_MinDelta;

		// Token: 0x04002587 RID: 9607
		private static readonly IntPtr NativeFieldInfoPtr_MaxDelta;

		// Token: 0x04002588 RID: 9608
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_RELATION_DELTA;

		// Token: 0x04002589 RID: 9609
		private static readonly IntPtr NativeFieldInfoPtr__RelationDelta_k__BackingField;

		// Token: 0x0400258A RID: 9610
		private static readonly IntPtr NativeFieldInfoPtr__Unlocked_k__BackingField;

		// Token: 0x0400258B RID: 9611
		private static readonly IntPtr NativeFieldInfoPtr__UnlockType_k__BackingField;

		// Token: 0x0400258C RID: 9612
		private static readonly IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x0400258D RID: 9613
		private static readonly IntPtr NativeFieldInfoPtr_FullGameConnections;

		// Token: 0x0400258E RID: 9614
		private static readonly IntPtr NativeFieldInfoPtr_DemoConnections;

		// Token: 0x0400258F RID: 9615
		private static readonly IntPtr NativeFieldInfoPtr_onRelationshipChange;

		// Token: 0x04002590 RID: 9616
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x04002591 RID: 9617
		private static readonly IntPtr NativeMethodInfoPtr_get_RelationDelta_Public_get_Single_0;

		// Token: 0x04002592 RID: 9618
		private static readonly IntPtr NativeMethodInfoPtr_set_RelationDelta_Protected_set_Void_Single_0;

		// Token: 0x04002593 RID: 9619
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedRelationDelta_Public_get_Single_0;

		// Token: 0x04002594 RID: 9620
		private static readonly IntPtr NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0;

		// Token: 0x04002595 RID: 9621
		private static readonly IntPtr NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0;

		// Token: 0x04002596 RID: 9622
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockType_Public_get_EUnlockType_0;

		// Token: 0x04002597 RID: 9623
		private static readonly IntPtr NativeMethodInfoPtr_set_UnlockType_Protected_set_Void_EUnlockType_0;

		// Token: 0x04002598 RID: 9624
		private static readonly IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x04002599 RID: 9625
		private static readonly IntPtr NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0;

		// Token: 0x0400259A RID: 9626
		private static readonly IntPtr NativeMethodInfoPtr_get_Connections_Public_get_List_1_NPC_0;

		// Token: 0x0400259B RID: 9627
		private static readonly IntPtr NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0;

		// Token: 0x0400259C RID: 9628
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_NPC_0;

		// Token: 0x0400259D RID: 9629
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRelationship_Public_Virtual_New_Void_Single_Boolean_0;

		// Token: 0x0400259E RID: 9630
		private static readonly IntPtr NativeMethodInfoPtr_SetRelationship_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Public_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeMethodInfoPtr_UnlockConnections_Public_Virtual_New_Void_0;

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_RelationshipData_0;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageMutualRelationship_Public_Single_0;

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeMethodInfoPtr_IsKnown_Public_Boolean_0;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeMethodInfoPtr_IsMutuallyKnown_Public_Boolean_0;

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeMethodInfoPtr_GetLockedConnections_Public_List_1_NPC_Boolean_0;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeMethodInfoPtr_GetLockedDealers_Public_List_1_NPC_Boolean_0;

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeMethodInfoPtr_GetLockedSuppliers_Public_List_1_NPC_0;

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000936 RID: 2358
		[OriginalName("Assembly-CSharp.dll", "", "EUnlockType")]
		public enum EUnlockType
		{
			// Token: 0x040086C7 RID: 34503
			Recommendation,
			// Token: 0x040086C8 RID: 34504
			DirectApproach
		}

		// Token: 0x02000937 RID: 2359
		[ObfuscatedName("ScheduleOne.NPCs.Relation.NPCRelationData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600C71A RID: 50970 RVA: 0x003050A8 File Offset: 0x003032A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr);
				NPCRelationData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, "<>9");
				NPCRelationData.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, "<>9__40_0");
				NPCRelationData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, 100669931);
				NPCRelationData.__c.NativeMethodInfoPtr__GetLockedSuppliers_b__40_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, 100669932);
			}

			// Token: 0x0600C71B RID: 50971 RVA: 0x00305124 File Offset: 0x00303324
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C71C RID: 50972 RVA: 0x00305160 File Offset: 0x00303360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141625, XrefRangeEnd = 141626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLockedSuppliers_b__40_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c.NativeMethodInfoPtr__GetLockedSuppliers_b__40_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C71D RID: 50973 RVA: 0x00060E85 File Offset: 0x0005F085
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E0B RID: 15883
			// (get) Token: 0x0600C71E RID: 50974 RVA: 0x003051B0 File Offset: 0x003033B0
			// (set) Token: 0x0600C71F RID: 50975 RVA: 0x00060E8E File Offset: 0x0005F08E
			public unsafe static NPCRelationData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCRelationData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCRelationData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCRelationData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E0C RID: 15884
			// (get) Token: 0x0600C720 RID: 50976 RVA: 0x003051D8 File Offset: 0x003033D8
			// (set) Token: 0x0600C721 RID: 50977 RVA: 0x00060EA0 File Offset: 0x0005F0A0
			public unsafe static Predicate<NPC> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCRelationData.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<NPC>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCRelationData.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086C9 RID: 34505
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040086CA RID: 34506
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x040086CB RID: 34507
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086CC RID: 34508
			private static readonly IntPtr NativeMethodInfoPtr__GetLockedSuppliers_b__40_0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000938 RID: 2360
		[ObfuscatedName("ScheduleOne.NPCs.Relation.NPCRelationData+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Object
		{
			// Token: 0x0600C722 RID: 50978 RVA: 0x00305200 File Offset: 0x00303400
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr);
				NPCRelationData.__c__DisplayClass38_0.NativeFieldInfoPtr_excludeCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr, "excludeCustomers");
				NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr, 100669933);
				NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__GetLockedConnections_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr, 100669934);
			}

			// Token: 0x0600C723 RID: 50979 RVA: 0x00305268 File Offset: 0x00303468
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C724 RID: 50980 RVA: 0x003052A4 File Offset: 0x003034A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141626, XrefRangeEnd = 141628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLockedConnections_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__GetLockedConnections_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C725 RID: 50981 RVA: 0x00060EB2 File Offset: 0x0005F0B2
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E0D RID: 15885
			// (get) Token: 0x0600C726 RID: 50982 RVA: 0x003052F4 File Offset: 0x003034F4
			// (set) Token: 0x0600C727 RID: 50983 RVA: 0x00060EBB File Offset: 0x0005F0BB
			public unsafe bool excludeCustomers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass38_0.NativeFieldInfoPtr_excludeCustomers);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass38_0.NativeFieldInfoPtr_excludeCustomers)) = value;
				}
			}

			// Token: 0x040086CD RID: 34509
			private static readonly IntPtr NativeFieldInfoPtr_excludeCustomers;

			// Token: 0x040086CE RID: 34510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086CF RID: 34511
			private static readonly IntPtr NativeMethodInfoPtr__GetLockedConnections_b__0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000939 RID: 2361
		[ObfuscatedName("ScheduleOne.NPCs.Relation.NPCRelationData+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Object
		{
			// Token: 0x0600C728 RID: 50984 RVA: 0x0030531C File Offset: 0x0030351C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr);
				NPCRelationData.__c__DisplayClass39_0.NativeFieldInfoPtr_excludeRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr, "excludeRecommended");
				NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr, 100669935);
				NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__GetLockedDealers_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr, 100669936);
			}

			// Token: 0x0600C729 RID: 50985 RVA: 0x00305384 File Offset: 0x00303584
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C72A RID: 50986 RVA: 0x003053C0 File Offset: 0x003035C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141628, XrefRangeEnd = 141630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLockedDealers_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__GetLockedDealers_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C72B RID: 50987 RVA: 0x00060ED6 File Offset: 0x0005F0D6
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E0E RID: 15886
			// (get) Token: 0x0600C72C RID: 50988 RVA: 0x00305410 File Offset: 0x00303610
			// (set) Token: 0x0600C72D RID: 50989 RVA: 0x00060EDF File Offset: 0x0005F0DF
			public unsafe bool excludeRecommended
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass39_0.NativeFieldInfoPtr_excludeRecommended);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass39_0.NativeFieldInfoPtr_excludeRecommended)) = value;
				}
			}

			// Token: 0x040086D0 RID: 34512
			private static readonly IntPtr NativeFieldInfoPtr_excludeRecommended;

			// Token: 0x040086D1 RID: 34513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086D2 RID: 34514
			private static readonly IntPtr NativeMethodInfoPtr__GetLockedDealers_b__0_Internal_Boolean_NPC_0;
		}
	}
}
