using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Dragging;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000522 RID: 1314
	public class TrashItem : MonoBehaviour
	{
		// Token: 0x06007515 RID: 29973 RVA: 0x001FDE3C File Offset: 0x001FC03C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashItem()
		{
			Il2CppClassPointerStore<TrashItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashItem>.NativeClassPtr);
			TrashItem.NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "POSITION_CHANGE_THRESHOLD");
			TrashItem.NativeFieldInfoPtr_LINEAR_DRAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "LINEAR_DRAG");
			TrashItem.NativeFieldInfoPtr_ANGULAR_DRAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "ANGULAR_DRAG");
			TrashItem.NativeFieldInfoPtr_MIN_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "MIN_Y");
			TrashItem.NativeFieldInfoPtr_INTERACTION_PRIORITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "INTERACTION_PRIORITY");
			TrashItem.NativeFieldInfoPtr_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "Rigidbody");
			TrashItem.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "Draggable");
			TrashItem.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "ID");
			TrashItem.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "Size");
			TrashItem.NativeFieldInfoPtr_SellValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "SellValue");
			TrashItem.NativeFieldInfoPtr_CanGoInContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "CanGoInContainer");
			TrashItem.NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "colliders");
			TrashItem.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<GUID>k__BackingField");
			TrashItem.NativeFieldInfoPtr__CurrentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<CurrentProperty>k__BackingField");
			TrashItem.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "lastPosition");
			TrashItem.NativeFieldInfoPtr_onDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "onDestroyed");
			TrashItem.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "collidersEnabled");
			TrashItem.NativeFieldInfoPtr_timeOnPhysicsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "timeOnPhysicsEnabled");
			TrashItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			TrashItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			TrashItem.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<HasChanged>k__BackingField");
			TrashItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678034);
			TrashItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678035);
			TrashItem.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678036);
			TrashItem.NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678037);
			TrashItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678038);
			TrashItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678039);
			TrashItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678040);
			TrashItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678041);
			TrashItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678042);
			TrashItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678043);
			TrashItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678044);
			TrashItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678045);
			TrashItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678046);
			TrashItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678047);
			TrashItem.NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678048);
			TrashItem.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678049);
			TrashItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678050);
			TrashItem.NativeMethodInfoPtr_OnValidate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678051);
			TrashItem.NativeMethodInfoPtr_MinPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678052);
			TrashItem.NativeMethodInfoPtr_SleepEnd_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678053);
			TrashItem.NativeMethodInfoPtr_Hovered_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678054);
			TrashItem.NativeMethodInfoPtr_Interacted_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678055);
			TrashItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678056);
			TrashItem.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678057);
			TrashItem.NativeMethodInfoPtr_DestroyTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678058);
			TrashItem.NativeMethodInfoPtr_Deinitialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678059);
			TrashItem.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678060);
			TrashItem.NativeMethodInfoPtr_RecheckPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678061);
			TrashItem.NativeMethodInfoPtr_GetData_Public_Virtual_New_TrashItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678062);
			TrashItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678063);
			TrashItem.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678064);
			TrashItem.NativeMethodInfoPtr_RecheckProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678065);
			TrashItem.NativeMethodInfoPtr_SetContinuousCollisionDetection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678066);
			TrashItem.NativeMethodInfoPtr_SetDiscreteCollisionDetection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678067);
			TrashItem.NativeMethodInfoPtr_SetPhysicsActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678068);
			TrashItem.NativeMethodInfoPtr_SetCollidersEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678069);
			TrashItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678070);
			TrashItem.NativeMethodInfoPtr__Awake_b__44_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678071);
			TrashItem.NativeMethodInfoPtr__Awake_b__44_1_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678072);
		}

		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x06007516 RID: 29974 RVA: 0x001FE31C File Offset: 0x001FC51C
		// (set) Token: 0x06007517 RID: 29975 RVA: 0x001FE358 File Offset: 0x001FC558
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x06007518 RID: 29976 RVA: 0x001FE398 File Offset: 0x001FC598
		// (set) Token: 0x06007519 RID: 29977 RVA: 0x001FE3D8 File Offset: 0x001FC5D8
		public unsafe Property CurrentProperty
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 47268, RefRangeEnd = 47308, XrefRangeStart = 47268, XrefRangeEnd = 47308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 158947, RefRangeEnd = 158949, XrefRangeStart = 158947, XrefRangeEnd = 158949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x0600751A RID: 29978 RVA: 0x001FE41C File Offset: 0x001FC61C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228505, XrefRangeEnd = 228510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x0600751B RID: 29979 RVA: 0x001FE454 File Offset: 0x001FC654
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228510, XrefRangeEnd = 228515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x0600751C RID: 29980 RVA: 0x001FE48C File Offset: 0x001FC68C
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x0600751D RID: 29981 RVA: 0x001FE4CC File Offset: 0x001FC6CC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002393 RID: 9107
		// (get) Token: 0x0600751E RID: 29982 RVA: 0x001FE508 File Offset: 0x001FC708
		// (set) Token: 0x0600751F RID: 29983 RVA: 0x001FE548 File Offset: 0x001FC748
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 95744, RefRangeEnd = 95745, XrefRangeStart = 95744, XrefRangeEnd = 95745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x06007520 RID: 29984 RVA: 0x001FE58C File Offset: 0x001FC78C
		// (set) Token: 0x06007521 RID: 29985 RVA: 0x001FE5CC File Offset: 0x001FC7CC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 31092, RefRangeEnd = 31099, XrefRangeStart = 31092, XrefRangeEnd = 31099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x06007522 RID: 29986 RVA: 0x001FE610 File Offset: 0x001FC810
		// (set) Token: 0x06007523 RID: 29987 RVA: 0x001FE64C File Offset: 0x001FC84C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007524 RID: 29988 RVA: 0x001FE68C File Offset: 0x001FC88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228515, XrefRangeEnd = 228575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007525 RID: 29989 RVA: 0x001FE6C0 File Offset: 0x001FC8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228575, XrefRangeEnd = 228626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007526 RID: 29990 RVA: 0x001FE6F4 File Offset: 0x001FC8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228626, XrefRangeEnd = 228632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007527 RID: 29991 RVA: 0x001FE730 File Offset: 0x001FC930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228632, XrefRangeEnd = 228661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_OnValidate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007528 RID: 29992 RVA: 0x001FE764 File Offset: 0x001FC964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228661, XrefRangeEnd = 228689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_MinPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007529 RID: 29993 RVA: 0x001FE798 File Offset: 0x001FC998
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepEnd(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SleepEnd_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600752A RID: 29994 RVA: 0x001FE7D8 File Offset: 0x001FC9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228689, XrefRangeEnd = 228697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Hovered_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x001FE80C File Offset: 0x001FCA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228697, XrefRangeEnd = 228704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Interacted_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x001FE840 File Offset: 0x001FCA40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228720, RefRangeEnd = 228722, XrefRangeStart = 228704, XrefRangeEnd = 228720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600752D RID: 29997 RVA: 0x001FE880 File Offset: 0x001FCA80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228723, RefRangeEnd = 228725, XrefRangeStart = 228722, XrefRangeEnd = 228723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVelocity(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600752E RID: 29998 RVA: 0x001FE8C0 File Offset: 0x001FCAC0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 228731, RefRangeEnd = 228742, XrefRangeStart = 228725, XrefRangeEnd = 228731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_DestroyTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x001FE8F4 File Offset: 0x001FCAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228742, XrefRangeEnd = 228780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_Deinitialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007530 RID: 30000 RVA: 0x001FE930 File Offset: 0x001FCB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228780, XrefRangeEnd = 228816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x001FE964 File Offset: 0x001FCB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228816, XrefRangeEnd = 228826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecheckPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_RecheckPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x001FE998 File Offset: 0x001FCB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228826, XrefRangeEnd = 228835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TrashItemData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_GetData_Public_Virtual_New_TrashItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItemData>(intPtr3) : null;
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x001FE9E4 File Offset: 0x001FCBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228835, XrefRangeEnd = 228836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x001FEA28 File Offset: 0x001FCC28
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007535 RID: 30005 RVA: 0x001FEA70 File Offset: 0x001FCC70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228879, RefRangeEnd = 228881, XrefRangeStart = 228836, XrefRangeEnd = 228879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecheckProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_RecheckProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007536 RID: 30006 RVA: 0x001FEAA4 File Offset: 0x001FCCA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 228891, RefRangeEnd = 228897, XrefRangeStart = 228881, XrefRangeEnd = 228891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContinuousCollisionDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetContinuousCollisionDetection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007537 RID: 30007 RVA: 0x001FEAD8 File Offset: 0x001FCCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228897, XrefRangeEnd = 228904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDiscreteCollisionDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetDiscreteCollisionDetection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x001FEB0C File Offset: 0x001FCD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228904, XrefRangeEnd = 228907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPhysicsActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetPhysicsActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007539 RID: 30009 RVA: 0x001FEB4C File Offset: 0x001FCD4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 228910, RefRangeEnd = 228915, XrefRangeStart = 228907, XrefRangeEnd = 228910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCollidersEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetCollidersEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x001FEB8C File Offset: 0x001FCD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228915, XrefRangeEnd = 228934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x001FEBC8 File Offset: 0x001FCDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228934, XrefRangeEnd = 228935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__44_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr__Awake_b__44_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753C RID: 30012 RVA: 0x001FEBFC File Offset: 0x001FCDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228935, XrefRangeEnd = 228936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__44_1(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr__Awake_b__44_1_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753D RID: 30013 RVA: 0x00037886 File Offset: 0x00035A86
		public TrashItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002378 RID: 9080
		// (get) Token: 0x0600753E RID: 30014 RVA: 0x001FEC40 File Offset: 0x001FCE40
		// (set) Token: 0x0600753F RID: 30015 RVA: 0x0003788F File Offset: 0x00035A8F
		public unsafe static float POSITION_CHANGE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x06007540 RID: 30016 RVA: 0x001FEC5C File Offset: 0x001FCE5C
		// (set) Token: 0x06007541 RID: 30017 RVA: 0x0003789D File Offset: 0x00035A9D
		public unsafe static float LINEAR_DRAG
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_LINEAR_DRAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_LINEAR_DRAG, (void*)(&value));
			}
		}

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x06007542 RID: 30018 RVA: 0x001FEC78 File Offset: 0x001FCE78
		// (set) Token: 0x06007543 RID: 30019 RVA: 0x000378AB File Offset: 0x00035AAB
		public unsafe static float ANGULAR_DRAG
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_ANGULAR_DRAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_ANGULAR_DRAG, (void*)(&value));
			}
		}

		// Token: 0x1700237B RID: 9083
		// (get) Token: 0x06007544 RID: 30020 RVA: 0x001FEC94 File Offset: 0x001FCE94
		// (set) Token: 0x06007545 RID: 30021 RVA: 0x000378B9 File Offset: 0x00035AB9
		public unsafe static float MIN_Y
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_MIN_Y, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_MIN_Y, (void*)(&value));
			}
		}

		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x06007546 RID: 30022 RVA: 0x001FECB0 File Offset: 0x001FCEB0
		// (set) Token: 0x06007547 RID: 30023 RVA: 0x000378C7 File Offset: 0x00035AC7
		public unsafe static int INTERACTION_PRIORITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_INTERACTION_PRIORITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_INTERACTION_PRIORITY, (void*)(&value));
			}
		}

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x06007548 RID: 30024 RVA: 0x001FECCC File Offset: 0x001FCECC
		// (set) Token: 0x06007549 RID: 30025 RVA: 0x000378D5 File Offset: 0x00035AD5
		public unsafe Rigidbody Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Rigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x0600754A RID: 30026 RVA: 0x001FECFC File Offset: 0x001FCEFC
		// (set) Token: 0x0600754B RID: 30027 RVA: 0x000378F4 File Offset: 0x00035AF4
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x0600754C RID: 30028 RVA: 0x001FED2C File Offset: 0x001FCF2C
		// (set) Token: 0x0600754D RID: 30029 RVA: 0x00037913 File Offset: 0x00035B13
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x0600754E RID: 30030 RVA: 0x001FED54 File Offset: 0x001FCF54
		// (set) Token: 0x0600754F RID: 30031 RVA: 0x00037932 File Offset: 0x00035B32
		public unsafe int Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x17002381 RID: 9089
		// (get) Token: 0x06007550 RID: 30032 RVA: 0x001FED7C File Offset: 0x001FCF7C
		// (set) Token: 0x06007551 RID: 30033 RVA: 0x0003794D File Offset: 0x00035B4D
		public unsafe int SellValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_SellValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_SellValue)) = value;
			}
		}

		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x06007552 RID: 30034 RVA: 0x001FEDA4 File Offset: 0x001FCFA4
		// (set) Token: 0x06007553 RID: 30035 RVA: 0x00037968 File Offset: 0x00035B68
		public unsafe bool CanGoInContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_CanGoInContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_CanGoInContainer)) = value;
			}
		}

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x06007554 RID: 30036 RVA: 0x001FEDCC File Offset: 0x001FCFCC
		// (set) Token: 0x06007555 RID: 30037 RVA: 0x00037983 File Offset: 0x00035B83
		public unsafe Il2CppReferenceArray<Collider> colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x06007556 RID: 30038 RVA: 0x001FEDFC File Offset: 0x001FCFFC
		// (set) Token: 0x06007557 RID: 30039 RVA: 0x000379A2 File Offset: 0x00035BA2
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x06007558 RID: 30040 RVA: 0x001FEE24 File Offset: 0x001FD024
		// (set) Token: 0x06007559 RID: 30041 RVA: 0x000379BD File Offset: 0x00035BBD
		public unsafe Property _CurrentProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__CurrentProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__CurrentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x0600755A RID: 30042 RVA: 0x001FEE54 File Offset: 0x001FD054
		// (set) Token: 0x0600755B RID: 30043 RVA: 0x000379DC File Offset: 0x00035BDC
		public unsafe Vector3 lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x0600755C RID: 30044 RVA: 0x001FEE7C File Offset: 0x001FD07C
		// (set) Token: 0x0600755D RID: 30045 RVA: 0x000379F7 File Offset: 0x00035BF7
		public unsafe Action<TrashItem> onDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_onDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TrashItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_onDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x0600755E RID: 30046 RVA: 0x001FEEAC File Offset: 0x001FD0AC
		// (set) Token: 0x0600755F RID: 30047 RVA: 0x00037A16 File Offset: 0x00035C16
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x06007560 RID: 30048 RVA: 0x001FEED4 File Offset: 0x001FD0D4
		// (set) Token: 0x06007561 RID: 30049 RVA: 0x00037A31 File Offset: 0x00035C31
		public unsafe float timeOnPhysicsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_timeOnPhysicsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_timeOnPhysicsEnabled)) = value;
			}
		}

		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x06007562 RID: 30050 RVA: 0x001FEEFC File Offset: 0x001FD0FC
		// (set) Token: 0x06007563 RID: 30051 RVA: 0x00037A4C File Offset: 0x00035C4C
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700238B RID: 9099
		// (get) Token: 0x06007564 RID: 30052 RVA: 0x001FEF2C File Offset: 0x001FD12C
		// (set) Token: 0x06007565 RID: 30053 RVA: 0x00037A6B File Offset: 0x00035C6B
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700238C RID: 9100
		// (get) Token: 0x06007566 RID: 30054 RVA: 0x001FEF5C File Offset: 0x001FD15C
		// (set) Token: 0x06007567 RID: 30055 RVA: 0x00037A8A File Offset: 0x00035C8A
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04004FF8 RID: 20472
		private static readonly IntPtr NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD;

		// Token: 0x04004FF9 RID: 20473
		private static readonly IntPtr NativeFieldInfoPtr_LINEAR_DRAG;

		// Token: 0x04004FFA RID: 20474
		private static readonly IntPtr NativeFieldInfoPtr_ANGULAR_DRAG;

		// Token: 0x04004FFB RID: 20475
		private static readonly IntPtr NativeFieldInfoPtr_MIN_Y;

		// Token: 0x04004FFC RID: 20476
		private static readonly IntPtr NativeFieldInfoPtr_INTERACTION_PRIORITY;

		// Token: 0x04004FFD RID: 20477
		private static readonly IntPtr NativeFieldInfoPtr_Rigidbody;

		// Token: 0x04004FFE RID: 20478
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x04004FFF RID: 20479
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04005000 RID: 20480
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x04005001 RID: 20481
		private static readonly IntPtr NativeFieldInfoPtr_SellValue;

		// Token: 0x04005002 RID: 20482
		private static readonly IntPtr NativeFieldInfoPtr_CanGoInContainer;

		// Token: 0x04005003 RID: 20483
		private static readonly IntPtr NativeFieldInfoPtr_colliders;

		// Token: 0x04005004 RID: 20484
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04005005 RID: 20485
		private static readonly IntPtr NativeFieldInfoPtr__CurrentProperty_k__BackingField;

		// Token: 0x04005006 RID: 20486
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x04005007 RID: 20487
		private static readonly IntPtr NativeFieldInfoPtr_onDestroyed;

		// Token: 0x04005008 RID: 20488
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x04005009 RID: 20489
		private static readonly IntPtr NativeFieldInfoPtr_timeOnPhysicsEnabled;

		// Token: 0x0400500A RID: 20490
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400500B RID: 20491
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400500C RID: 20492
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400500D RID: 20493
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x0400500E RID: 20494
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x0400500F RID: 20495
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x04005010 RID: 20496
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0;

		// Token: 0x04005011 RID: 20497
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04005012 RID: 20498
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04005013 RID: 20499
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04005014 RID: 20500
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04005015 RID: 20501
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04005016 RID: 20502
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005017 RID: 20503
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04005018 RID: 20504
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005019 RID: 20505
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400501A RID: 20506
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400501B RID: 20507
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;

		// Token: 0x0400501C RID: 20508
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x0400501D RID: 20509
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400501E RID: 20510
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Void_0;

		// Token: 0x0400501F RID: 20511
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Void_0;

		// Token: 0x04005020 RID: 20512
		private static readonly IntPtr NativeMethodInfoPtr_SleepEnd_Protected_Void_Int32_0;

		// Token: 0x04005021 RID: 20513
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Void_0;

		// Token: 0x04005022 RID: 20514
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Protected_Void_0;

		// Token: 0x04005023 RID: 20515
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04005024 RID: 20516
		private static readonly IntPtr NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0;

		// Token: 0x04005025 RID: 20517
		private static readonly IntPtr NativeMethodInfoPtr_DestroyTrash_Public_Void_0;

		// Token: 0x04005026 RID: 20518
		private static readonly IntPtr NativeMethodInfoPtr_Deinitialize_Public_Virtual_New_Void_0;

		// Token: 0x04005027 RID: 20519
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005028 RID: 20520
		private static readonly IntPtr NativeMethodInfoPtr_RecheckPosition_Private_Void_0;

		// Token: 0x04005029 RID: 20521
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_New_TrashItemData_0;

		// Token: 0x0400502A RID: 20522
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400502B RID: 20523
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x0400502C RID: 20524
		private static readonly IntPtr NativeMethodInfoPtr_RecheckProperty_Private_Void_0;

		// Token: 0x0400502D RID: 20525
		private static readonly IntPtr NativeMethodInfoPtr_SetContinuousCollisionDetection_Public_Void_0;

		// Token: 0x0400502E RID: 20526
		private static readonly IntPtr NativeMethodInfoPtr_SetDiscreteCollisionDetection_Public_Void_0;

		// Token: 0x0400502F RID: 20527
		private static readonly IntPtr NativeMethodInfoPtr_SetPhysicsActive_Public_Void_Boolean_0;

		// Token: 0x04005030 RID: 20528
		private static readonly IntPtr NativeMethodInfoPtr_SetCollidersEnabled_Public_Void_Boolean_0;

		// Token: 0x04005031 RID: 20529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005032 RID: 20530
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__44_0_Private_Void_0;

		// Token: 0x04005033 RID: 20531
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__44_1_Private_Void_Impact_0;
	}
}
