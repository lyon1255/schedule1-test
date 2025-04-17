using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.UI.Items;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000644 RID: 1604
	public class ItemSlotUI : MonoBehaviour
	{
		// Token: 0x06008DFE RID: 36350 RVA: 0x0024F244 File Offset: 0x0024D444
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlotUI()
		{
			Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ItemSlotUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr);
			ItemSlotUI.NativeFieldInfoPtr_normalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "normalColor");
			ItemSlotUI.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "highlightColor");
			ItemSlotUI.NativeFieldInfoPtr__assignedSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "<assignedSlot>k__BackingField");
			ItemSlotUI.NativeFieldInfoPtr_IsBeingDragged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "IsBeingDragged");
			ItemSlotUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "Rect");
			ItemSlotUI.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "Background");
			ItemSlotUI.NativeFieldInfoPtr_LockContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "LockContainer");
			ItemSlotUI.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "ItemContainer");
			ItemSlotUI.NativeFieldInfoPtr__ItemUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "<ItemUI>k__BackingField");
			ItemSlotUI.NativeMethodInfoPtr_get_assignedSlot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680928);
			ItemSlotUI.NativeMethodInfoPtr_set_assignedSlot_Protected_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680929);
			ItemSlotUI.NativeMethodInfoPtr_get_ItemUI_Public_get_ItemUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680930);
			ItemSlotUI.NativeMethodInfoPtr_set_ItemUI_Protected_set_Void_ItemUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680931);
			ItemSlotUI.NativeMethodInfoPtr_AssignSlot_Public_Virtual_New_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680932);
			ItemSlotUI.NativeMethodInfoPtr_ClearSlot_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680933);
			ItemSlotUI.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680934);
			ItemSlotUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680935);
			ItemSlotUI.NativeMethodInfoPtr_SetHighlighted_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680936);
			ItemSlotUI.NativeMethodInfoPtr_SetNormalColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680937);
			ItemSlotUI.NativeMethodInfoPtr_SetHighlightColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680938);
			ItemSlotUI.NativeMethodInfoPtr_Lock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680939);
			ItemSlotUI.NativeMethodInfoPtr_Unlock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680940);
			ItemSlotUI.NativeMethodInfoPtr_SetLockVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680941);
			ItemSlotUI.NativeMethodInfoPtr_DuplicateIcon_Public_RectTransform_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680942);
			ItemSlotUI.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680943);
			ItemSlotUI.NativeMethodInfoPtr_OverrideDisplayedQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680944);
			ItemSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680945);
		}

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x06008DFF RID: 36351 RVA: 0x0024F490 File Offset: 0x0024D690
		// (set) Token: 0x06008E00 RID: 36352 RVA: 0x0024F4D0 File Offset: 0x0024D6D0
		public unsafe ItemSlot assignedSlot
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_get_assignedSlot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_set_assignedSlot_Protected_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x06008E01 RID: 36353 RVA: 0x0024F514 File Offset: 0x0024D714
		// (set) Token: 0x06008E02 RID: 36354 RVA: 0x0024F554 File Offset: 0x0024D754
		public unsafe ItemUI ItemUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_get_ItemUI_Public_get_ItemUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_set_ItemUI_Protected_set_Void_ItemUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008E03 RID: 36355 RVA: 0x0024F598 File Offset: 0x0024D798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258291, XrefRangeEnd = 258352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignSlot(ItemSlot s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_AssignSlot_Public_Virtual_New_Void_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E04 RID: 36356 RVA: 0x0024F5E8 File Offset: 0x0024D7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258352, XrefRangeEnd = 258397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_ClearSlot_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E05 RID: 36357 RVA: 0x0024F624 File Offset: 0x0024D824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258397, XrefRangeEnd = 258406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x0024F658 File Offset: 0x0024D858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258406, XrefRangeEnd = 258430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E07 RID: 36359 RVA: 0x0024F694 File Offset: 0x0024D894
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258431, RefRangeEnd = 258433, XrefRangeStart = 258430, XrefRangeEnd = 258431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHighlighted(bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetHighlighted_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E08 RID: 36360 RVA: 0x0024F6D4 File Offset: 0x0024D8D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258434, RefRangeEnd = 258436, XrefRangeStart = 258433, XrefRangeEnd = 258434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormalColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetNormalColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E09 RID: 36361 RVA: 0x0024F714 File Offset: 0x0024D914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258437, RefRangeEnd = 258438, XrefRangeStart = 258436, XrefRangeEnd = 258437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHighlightColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetHighlightColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E0A RID: 36362 RVA: 0x0024F754 File Offset: 0x0024D954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258438, XrefRangeEnd = 258441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_Lock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E0B RID: 36363 RVA: 0x0024F788 File Offset: 0x0024D988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258441, XrefRangeEnd = 258444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_Unlock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E0C RID: 36364 RVA: 0x0024F7BC File Offset: 0x0024D9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258444, XrefRangeEnd = 258447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLockVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetLockVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E0D RID: 36365 RVA: 0x0024F7FC File Offset: 0x0024D9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258447, XrefRangeEnd = 258452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overriddenQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_DuplicateIcon_Public_RectTransform_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x06008E0E RID: 36366 RVA: 0x0024F85C File Offset: 0x0024DA5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 258456, RefRangeEnd = 258459, XrefRangeStart = 258452, XrefRangeEnd = 258456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool shown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E0F RID: 36367 RVA: 0x0024F89C File Offset: 0x0024DA9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258463, RefRangeEnd = 258464, XrefRangeStart = 258459, XrefRangeEnd = 258463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideDisplayedQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_OverrideDisplayedQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E10 RID: 36368 RVA: 0x0024F8DC File Offset: 0x0024DADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E11 RID: 36369 RVA: 0x00044414 File Offset: 0x00042614
		public ItemSlotUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x06008E12 RID: 36370 RVA: 0x0024F918 File Offset: 0x0024DB18
		// (set) Token: 0x06008E13 RID: 36371 RVA: 0x0004441D File Offset: 0x0004261D
		public unsafe Color32 normalColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_normalColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_normalColor)) = value;
			}
		}

		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x06008E14 RID: 36372 RVA: 0x0024F940 File Offset: 0x0024DB40
		// (set) Token: 0x06008E15 RID: 36373 RVA: 0x00044438 File Offset: 0x00042638
		public unsafe Color32 highlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_highlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_highlightColor)) = value;
			}
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x06008E16 RID: 36374 RVA: 0x0024F968 File Offset: 0x0024DB68
		// (set) Token: 0x06008E17 RID: 36375 RVA: 0x00044453 File Offset: 0x00042653
		public unsafe ItemSlot _assignedSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__assignedSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__assignedSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x06008E18 RID: 36376 RVA: 0x0024F998 File Offset: 0x0024DB98
		// (set) Token: 0x06008E19 RID: 36377 RVA: 0x00044472 File Offset: 0x00042672
		public unsafe bool IsBeingDragged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_IsBeingDragged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_IsBeingDragged)) = value;
			}
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x06008E1A RID: 36378 RVA: 0x0024F9C0 File Offset: 0x0024DBC0
		// (set) Token: 0x06008E1B RID: 36379 RVA: 0x0004448D File Offset: 0x0004268D
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x06008E1C RID: 36380 RVA: 0x0024F9F0 File Offset: 0x0024DBF0
		// (set) Token: 0x06008E1D RID: 36381 RVA: 0x000444AC File Offset: 0x000426AC
		public unsafe Image Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x06008E1E RID: 36382 RVA: 0x0024FA20 File Offset: 0x0024DC20
		// (set) Token: 0x06008E1F RID: 36383 RVA: 0x000444CB File Offset: 0x000426CB
		public unsafe GameObject LockContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_LockContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_LockContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x06008E20 RID: 36384 RVA: 0x0024FA50 File Offset: 0x0024DC50
		// (set) Token: 0x06008E21 RID: 36385 RVA: 0x000444EA File Offset: 0x000426EA
		public unsafe RectTransform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x06008E22 RID: 36386 RVA: 0x0024FA80 File Offset: 0x0024DC80
		// (set) Token: 0x06008E23 RID: 36387 RVA: 0x00044509 File Offset: 0x00042709
		public unsafe ItemUI _ItemUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__ItemUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__ItemUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006024 RID: 24612
		private static readonly IntPtr NativeFieldInfoPtr_normalColor;

		// Token: 0x04006025 RID: 24613
		private static readonly IntPtr NativeFieldInfoPtr_highlightColor;

		// Token: 0x04006026 RID: 24614
		private static readonly IntPtr NativeFieldInfoPtr__assignedSlot_k__BackingField;

		// Token: 0x04006027 RID: 24615
		private static readonly IntPtr NativeFieldInfoPtr_IsBeingDragged;

		// Token: 0x04006028 RID: 24616
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006029 RID: 24617
		private static readonly IntPtr NativeFieldInfoPtr_Background;

		// Token: 0x0400602A RID: 24618
		private static readonly IntPtr NativeFieldInfoPtr_LockContainer;

		// Token: 0x0400602B RID: 24619
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x0400602C RID: 24620
		private static readonly IntPtr NativeFieldInfoPtr__ItemUI_k__BackingField;

		// Token: 0x0400602D RID: 24621
		private static readonly IntPtr NativeMethodInfoPtr_get_assignedSlot_Public_get_ItemSlot_0;

		// Token: 0x0400602E RID: 24622
		private static readonly IntPtr NativeMethodInfoPtr_set_assignedSlot_Protected_set_Void_ItemSlot_0;

		// Token: 0x0400602F RID: 24623
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemUI_Public_get_ItemUI_0;

		// Token: 0x04006030 RID: 24624
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemUI_Protected_set_Void_ItemUI_0;

		// Token: 0x04006031 RID: 24625
		private static readonly IntPtr NativeMethodInfoPtr_AssignSlot_Public_Virtual_New_Void_ItemSlot_0;

		// Token: 0x04006032 RID: 24626
		private static readonly IntPtr NativeMethodInfoPtr_ClearSlot_Public_Virtual_New_Void_0;

		// Token: 0x04006033 RID: 24627
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04006034 RID: 24628
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0;

		// Token: 0x04006035 RID: 24629
		private static readonly IntPtr NativeMethodInfoPtr_SetHighlighted_Public_Void_Boolean_0;

		// Token: 0x04006036 RID: 24630
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalColor_Public_Void_Color_0;

		// Token: 0x04006037 RID: 24631
		private static readonly IntPtr NativeMethodInfoPtr_SetHighlightColor_Public_Void_Color_0;

		// Token: 0x04006038 RID: 24632
		private static readonly IntPtr NativeMethodInfoPtr_Lock_Private_Void_0;

		// Token: 0x04006039 RID: 24633
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Private_Void_0;

		// Token: 0x0400603A RID: 24634
		private static readonly IntPtr NativeMethodInfoPtr_SetLockVisible_Public_Void_Boolean_0;

		// Token: 0x0400603B RID: 24635
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateIcon_Public_RectTransform_Transform_Int32_0;

		// Token: 0x0400603C RID: 24636
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x0400603D RID: 24637
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDisplayedQuantity_Public_Void_Int32_0;

		// Token: 0x0400603E RID: 24638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
