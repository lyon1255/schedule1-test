using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.Trash;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200072E RID: 1838
	public class TrashContainerItem : GridItem
	{
		// Token: 0x0600A6D3 RID: 42707 RVA: 0x0029B4F8 File Offset: 0x002996F8
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerItem()
		{
			Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "TrashContainerItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr);
			TrashContainerItem.NativeFieldInfoPtr_MAX_VERTICAL_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "MAX_VERTICAL_OFFSET");
			TrashContainerItem.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "Container");
			TrashContainerItem.NativeFieldInfoPtr_Flies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "Flies");
			TrashContainerItem.NativeFieldInfoPtr_TrashAddedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "TrashAddedSound");
			TrashContainerItem.NativeFieldInfoPtr_PickupAreaProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "PickupAreaProjector");
			TrashContainerItem.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "accessPoints");
			TrashContainerItem.NativeFieldInfoPtr_UsableByCleaners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "UsableByCleaners");
			TrashContainerItem.NativeFieldInfoPtr_PickupRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "PickupRadius");
			TrashContainerItem.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "<InputSlots>k__BackingField");
			TrashContainerItem.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "<OutputSlots>k__BackingField");
			TrashContainerItem.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "<Selectable>k__BackingField");
			TrashContainerItem.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			TrashContainerItem.NativeFieldInfoPtr_TrashItemsInRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "TrashItemsInRadius");
			TrashContainerItem.NativeFieldInfoPtr_TrashBagsInRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "TrashBagsInRadius");
			TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted");
			TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted");
			TrashContainerItem.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683714);
			TrashContainerItem.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683715);
			TrashContainerItem.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683716);
			TrashContainerItem.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683717);
			TrashContainerItem.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683718);
			TrashContainerItem.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683719);
			TrashContainerItem.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683720);
			TrashContainerItem.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683721);
			TrashContainerItem.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683722);
			TrashContainerItem.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683723);
			TrashContainerItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683724);
			TrashContainerItem.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683725);
			TrashContainerItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683726);
			TrashContainerItem.NativeMethodInfoPtr_TrashLevelChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683727);
			TrashContainerItem.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683728);
			TrashContainerItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683729);
			TrashContainerItem.NativeMethodInfoPtr_TrashAdded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683730);
			TrashContainerItem.NativeMethodInfoPtr_ShowOutline_Public_Virtual_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683731);
			TrashContainerItem.NativeMethodInfoPtr_HideOutline_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683732);
			TrashContainerItem.NativeMethodInfoPtr_CheckTrashItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683733);
			TrashContainerItem.NativeMethodInfoPtr_AddTrashToRadius_Private_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683734);
			TrashContainerItem.NativeMethodInfoPtr_AddTrashBagToRadius_Private_Void_TrashBag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683735);
			TrashContainerItem.NativeMethodInfoPtr_RemoveTrashItemFromRadius_Private_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683736);
			TrashContainerItem.NativeMethodInfoPtr_RemoveTrashBagFromRadius_Private_Void_TrashBag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683737);
			TrashContainerItem.NativeMethodInfoPtr_IsTrashValid_Private_Boolean_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683738);
			TrashContainerItem.NativeMethodInfoPtr_IsPointInRadius_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683739);
			TrashContainerItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683740);
			TrashContainerItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683741);
			TrashContainerItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683742);
			TrashContainerItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683743);
			TrashContainerItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100683744);
		}

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x0600A6D4 RID: 42708 RVA: 0x0029B8D4 File Offset: 0x00299AD4
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290806, XrefRangeEnd = 290807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x0600A6D5 RID: 42709 RVA: 0x0029B90C File Offset: 0x00299B0C
		// (set) Token: 0x0600A6D6 RID: 42710 RVA: 0x0029B94C File Offset: 0x00299B4C
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0600A6D7 RID: 42711 RVA: 0x0029B990 File Offset: 0x00299B90
		// (set) Token: 0x0600A6D8 RID: 42712 RVA: 0x0029B9D0 File Offset: 0x00299BD0
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0600A6D9 RID: 42713 RVA: 0x0029BA14 File Offset: 0x00299C14
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48827, RefRangeEnd = 48829, XrefRangeStart = 48827, XrefRangeEnd = 48829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x0600A6DA RID: 42714 RVA: 0x0029BA54 File Offset: 0x00299C54
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600A6DB RID: 42715 RVA: 0x0029BA94 File Offset: 0x00299C94
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600A6DC RID: 42716 RVA: 0x0029BAD0 File Offset: 0x00299CD0
		// (set) Token: 0x0600A6DD RID: 42717 RVA: 0x0029BB0C File Offset: 0x00299D0C
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A6DE RID: 42718 RVA: 0x0029BB4C File Offset: 0x00299D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290807, XrefRangeEnd = 290811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6DF RID: 42719 RVA: 0x0029BB88 File Offset: 0x00299D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290811, XrefRangeEnd = 290829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E0 RID: 42720 RVA: 0x0029BBC4 File Offset: 0x00299DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290829, XrefRangeEnd = 290834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E1 RID: 42721 RVA: 0x0029BC54 File Offset: 0x00299E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290834, XrefRangeEnd = 290837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrashLevelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_TrashLevelChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E2 RID: 42722 RVA: 0x0029BC88 File Offset: 0x00299E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290837, XrefRangeEnd = 290843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A6E3 RID: 42723 RVA: 0x0029BCEC File Offset: 0x00299EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290843, XrefRangeEnd = 290849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A6E4 RID: 42724 RVA: 0x0029BD30 File Offset: 0x00299F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290849, XrefRangeEnd = 290859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrashAdded(string trashID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_TrashAdded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E5 RID: 42725 RVA: 0x0029BD74 File Offset: 0x00299F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290859, XrefRangeEnd = 290862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_ShowOutline_Public_Virtual_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E6 RID: 42726 RVA: 0x0029BDC0 File Offset: 0x00299FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290862, XrefRangeEnd = 290865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_HideOutline_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E7 RID: 42727 RVA: 0x0029BDFC File Offset: 0x00299FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290865, XrefRangeEnd = 290900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTrashItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_CheckTrashItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E8 RID: 42728 RVA: 0x0029BE30 File Offset: 0x0029A030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290923, RefRangeEnd = 290924, XrefRangeStart = 290900, XrefRangeEnd = 290923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrashToRadius(TrashItem trashItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_AddTrashToRadius_Private_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E9 RID: 42729 RVA: 0x0029BE74 File Offset: 0x0029A074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290945, RefRangeEnd = 290946, XrefRangeStart = 290924, XrefRangeEnd = 290945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrashBagToRadius(TrashBag trashBag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashBag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_AddTrashBagToRadius_Private_Void_TrashBag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6EA RID: 42730 RVA: 0x0029BEB8 File Offset: 0x0029A0B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290972, RefRangeEnd = 290973, XrefRangeStart = 290946, XrefRangeEnd = 290972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrashItemFromRadius(TrashItem trashItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_RemoveTrashItemFromRadius_Private_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6EB RID: 42731 RVA: 0x0029BEFC File Offset: 0x0029A0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290973, XrefRangeEnd = 290992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrashBagFromRadius(TrashBag trashBag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashBag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_RemoveTrashBagFromRadius_Private_Void_TrashBag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6EC RID: 42732 RVA: 0x0029BF40 File Offset: 0x0029A140
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291003, RefRangeEnd = 291005, XrefRangeStart = 290992, XrefRangeEnd = 291003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTrashValid(TrashItem trashItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_IsTrashValid_Private_Boolean_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A6ED RID: 42733 RVA: 0x0029BF90 File Offset: 0x0029A190
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291014, RefRangeEnd = 291016, XrefRangeStart = 291005, XrefRangeEnd = 291014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInRadius(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_IsPointInRadius_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A6EE RID: 42734 RVA: 0x0029BFDC File Offset: 0x0029A1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291016, XrefRangeEnd = 291043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6EF RID: 42735 RVA: 0x0029C018 File Offset: 0x0029A218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291043, XrefRangeEnd = 291044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6F0 RID: 42736 RVA: 0x0029C054 File Offset: 0x0029A254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291044, XrefRangeEnd = 291045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6F1 RID: 42737 RVA: 0x0029C090 File Offset: 0x0029A290
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6F2 RID: 42738 RVA: 0x0029C0CC File Offset: 0x0029A2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291045, XrefRangeEnd = 291049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6F3 RID: 42739 RVA: 0x00052327 File Offset: 0x00050527
		public TrashContainerItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600A6F4 RID: 42740 RVA: 0x0029C108 File Offset: 0x0029A308
		// (set) Token: 0x0600A6F5 RID: 42741 RVA: 0x00052330 File Offset: 0x00050530
		public unsafe static float MAX_VERTICAL_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashContainerItem.NativeFieldInfoPtr_MAX_VERTICAL_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashContainerItem.NativeFieldInfoPtr_MAX_VERTICAL_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600A6F6 RID: 42742 RVA: 0x0029C124 File Offset: 0x0029A324
		// (set) Token: 0x0600A6F7 RID: 42743 RVA: 0x0005233E File Offset: 0x0005053E
		public unsafe TrashContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600A6F8 RID: 42744 RVA: 0x0029C154 File Offset: 0x0029A354
		// (set) Token: 0x0600A6F9 RID: 42745 RVA: 0x0005235D File Offset: 0x0005055D
		public unsafe ParticleSystem Flies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_Flies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_Flies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600A6FA RID: 42746 RVA: 0x0029C184 File Offset: 0x0029A384
		// (set) Token: 0x0600A6FB RID: 42747 RVA: 0x0005237C File Offset: 0x0005057C
		public unsafe AudioSourceController TrashAddedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashAddedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashAddedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600A6FC RID: 42748 RVA: 0x0029C1B4 File Offset: 0x0029A3B4
		// (set) Token: 0x0600A6FD RID: 42749 RVA: 0x0005239B File Offset: 0x0005059B
		public unsafe DecalProjector PickupAreaProjector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_PickupAreaProjector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_PickupAreaProjector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600A6FE RID: 42750 RVA: 0x0029C1E4 File Offset: 0x0029A3E4
		// (set) Token: 0x0600A6FF RID: 42751 RVA: 0x000523BA File Offset: 0x000505BA
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_accessPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600A700 RID: 42752 RVA: 0x0029C214 File Offset: 0x0029A414
		// (set) Token: 0x0600A701 RID: 42753 RVA: 0x000523D9 File Offset: 0x000505D9
		public unsafe bool UsableByCleaners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_UsableByCleaners);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_UsableByCleaners)) = value;
			}
		}

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0600A702 RID: 42754 RVA: 0x0029C23C File Offset: 0x0029A43C
		// (set) Token: 0x0600A703 RID: 42755 RVA: 0x000523F4 File Offset: 0x000505F4
		public unsafe float PickupRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_PickupRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_PickupRadius)) = value;
			}
		}

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0600A704 RID: 42756 RVA: 0x0029C264 File Offset: 0x0029A464
		// (set) Token: 0x0600A705 RID: 42757 RVA: 0x0005240F File Offset: 0x0005060F
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__InputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0600A706 RID: 42758 RVA: 0x0029C294 File Offset: 0x0029A494
		// (set) Token: 0x0600A707 RID: 42759 RVA: 0x0005242E File Offset: 0x0005062E
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0600A708 RID: 42760 RVA: 0x0029C2C4 File Offset: 0x0029A4C4
		// (set) Token: 0x0600A709 RID: 42761 RVA: 0x0005244D File Offset: 0x0005064D
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600A70A RID: 42762 RVA: 0x0029C2EC File Offset: 0x0029A4EC
		// (set) Token: 0x0600A70B RID: 42763 RVA: 0x00052468 File Offset: 0x00050668
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600A70C RID: 42764 RVA: 0x0029C314 File Offset: 0x0029A514
		// (set) Token: 0x0600A70D RID: 42765 RVA: 0x00052483 File Offset: 0x00050683
		public unsafe List<TrashItem> TrashItemsInRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashItemsInRadius);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashItemsInRadius), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600A70E RID: 42766 RVA: 0x0029C344 File Offset: 0x0029A544
		// (set) Token: 0x0600A70F RID: 42767 RVA: 0x000524A2 File Offset: 0x000506A2
		public unsafe List<TrashBag> TrashBagsInRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashBagsInRadius);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashBag>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashBagsInRadius), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600A710 RID: 42768 RVA: 0x0029C374 File Offset: 0x0029A574
		// (set) Token: 0x0600A711 RID: 42769 RVA: 0x000524C1 File Offset: 0x000506C1
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x0600A712 RID: 42770 RVA: 0x0029C39C File Offset: 0x0029A59C
		// (set) Token: 0x0600A713 RID: 42771 RVA: 0x000524DC File Offset: 0x000506DC
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006FE4 RID: 28644
		private static readonly IntPtr NativeFieldInfoPtr_MAX_VERTICAL_OFFSET;

		// Token: 0x04006FE5 RID: 28645
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006FE6 RID: 28646
		private static readonly IntPtr NativeFieldInfoPtr_Flies;

		// Token: 0x04006FE7 RID: 28647
		private static readonly IntPtr NativeFieldInfoPtr_TrashAddedSound;

		// Token: 0x04006FE8 RID: 28648
		private static readonly IntPtr NativeFieldInfoPtr_PickupAreaProjector;

		// Token: 0x04006FE9 RID: 28649
		private static readonly IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x04006FEA RID: 28650
		private static readonly IntPtr NativeFieldInfoPtr_UsableByCleaners;

		// Token: 0x04006FEB RID: 28651
		private static readonly IntPtr NativeFieldInfoPtr_PickupRadius;

		// Token: 0x04006FEC RID: 28652
		private static readonly IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x04006FED RID: 28653
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x04006FEE RID: 28654
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x04006FEF RID: 28655
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x04006FF0 RID: 28656
		private static readonly IntPtr NativeFieldInfoPtr_TrashItemsInRadius;

		// Token: 0x04006FF1 RID: 28657
		private static readonly IntPtr NativeFieldInfoPtr_TrashBagsInRadius;

		// Token: 0x04006FF2 RID: 28658
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006FF3 RID: 28659
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006FF4 RID: 28660
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04006FF5 RID: 28661
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04006FF6 RID: 28662
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04006FF7 RID: 28663
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04006FF8 RID: 28664
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04006FF9 RID: 28665
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04006FFA RID: 28666
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04006FFB RID: 28667
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006FFC RID: 28668
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006FFD RID: 28669
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x04006FFE RID: 28670
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006FFF RID: 28671
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04007000 RID: 28672
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x04007001 RID: 28673
		private static readonly IntPtr NativeMethodInfoPtr_TrashLevelChanged_Private_Void_0;

		// Token: 0x04007002 RID: 28674
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04007003 RID: 28675
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04007004 RID: 28676
		private static readonly IntPtr NativeMethodInfoPtr_TrashAdded_Private_Void_String_0;

		// Token: 0x04007005 RID: 28677
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Virtual_Void_Color_0;

		// Token: 0x04007006 RID: 28678
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Virtual_Void_0;

		// Token: 0x04007007 RID: 28679
		private static readonly IntPtr NativeMethodInfoPtr_CheckTrashItems_Private_Void_0;

		// Token: 0x04007008 RID: 28680
		private static readonly IntPtr NativeMethodInfoPtr_AddTrashToRadius_Private_Void_TrashItem_0;

		// Token: 0x04007009 RID: 28681
		private static readonly IntPtr NativeMethodInfoPtr_AddTrashBagToRadius_Private_Void_TrashBag_0;

		// Token: 0x0400700A RID: 28682
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrashItemFromRadius_Private_Void_TrashItem_0;

		// Token: 0x0400700B RID: 28683
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrashBagFromRadius_Private_Void_TrashBag_0;

		// Token: 0x0400700C RID: 28684
		private static readonly IntPtr NativeMethodInfoPtr_IsTrashValid_Private_Boolean_TrashItem_0;

		// Token: 0x0400700D RID: 28685
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInRadius_Public_Boolean_Vector3_0;

		// Token: 0x0400700E RID: 28686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400700F RID: 28687
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007010 RID: 28688
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007011 RID: 28689
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007012 RID: 28690
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
