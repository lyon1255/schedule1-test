using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200039B RID: 923
	public class ITransitEntity : Il2CppObjectBase
	{
		// Token: 0x06004868 RID: 18536 RVA: 0x0016224C File Offset: 0x0016044C
		// Note: this type is marked as 'beforefieldinit'.
		static ITransitEntity()
		{
			Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ITransitEntity");
			ITransitEntity.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672260);
			ITransitEntity.NativeMethodInfoPtr_get_InputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672261);
			ITransitEntity.NativeMethodInfoPtr_set_InputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672262);
			ITransitEntity.NativeMethodInfoPtr_get_OutputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672263);
			ITransitEntity.NativeMethodInfoPtr_set_OutputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672264);
			ITransitEntity.NativeMethodInfoPtr_get_LinkOrigin_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672265);
			ITransitEntity.NativeMethodInfoPtr_get_AccessPoints_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672266);
			ITransitEntity.NativeMethodInfoPtr_get_Selectable_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672267);
			ITransitEntity.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672268);
			ITransitEntity.NativeMethodInfoPtr_get_IsDestroyed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672269);
			ITransitEntity.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672270);
			ITransitEntity.NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672271);
			ITransitEntity.NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672272);
			ITransitEntity.NativeMethodInfoPtr_InsertItemIntoInput_Public_Virtual_New_Void_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672273);
			ITransitEntity.NativeMethodInfoPtr_InsertItemIntoOutput_Public_Virtual_New_Void_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672274);
			ITransitEntity.NativeMethodInfoPtr_GetInputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672275);
			ITransitEntity.NativeMethodInfoPtr_GetOutputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672276);
			ITransitEntity.NativeMethodInfoPtr_GetOutputItemContainer_Public_Virtual_New_ItemSlot_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672277);
			ITransitEntity.NativeMethodInfoPtr_ReserveInputSlotsForItem_Public_Virtual_New_List_1_ItemSlot_ItemInstance_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672278);
			ITransitEntity.NativeMethodInfoPtr_RemoveSlotLocks_Public_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672279);
			ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingItem_Public_Virtual_New_ItemSlot_String_ESlotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672280);
			ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingTemplateItem_Public_Virtual_New_ItemSlot_ItemInstance_ESlotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672281);
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x0016242C File Offset: 0x0016062C
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x0600486A RID: 18538 RVA: 0x00162470 File Offset: 0x00160670
		// (set) Token: 0x0600486B RID: 18539 RVA: 0x001624BC File Offset: 0x001606BC
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_InputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_set_InputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x0600486C RID: 18540 RVA: 0x0016250C File Offset: 0x0016070C
		// (set) Token: 0x0600486D RID: 18541 RVA: 0x00162558 File Offset: 0x00160758
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_OutputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_set_OutputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x0600486E RID: 18542 RVA: 0x001625A8 File Offset: 0x001607A8
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_LinkOrigin_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x0600486F RID: 18543 RVA: 0x001625F4 File Offset: 0x001607F4
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_AccessPoints_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x00162640 File Offset: 0x00160840
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_Selectable_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06004871 RID: 18545 RVA: 0x00162688 File Offset: 0x00160888
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06004872 RID: 18546 RVA: 0x001626D0 File Offset: 0x001608D0
		public unsafe virtual bool IsDestroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_IsDestroyed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06004873 RID: 18547 RVA: 0x00162718 File Offset: 0x00160918
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x00162760 File Offset: 0x00160960
		[CallerCount(0)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x001627AC File Offset: 0x001609AC
		[CallerCount(0)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x001627E8 File Offset: 0x001609E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162062, XrefRangeEnd = 162104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertItemIntoInput(ItemInstance item, NPC inserter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inserter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_InsertItemIntoInput_Public_Virtual_New_Void_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x00162848 File Offset: 0x00160A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162104, XrefRangeEnd = 162146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertItemIntoOutput(ItemInstance item, NPC inserter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inserter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_InsertItemIntoOutput_Public_Virtual_New_Void_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x001628A8 File Offset: 0x00160AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162146, XrefRangeEnd = 162186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetInputCapacityForItem(ItemInstance item, NPC asker = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetInputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x00162914 File Offset: 0x00160B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162186, XrefRangeEnd = 162226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetOutputCapacityForItem(ItemInstance item, NPC asker = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetOutputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x00162980 File Offset: 0x00160B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162226, XrefRangeEnd = 162244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetOutputItemContainer(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetOutputItemContainer_Public_Virtual_New_ItemSlot_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x001629DC File Offset: 0x00160BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162244, XrefRangeEnd = 162276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<ItemSlot> ReserveInputSlotsForItem(ItemInstance item, NetworkObject locker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_ReserveInputSlotsForItem_Public_Virtual_New_List_1_ItemSlot_ItemInstance_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x00162A4C File Offset: 0x00160C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162276, XrefRangeEnd = 162301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveSlotLocks(NetworkObject locker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(locker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_RemoveSlotLocks_Public_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x00162A9C File Offset: 0x00160C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162301, XrefRangeEnd = 162322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetFirstSlotContainingItem(string id, ITransitEntity.ESlotType searchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingItem_Public_Virtual_New_ItemSlot_String_ESlotType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x00162B08 File Offset: 0x00160D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162322, XrefRangeEnd = 162342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetFirstSlotContainingTemplateItem(ItemInstance templateItem, ITransitEntity.ESlotType searchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(templateItem);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingTemplateItem_Public_Virtual_New_ItemSlot_ItemInstance_ESlotType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x00022F46 File Offset: 0x00021146
		public ITransitEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040030D3 RID: 12499
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040030D4 RID: 12500
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0;

		// Token: 0x040030D5 RID: 12501
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040030D6 RID: 12502
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0;

		// Token: 0x040030D7 RID: 12503
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040030D8 RID: 12504
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x040030D9 RID: 12505
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x040030DA RID: 12506
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040030DB RID: 12507
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040030DC RID: 12508
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040030DD RID: 12509
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x040030DE RID: 12510
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0;

		// Token: 0x040030DF RID: 12511
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040030E0 RID: 12512
		private static readonly IntPtr NativeMethodInfoPtr_InsertItemIntoInput_Public_Virtual_New_Void_ItemInstance_NPC_0;

		// Token: 0x040030E1 RID: 12513
		private static readonly IntPtr NativeMethodInfoPtr_InsertItemIntoOutput_Public_Virtual_New_Void_ItemInstance_NPC_0;

		// Token: 0x040030E2 RID: 12514
		private static readonly IntPtr NativeMethodInfoPtr_GetInputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0;

		// Token: 0x040030E3 RID: 12515
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0;

		// Token: 0x040030E4 RID: 12516
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputItemContainer_Public_Virtual_New_ItemSlot_ItemInstance_0;

		// Token: 0x040030E5 RID: 12517
		private static readonly IntPtr NativeMethodInfoPtr_ReserveInputSlotsForItem_Public_Virtual_New_List_1_ItemSlot_ItemInstance_NetworkObject_0;

		// Token: 0x040030E6 RID: 12518
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSlotLocks_Public_Virtual_New_Void_NetworkObject_0;

		// Token: 0x040030E7 RID: 12519
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstSlotContainingItem_Public_Virtual_New_ItemSlot_String_ESlotType_0;

		// Token: 0x040030E8 RID: 12520
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstSlotContainingTemplateItem_Public_Virtual_New_ItemSlot_ItemInstance_ESlotType_0;

		// Token: 0x02000977 RID: 2423
		[OriginalName("Assembly-CSharp.dll", "", "ESlotType")]
		public enum ESlotType
		{
			// Token: 0x04008881 RID: 34945
			Input,
			// Token: 0x04008882 RID: 34946
			Output,
			// Token: 0x04008883 RID: 34947
			Both
		}

		// Token: 0x02000978 RID: 2424
		[ObfuscatedName("ScheduleOne.Management.ITransitEntity+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9BB RID: 51643 RVA: 0x0030D1CC File Offset: 0x0030B3CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr);
				ITransitEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr, "item");
				ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr, 100672282);
				ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__GetOutputItemContainer_b__0_Internal_Boolean_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr, 100672283);
			}

			// Token: 0x0600C9BC RID: 51644 RVA: 0x0030D234 File Offset: 0x0030B434
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9BD RID: 51645 RVA: 0x0030D270 File Offset: 0x0030B470
			[CallerCount(0)]
			public unsafe bool _GetOutputItemContainer_b__0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__GetOutputItemContainer_b__0_Internal_Boolean_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C9BE RID: 51646 RVA: 0x0006217E File Offset: 0x0006037E
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EE4 RID: 16100
			// (get) Token: 0x0600C9BF RID: 51647 RVA: 0x0030D2C0 File Offset: 0x0030B4C0
			// (set) Token: 0x0600C9C0 RID: 51648 RVA: 0x00062187 File Offset: 0x00060387
			public unsafe ItemInstance item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITransitEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITransitEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008884 RID: 34948
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008885 RID: 34949
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008886 RID: 34950
			private static readonly IntPtr NativeMethodInfoPtr__GetOutputItemContainer_b__0_Internal_Boolean_ItemSlot_0;
		}
	}
}
